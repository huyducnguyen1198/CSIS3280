using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;
using Microsoft.ML.Trainers;

using System;
using System.Linq;
using System.Collections.Generic;
using static Microsoft.ML.TrainCatalogBase;
using Microsoft.ML.Trainers.LightGbm;

namespace MNIST
{
    public class Model
    {
        private static string MODEL_TRAIN_PATH = "C:\\Users\\ndhuy\\Desktop\\test\\archive\\mnist_train.csv";
        private static string MODEL_TEST_PATH = "C:\\Users\\ndhuy\\Desktop\\test\\archive\\mnist_test.csv";

        private static string MODEL_FILEPATH = "C:\\Users\\ndhuy\\Desktop\\test\\archive\\MLModel.zip";
        public class ModelInput
        {
            [ColumnName("Number"), LoadColumn(0)]
            public Single Label { get; set; }

            [ColumnName("Pixel"), LoadColumn(1, 784), VectorType(784)]
            public float[] Features { get; set; }
        }

        public class ModelOutput
        {
            [ColumnName("PredictedLabel")]
            public Single PredictedLabel { get; set; }
            public float[] Score { get; set; }
        }

        public static MLContext mlContext = new MLContext(seed: 1);
        public static void CreateModel()
        {
            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                path: MODEL_TRAIN_PATH,
                hasHeader: true,
                separatorChar: ','
                );



            IEstimator<ITransformer> trainingPipeline = BuildTrainingPipeLine(mlContext);

            Evaluate(mlContext, trainingDataView, trainingPipeline);

            ITransformer mlModel = TrainModel(mlContext, trainingDataView, trainingPipeline);


            SaveModel(mlContext, mlModel, MODEL_FILEPATH, trainingDataView.Schema);
        }


        public static IEstimator<ITransformer> BuildTrainingPipeLine(MLContext ml)
        {
            var dataProcessPipeline = ml.Transforms.Conversion.MapValueToKey("Number", "Number")
                    .Append(ml.Transforms.Concatenate("Features", "Pixel"))
                    .AppendCacheCheckpoint(ml);


            var trainer1 = ml.MulticlassClassification.Trainers.LightGbm(
                    new LightGbmMulticlassTrainer.Options()
                    {
                        NumberOfLeaves = 10,
                        NumberOfIterations = 400,
                        MinimumExampleCountPerLeaf = 200,
                        LearningRate = 0.409349278019096,
                        LabelColumnName = @"Number",
                        FeatureColumnName = @"Features",
                        ExampleWeightColumnName = null,
                        Booster =
                            new GradientBooster.Options()
                            {
                                SubsampleFraction = 0.67321405981899,
                                FeatureFraction = 0.61351444285399,
                                L1Regularization = 2E-10,
                                L2Regularization = 0.14//0.135990888688446
                            },
                        MaximumBinCountPerFeature = 500
                    }).Append(ml.Transforms.Conversion.MapKeyToValue("PredictedLabel", "PredictedLabel"));

            var trainer = ml.MulticlassClassification.Trainers.SdcaMaximumEntropy(
                labelColumnName: "Number", featureColumnName: "Features",
                maximumNumberOfIterations: 400)
                                .Append(ml.Transforms.Conversion.MapKeyToValue("PredictedLabel", "PredictedLabel"));

            var trainingPipeline = dataProcessPipeline.Append(trainer1);

            return trainingPipeline;
        }

        public static ITransformer TrainModel(MLContext ml, IDataView trainingDataView, IEstimator<ITransformer> trainingPipeline)
        {
            Console.WriteLine("----------------- Training Model ---------------");
            ITransformer model = trainingPipeline.Fit(trainingDataView);
            Console.WriteLine("----------------- End Training   ---------------");

            return model;
        }


        public static void Evaluate(MLContext ml, IDataView trainingDataView, IEstimator<ITransformer> trainingPipeline)
        {
            Console.WriteLine("---------------- Cross Validating to model's accuracy metric ------------------");

            //IDataView normed = ml.Transforms.NormalizeMinMax("Pixel", "Pixel").Fit(trainingDataView).Transform(trainingDataView);

            var crossValidateResults = ml.MulticlassClassification.CrossValidate(trainingDataView, trainingPipeline, numberOfFolds: 2, labelColumnName: "Number");
            PrintMulticlassClassificationFoldsAverageMetrics(crossValidateResults);

        }


        public static void SaveModel(MLContext mL, ITransformer model, String path, DataViewSchema modelInputSchema)
        {
            Console.WriteLine("----------------- Writing Model ----------------");
            mL.Model.Save(model, modelInputSchema, path);
            Console.WriteLine("Model saved: " + path);
        }

        public static ITransformer LoadModel()
        {
            Console.WriteLine("----------------- Loading Model ----------------");
            DataViewSchema modelSchema;
            ITransformer trainedModel = mlContext.Model.Load(MODEL_FILEPATH, out modelSchema);

            return trainedModel;
        }

