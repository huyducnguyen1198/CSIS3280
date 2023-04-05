using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LADateTimePicker
{
    public partial class RootForm : Form
    {

        private ErrorProvider ssnErrorProvider;
        public RootForm()
        {
            InitializeComponent();
            ssnErrorProvider = new ErrorProvider();
            this.mTBoxSSN.Validating += new System.ComponentModel.CancelEventHandler(this.mTBoxSSN_Validating);
            this.mTBoxSSN.Mask = "000-00-0000";
        }

        private void mTBoxSSN_Validating(object sender, CancelEventArgs e)
        {
           

        }

        private void bttnIsBirthday_Click(object sender, EventArgs e)
        {
            String birthday = dateTimePicker1.Value.ToShortDateString();
            String classDay =  monthCalendar1.TodayDate.ToShortDateString();

            if (birthday.Equals(classDay))
            {
                MessageBox.Show("Yay, It is your birthday today!");
            }
        }

        private void btnSSNCheck_Click(object sender, EventArgs e)
        {
            Regex r = new Regex("^(?!0{3})(?!6{3})[0-8]\\d{2}-(?!0{2})\\d{2}-(?!0{4})\\d{4}$");
            String ssn = tBoxSSNReg.Text;
            if(r.IsMatch(ssn))
            {
                MessageBox.Show("SSN: " + ssn + " is Valid.");
            }
            else
            {
                ssnErrorProvider.SetError(this.tBoxSSNReg, ssn);
                MessageBox.Show("SSN: " + ssn + " is not Valid.");

            }
        }

        private void tBoxSSN_TextChanged(object sender, EventArgs e)
        {
            String t = tBoxSSN.Text;
            if(t.Length == 0)
            {
                return;
            }
            else if (Char.IsLetter(t[t.Length - 1]))
            {
                tBoxSSN.Text = tBoxSSN.Text.Substring(0, t.Length - 1);
                tBoxSSN.SelectionStart = t.Length;
            }
            else if(t.Length == 3 || t.Length == 6 )
            {
                tBoxSSN.Text += "-";
                tBoxSSN.SelectionStart = t.Length + 1;
            } else if(t.Length == 12)
            {
                tBoxSSN.Text = tBoxSSN.Text.Substring(0, t.Length - 1);
                tBoxSSN.SelectionStart = t.Length;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        Point prev = new Point();
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black);
            if(MouseButtons.Left == e.Button)
            {
                textBox1.Text = "x: " + MousePosition.X.ToString() + ", y: " + MousePosition.Y.ToString();
                g.DrawLine(p,prev,MousePosition);
                panel1.Invalidate();
            }
            prev.X = e.X;
            prev.Y = e.Y;
        }
    }
}
