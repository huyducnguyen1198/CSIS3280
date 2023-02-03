using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            String sNum1 = inputBox1.Text;
            string sNum2 = inputBox2.Text;
            double num1 = double.Parse(sNum1);
            double num2 = double.Parse(sNum2);

            resultLbl.Text =(num1 + num2).ToString();
        }

        

        private void inputBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultLbl_Click(object sender, EventArgs e)
        {

        }

        private void plusLbl_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputBox1.Clear();
            inputBox2.Clear();
            resultLbl.Text = "Ans";
        }
    }
}
