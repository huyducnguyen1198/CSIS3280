using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateAssignment
{

    public partial class Form1 : Form
    {
        public delegate double function(double x);
        function f = null;
        event function fEvent;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void compute_Click(object sender, EventArgs e)
        {
            if (this.txtBox1.Text.Length > 0)
            {
                double val = double.Parse(this.txtBox1.Text);
                double ans = -1;
                MathSingleParameterOperations op = new MathSingleParameterOperations();

                if (this.sqrt.Checked)
                {
                    f = new function(op.sqrt);
                    ans = f(val);
                }
                else if (this.sqr.Checked)
                {
                    f = new function(op.sqr);
                    ans = f(val);
                }
                else if (this.cube.Checked)//cube checked
                {
                    f = new function(op.cub);
                    ans = f(val);
                }
                else
                {
                    this.ans.Text = "Pick an option!";

                }
                if (ans != -1)
                {
                    ans = Math.Round(ans, 4);
                    MessageBox.Show(ans.ToString());
                }
            }
            else
            {
                this.ans.Text = "Input a positive number!";
            }
        }

        private void rm_Click(object sender, EventArgs e)
        {
            this.txtBox1.Text = "";
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            this.ans.Text = "";
            double val;
            bool isNum = double.TryParse(this.txtBox1.Text, out val);
            if (!isNum)
            {
                this.ans.Text = "Input a positive number.";
            } else
            {
                if(val.CompareTo(0) < 0)
                {
                    this.ans.Text = "Input a positive number.";
                }
            }
        }
    }
}
