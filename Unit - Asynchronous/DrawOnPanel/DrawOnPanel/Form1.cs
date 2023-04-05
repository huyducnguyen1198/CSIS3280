using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Bitmap[] bmp = new Bitmap[4];
        Panel[] panelList;

        public Form1()
        {
            InitializeComponent();

            panelList = new Panel[4];
            panelList[0] = panel1;
            panelList[1] = panel2;
            panelList[2] = panel3;
            panelList[3] = panel4;


            #region innitialize drawing panel 1->4
            //panel 1
            this.panel1.Size = new System.Drawing.Size(784 / 4, 784 / 4);

            bmp[0] = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());

            Graphics.FromImage(bmp[0]).Clear(Color.White);


            //panel 2
            this.panel2.Size = new System.Drawing.Size(784 / 4, 784 / 4);

            bmp[1] = new Bitmap(panel2.Width, panel2.Height, panel2.CreateGraphics());

            Graphics.FromImage(bmp[1]).Clear(Color.White);

            //Panel 3
            this.panel3.Size = new System.Drawing.Size(784 / 4, 784 / 4);

            bmp[2] = new Bitmap(panel3.Width, panel3.Height, panel3.CreateGraphics());

            Graphics.FromImage(bmp[2]).Clear(Color.White);

            //Panel 4
            this.panel4.Size = new System.Drawing.Size(784 / 4, 784 / 4);

            bmp[3] = new Bitmap(panel4.Width, panel4.Height, panel4.CreateGraphics());

            Graphics.FromImage(bmp[3]).Clear(Color.White);
            #endregion


            #region innitialize delegate fro panel2,3,4
            //panel 2
            panel2.MouseUp += panel2_MouseUp;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;

            //panel 3
            panel3.MouseUp += panel3_MouseUp;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;

            //panel 2
            panel4.MouseUp += panel4_MouseUp;
            panel4.MouseDown += panel4_MouseDown;
            panel4.MouseMove += panel4_MouseMove;


            #endregion


        }

        #region 3 methods control drawing panel 1
        //3 methods control drawing panel 1

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = Graphics.FromImage(bmp[0]);
                Pen pen = new Pen(Color.Black, 24);

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

                g.DrawLine(pen, pX, pY, e.X, e.Y);

                panel1.CreateGraphics().DrawImageUnscaled(bmp[0], new Point(0, 0));
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
        #endregion


        #region 3 methods control drawing panael 2
        //3 methods control drawing panel 2

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = Graphics.FromImage(bmp[1]);
                Pen pen = new Pen(Color.Black, 24);

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

                g.DrawLine(pen, pX, pY, e.X, e.Y);

                panel2.CreateGraphics().DrawImageUnscaled(bmp[1], new Point(0, 0));
            }
            pX = e.X;
            pY = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            pX = e.X;
            pY = e.Y;

        }

        #endregion 

        #region 3 methods control drawing panael 3
        //3 methods control drawing panel 2

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = Graphics.FromImage(bmp[2]);
                Pen pen = new Pen(Color.Black, 24);

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

                g.DrawLine(pen, pX, pY, e.X, e.Y);

                panel3.CreateGraphics().DrawImageUnscaled(bmp[2], new Point(0, 0));
            }
            pX = e.X;
            pY = e.Y;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            pX = e.X;
            pY = e.Y;

        }

        #endregion 


        #region 3 methods control drawing panael 4
        //3 methods control drawing panel 4

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = Graphics.FromImage(bmp[3]);
                Pen pen = new Pen(Color.Black, 24);

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

                g.DrawLine(pen, pX, pY, e.X, e.Y);

                panel4.CreateGraphics().DrawImageUnscaled(bmp[3], new Point(0, 0));
            }
            pX = e.X;
            pY = e.Y;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            pX = e.X;
            pY = e.Y;

        }

        #endregion


        #region 4 methods innitialize 4 paint panels
        // 4 methods innitialize paint panel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bmp[0], 0, 0);

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bmp[1], 0, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bmp[2], 0, 0);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bmp[3], 0, 0);
        }

        #endregion


        #region Deep Learning Model

        // Predict asynch
        public async Task GetModelAndPredictAsynch()
        {
            //to avoid textbox invalid operation 
            if(textBox1.InvokeRequired)
            {
                textBox1.Invoke(
                    new MethodInvoker(
                        delegate ()
                        {
                            GetModelAndPredictAsynch();
                        }
                    )
                    );
                return;
            }

            // create predict model with asynchorus
            var mlModel = Task.Run(() => LoadModel());
            textBox1.Text = "Loading model";

            // wait
            await mlModel;
            PredictionEngine<ModelInput, ModelOutput> predictModel = getPredictModel(mlModel.Result);
            textBox1.Text = "Predicting";
            var time = Stopwatch.StartNew();
            Task<ModelOutput>[] t = new Task<ModelOutput>[4];
            int[] val = new int[4];
            for(int i = 0; i < 4; i++)
            {
                ModelInput modelInput = GetModelInput(i);
                t[i] = Task.Run(() => predict(predictModel, modelInput));
                //val[i] = (int)predict(predictModel, modelInput).Result.PredictedLabel;//

            }
            //await Task.WhenAll(t);
            textBox1.Text = "Asynchronous" + Environment.NewLine;
            for(int i = 0; i< 4; i++)
            {
                //textBox1.Text += val[i];
                textBox1.Text += t[i].Result.PredictedLabel;
            }
            time.Stop();
            int elapsed = (int)time.ElapsedMilliseconds;

            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Elapsed time: " + elapsed;
        }

        // run synchronously
        public void GetModelAndPredict()
        {
            //to avoid invalid operation
            if (tBoxSynch.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(
                        delegate ()
                        {
                             GetModelAndPredict();
                        }
                        )
                    );
                return;
            }

            // create predict model with asynchorus
            var mlModel = Task.Run(() => LoadModel());
            tBoxSynch.Text = "Loading model";

            // wait
            mlModel.Wait();
            PredictionEngine<ModelInput, ModelOutput> predictModel = getPredictModel(mlModel.Result);
            tBoxSynch.Text = "Predicting";
            var time = Stopwatch.StartNew();
            int[] val = new int[4];
            for (int i = 0; i < 4; i++)
            {
                ModelInput modelInput = GetModelInput(i);
                val[i] = (int)predict(predictModel, modelInput).Result.PredictedLabel;//

            }
            tBoxSynch.Text = "Synchronous" + Environment.NewLine;

            for (int i = 0; i < 4; i++)
            {
                tBoxSynch.Text += val[i];
            }
            time.Stop();
            int elapsed = (int)time.ElapsedMilliseconds;
            tBoxSynch.Text += Environment.NewLine;
            tBoxSynch.Text += "Elapsed time: " + elapsed;
        }


        // get model input
        public ModelInput GetModelInput(int panel)
        {
            if(panel > 4 & panel < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            using (MemoryStream m = new MemoryStream())
            {
                Bitmap newbmp = new Bitmap(bmp[panel], new Size(28, 28));

                newbmp.Save("val"+panel+".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
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
                //input data
                ModelInput modelInput = new ModelInput()
                {
                    Features = b,
                    Label = -1

                };
                return modelInput;
            }
        }

        // get prediction
        public async Task<ModelOutput> predict(PredictionEngine<ModelInput, ModelOutput> predictModel, ModelInput modelInput)
        {
            if (predictModel != null)
            {
                var result = predictModel.Predict(modelInput);
                System.Threading.Thread.Sleep(1000);
                return result;
            }
            System.Threading.Thread.Sleep(1000);
            return null;
        }

        #endregion



        #region button
        private async void btnPredict_ClickAsync(object sender, EventArgs e)
        {
             var asynchr =  Task.Run(() => GetModelAndPredictAsynch());

            await asynchr;


            var synchr =  Task.Run(() => GetModelAndPredict());


        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< 4; i++)
            {
                using (Graphics g = Graphics.FromImage(bmp[i]))
                {
                    g.Clear(Color.White);
                    panelList[i].Invalidate();
                }
            }
            
        }
        #endregion
    }
}
