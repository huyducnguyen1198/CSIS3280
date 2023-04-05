using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static MNIST.Model;
using Microsoft.ML.Trainers.LightGbm;
namespace DrawOnPanel
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
            /*
            CreateModel();
            var mlModel = LoadModel();
            PredictionEngine<ModelInput, ModelOutput> predictModel = getPredictModel(mlModel);
            ModelInput[] data = getTestData(-1);
            int correct = 0;
            for(int i = 0; i < data.Length; i++)
            {
                var result = predictModel.Predict(data[i]);
                if (data[i].Label == result.PredictedLabel)
                {
                    correct++;
                }
            }
            float accuracy = (float)correct / (float)data.Length;
            Console.WriteLine("Test accuracy: {0,5}", accuracy.ToString());
            Console.ReadLine();*/
        }

    }
}
