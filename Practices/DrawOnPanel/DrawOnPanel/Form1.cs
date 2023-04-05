using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MNIST.Model;


namespace DrawOnPanel
{
    public partial class Form1 : Form
    {

        bool draw = false;
        int pX = -1;
        int pY = -1;
        Bitmap bmp = null;
        public Form1()
        {
            InitializeComponent();
            this.panel1.Size = new System.Drawing.Size(728 / 2, 728 / 2);

            bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());

            Graphics.FromImage(bmp).Clear(Color.White);


        }

        private async Task<String> openai()
        {
            //var api = new OpenAI_API.OpenAIAPI("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");
            //var str = api.Completions.GetCompletion("Did you put your name in the globet of fire?");
            //return str.Result;
            throw new NotImplementedException();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Black, 36);

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

                g.DrawLine(pen, pX, pY, e.X, e.Y);

                panel1.CreateGraphics().DrawImageUnscaled(bmp, new Point(0, 0));
            }
            pX = e.X;
            pY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            pX = e.X;
            pY = e.Y;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bmp, 0, 0);

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            using(Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                panel1.Invalidate();
            }
        }

        private async void btnPredict_Click(object sender, EventArgs e)
        {
            using (MemoryStream m = new MemoryStream())
            {
                Bitmap newbmp = new Bitmap(bmp, new Size(28, 28));

                newbmp.Save("1.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                float[] b = new float[28 * 28];

                for (int i = 0; i < 28; i++)
                {
                    for (int j = 0; j < 28; j++)
                    {
                        Color c = newbmp.GetPixel(j, i);

                        if (c.Name.ToString() == "ff000000")
                        {
                            b[i * 28 + j] = 255;

                        }
                        else
                        {
                            b[i * 28 + j] = 0;
                        }
                    }
                }
                /*
                for (int i = 0; i < 28;i++)
                {
                    for(int j = 0;j < 28; j++)
                    {
                        if (d[i*28+j] == 0)
                        {
                            Console.Write(0);
                        }
                        else
                        {
                            Console.Write(1);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < 28; i++)
                {
                    for (int j = 0; j < 28; j++)
                    {
                        if (b[i * 28 + j] == 0)
                        {
                            Console.Write(0);
                        }
                        else
                        {
                            Console.Write(1);
                        }
                    }
                    Console.WriteLine();
                }
                */
                //
                // create predict model with asynchorus
                var mlModel = Task.Run(()=>LoadModel());
                textBox1.Text = "Loading model";
                
                    // wait
                mlModel.Wait();



                PredictionEngine<ModelInput, ModelOutput> predictModel = getPredictModel(mlModel.Result);
                
                //input data
                ModelInput modelInput = new ModelInput()
                {
                    Features = b,
                    Label = -1

                };
                // position in predict score
                int[] index = { 5, 0, 4, 1, 9, 2, 3, 6, 7, 8 };
                //predict

                textBox1.Text = "Predicting";

                // run predict Asynchronously
                var resultTask = Task.Run(()=>
                    predictModel.Predict(modelInput));
                await Task.Delay(1000);

                resultTask.Wait();
                
                var result = resultTask.Result;

                //Write predict result
                textBox1.Text = result.PredictedLabel.ToString();
                textBox1.Text += Environment.NewLine;
                float mval = result.Score.Max();
                for (int i = 0; i < result.Score.Length; i++)
                {
                    int ind = Array.IndexOf(index, i);

                    if (mval.Equals(result.Score[ind])) {

                        textBox1.Text += "========  ";
                    }
                    
                    textBox1.Text += i + ": " + result.Score[ind];
                    if (mval.Equals(result.Score[ind]))
                    {

                        textBox1.Text += "  ========";
                    }
                    textBox1.Text += Environment.NewLine;

                }
            }
        }
    }
}
