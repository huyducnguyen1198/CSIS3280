using DataAccessLayor;
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

            #region Data Access
            Organization.DepartmentsDataTable dtDeptTable = Utility.getDepartment();

            deptCBox.DataSource = dtDeptTable;
            deptCBox.DisplayMember = dtDeptTable.DeptNameColumn.ColumnName;
            deptCBox.ValueMember = dtDeptTable.DeptIDColumn.ColumnName ;
            #endregion


            #region datagrid 

            Organization.EmployeesDataTable empTable = Utility.getEmployee();
            dGridEmp.DataSource = empTable;

            //turn off an entire colum, read only column
            dGridEmp.Columns[3].ReadOnly= true;
            dGridEmp.Columns["Salary"].Visible = false;
            dGridEmp.Columns["Sales"].Visible = false;
            dGridEmp.Columns["Commision"].Visible = false;


            DataGridViewButtonColumn deleteColum = new DataGridViewButtonColumn();
            deleteColum.Text = "Delete";
            deleteColum.Name = "deleteButton";
            deleteColum.HeaderText = "Live Delete";
            deleteColum.UseColumnTextForButtonValue = true;
            dGridEmp.Columns.Add(deleteColum);
            DataGridViewButtonColumn editColum = new DataGridViewButtonColumn();
            editColum.Text = "Edit";
            editColum.Name = "editButton";
            editColum.HeaderText = "Live Delete";
            editColum.UseColumnTextForButtonValue = true;
            
            dGridEmp.Columns.Insert(dGridEmp.ColumnCount, editColum);

            //dGridEmp.CellValueChanged += new DataGridViewCellEventHandler(DGridEmp_CellValueChanged);
            dGridEmp.CellValueChanged += DGridEmp_CellValueChanged;
            dGridEmp.CellClick += DGridEmp_CellClick;
            #endregion
        }

        private void DGridEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(sender is DataGridView)
            {
                DataGridView dg = (DataGridView)sender;
                if (dg.SelectedCells.Count == 1){
                    var x = dg.SelectedCells[0];
                    if(x is DataGridViewButtonCell)
                    {
                        //get cell from Datagrid
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)x;
                        //turn get row from cell
                        var r = dg.Rows[buttonCell.RowIndex];
                        DataGridViewRow row = (DataGridViewRow)r;

                        //get Emp Id from row 
                        System.Diagnostics.Debug.WriteLine(row.Cells["EmpID"]);
                        int empId = int.Parse(row.Cells["EmpID"].Value.ToString());

                        if(e.ColumnIndex == -1)
                        {
                            //select entire row
                            // need to populate entire form

                            // need an employee id
                        }

                        if (buttonCell.Value.ToString().ToUpper().Equals("EDIT"))
                        {
                            Organization.EmployeesDataTable employeesDataTable = Utility.getSingleEmployee(empId);


                        }

                    }

                }
            }
            
        }

        private void DGridEmp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
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


            int deptId = int.Parse(deptCBox.SelectedValue.ToString());
            decimal salary = txtSalary.Text == string.Empty ? 0: decimal.Parse(txtSalary.Text);
            decimal sales = txtSales.Text == string.Empty ? 0: decimal.Parse(txtSales.Text);
            decimal commision = txtComission.Text == String.Empty ? 0: decimal.Parse(txtComission.Text);

            Utility.SaveEmployee(txtFirstName.Text, txtLastname.Text, txtSSN.Text, deptId, salary, sales, commision);

            dGridEmp.DataSource = null;
            dGridEmp.DataSource = Utility.getEmployee();
            dGridEmp.Update();
            dGridEmp.Refresh();
        }

        private void deptCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(deptCBox.SelectedValue.ToString());
        }
        private void RefreshGrid()
        {
            Organization.EmployeesDataTable empTable = Utility.getEmployee();
            dGridEmp.DataSource = empTable;
        }
    }
}
