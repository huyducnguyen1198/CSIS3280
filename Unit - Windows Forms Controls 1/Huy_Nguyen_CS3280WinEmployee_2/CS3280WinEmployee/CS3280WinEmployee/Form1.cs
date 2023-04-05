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

namespace CS3280WinEmployee
{
    public partial class Form1 : Form
    {
        Color originalGroupBoxColor = Color.White;
        Color originalSubmitBtnColor = Color.White;
        public Form1()
        {
            InitializeComponent();
            btnSubmit.BackColor = Color.Red;
            originalGroupBoxColor = groupBox1.BackColor;
            groupBox1.BackColor = Color.Aqua;
            cmbState.SelectedItem = "CA";
            radioSalaried.Checked = true;
            originalSubmitBtnColor = btnSubmit.BackColor;

            #region Event intialization region
            btnSubmit.MouseEnter += BtnSubmit_MouseEnter;
            btnSubmit.MouseLeave += BtnSubmit_MouseLeave;

            txtLastname.MouseEnter += TxtLastname_MouseEnter;
            txtLastname.MouseLeave += TxtLastname_MouseLeave;
            txtSSN.Leave += TxtSSN_Leave;
            #endregion
        }

        private void TxtSSN_Leave(object sender, EventArgs e)
        {
            bool isSSNCorrect =   Regex.IsMatch(txtSSN.Text, @"^\d{3}-\d{2}-\d{4}$");
            if (!isSSNCorrect) {
                MessageBox.Show("Enter valid ssn. An example: 111-11-1111");
                txtSSN.Clear();
                txtSSN.Focus();
            }
        }

        private void TxtLastname_MouseLeave(object sender, EventArgs e)
        {
            txtLastname.Size = new Size(txtLastname.Size.Width - 10, txtLastname.Size.Height);
        }
    

        private void TxtLastname_MouseEnter(object sender, EventArgs e)
        {
            txtLastname.Size = new Size(txtLastname.Size.Width + 10, txtLastname.Size.Height);
        }
        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = originalSubmitBtnColor;
            
        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Beige;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbState.SelectedItem.ToString());
            //MessageBox.Show(cmbState.SelectedIndex.ToString());
            
        }

        private void chkMarried_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(chkMarried.Checked.ToString());
        }

        private void radioSalaried_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommision.Checked.ToString());
            //MessageBox.Show(radioBaseComission.Checked.ToString());
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSales.Visible = false;
            lblCommission.Visible = false;
            txtComission.Visible = false;
            txtSales.Visible = false;
        }

        private void radioCommision_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommision.Checked.ToString());
            //MessageBox.Show(radioBaseComission.Checked.ToString());
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblSales.Visible = true;
            lblCommission.Visible = true;
            txtComission.Visible = true;
            txtSales.Visible = true;
        }

        private void radioBaseComission_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommision.Checked.ToString());
            //MessageBox.Show(radioBaseComission.Checked.ToString());
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSales.Visible = true;
            lblCommission.Visible = true;
            txtComission.Visible = true;
            txtSales.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string employeeInformation = string.Empty;
            employeeInformation += txtFirstName.Text + " " +txtLastname.Text + "\r\n";
            employeeInformation += txtAddress1.Text + " " + txtAddress2.Text + " " + cmbState.SelectedItem.ToString() + "\r\n";
            employeeInformation += txtSSN.Text + "\r\n";
            if (txtSalary.Visible) {
                employeeInformation += "Salary : " + txtSalary.Text + "\r\n";
            }
            if (txtComission.Visible) {
                employeeInformation += "Commision Rate : " + txtComission.Text + "\r\n";
            }
            if (txtSales.Visible)
            {
                employeeInformation += "Sales : " + txtSales.Text + "\r\n";
            }
            txtEmployeeInfo.Text = employeeInformation;

            txtEmployeeInfo.Enabled = true;
            groupBox1.BackColor = originalGroupBoxColor;

            Class1 c1 = new Class1();
            
            
        }
    }
}
