using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280WinEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }
    }
}