        public static ModelInput[] getTestData(int num)
        {
 
            var testData = mlContext.Data.LoadFromTextFile<ModelInput>(MODEL_TEST_PATH,
                hasHeader: true,
                separatorChar: ','
                );
            if (num == -1)
            {
                num = (int)testData.GetColumn<float[]>(testData.Schema["Pixel"]).Count();
            }
            //var normData = mlContext.Transforms.NormalizeMinMax("Pixel", "Pixel").Fit(testData).Transform(testData);
            float[][] data = testData.GetColumn<float[]>(testData.Schema["Pixel"]).Take(num).ToArray();
            Single[] label = testData.GetColumn<Single>(testData.Schema["Number"]).Take(num).ToArray();
            ModelInput[] modelInputs = new ModelInput[data.Length];

            for(int i= 0; i < data.Length; i++)
            {
                modelInputs[i] = new ModelInput();
                modelInputs[i].Features = data[i];
                modelInputs[i].Label = label[i];
            }


            return modelInputs;
        }
        public static PredictionEngine<ModelInput, ModelOutput> getPredictModel(ITransformer model){
            var predictModel = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);
            return predictModel;
        }
        public static void PrintMulticlassClassificationFoldsAverageMetrics(IEnumerable<TrainCatalogBase.CrossValidationResult<MulticlassClassificationMetrics>> crossValResults)
        {
            var metricsInMultipleFolds = crossValResults.Select(r => r.Metrics);

            var microAccuracyValues = metricsInMultipleFolds.Select(m => m.MicroAccuracy);
            var microAccuracyAverage = microAccuracyValues.Average();
            var microAccuraciesStdDeviation = CalculateStandardDeviation(microAccuracyValues);
            var microAccuraciesConfidenceInterval95 = CalculateConfidenceInterval95(microAccuracyValues);

            var macroAccuracyValues = metricsInMultipleFolds.Select(m => m.MacroAccuracy);
            var macroAccuracyAverage = macroAccuracyValues.Average();
            var macroAccuraciesStdDeviation = CalculateStandardDeviation(macroAccuracyValues);
            var macroAccuraciesConfidenceInterval95 = CalculateConfidenceInterval95(macroAccuracyValues);

            var logLossValues = metricsInMultipleFolds.Select(m => m.LogLoss);
            var logLossAverage = logLossValues.Average();
            var logLossStdDeviation = CalculateStandardDeviation(logLossValues);
            var logLossConfidenceInterval95 = CalculateConfidenceInterval95(logLossValues);

            var logLossReductionValues = metricsInMultipleFolds.Select(m => m.LogLossReduction);
            var logLossReductionAverage = logLossReductionValues.Average();
            var logLossReductionStdDeviation = CalculateStandardDeviation(logLossReductionValues);
            var logLossReductionConfidenceInterval95 = CalculateConfidenceInterval95(logLossReductionValues);

            Console.WriteLine($"*************************************************************************************************************");
            Console.WriteLine($"*       Metrics for Multi-class Classification model      ");
            Console.WriteLine($"*------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"*       Average MicroAccuracy:    {microAccuracyAverage:0.###}  - Standard deviation: ({microAccuraciesStdDeviation:#.###})  - Confidence Interval 95%: ({microAccuraciesConfidenceInterval95:#.###})");
            Console.WriteLine($"*       Average MacroAccuracy:    {macroAccuracyAverage:0.###}  - Standard deviation: ({macroAccuraciesStdDeviation:#.###})  - Confidence Interval 95%: ({macroAccuraciesConfidenceInterval95:#.###})");
            Console.WriteLine($"*       Average LogLoss:          {logLossAverage:#.###}  - Standard deviation: ({logLossStdDeviation:#.###})  - Confidence Interval 95%: ({logLossConfidenceInterval95:#.###})");
            Console.WriteLine($"*       Average LogLossReduction: {logLossReductionAverage:#.###}  - Standard deviation: ({logLossReductionStdDeviation:#.###})  - Confidence Interval 95%: ({logLossReductionConfidenceInterval95:#.###})");
            Console.WriteLine($"*************************************************************************************************************");

        }

        public static double CalculateStandardDeviation(IEnumerable<double> values)
        {
            double average = values.Average();
            double sumOfSquaresOfDifferences = values.Select(val => (val - average) * (val - average)).Sum();
            double standardDeviation = Math.Sqrt(sumOfSquaresOfDifferences / (values.Count() - 1));
            return standardDeviation;
        }

        public static double CalculateConfidenceInterval95(IEnumerable<double> values)
        {
            double confidenceInterval95 = 1.96 * CalculateStandardDeviation(values) / Math.Sqrt((values.Count() - 1));
            return confidenceInterval95;
        }
    }
}
