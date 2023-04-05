using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayor
{
    public class Utility
    {
        public static Organization.DepartmentsDataTable getDepartment()
        {
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter 
                = new OrganizationTableAdapters.DepartmentsTableAdapter();

            Organization.DepartmentsDataTable deptTable = new Organization.DepartmentsDataTable();
            deptAdapter.Fill(deptTable);

            return deptTable;
        }

        public static void SaveEmployee(string fname, string lname, string ssn, int deptId, decimal salary, decimal sales, decimal commision)
        {
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter

                                    = new OrganizationTableAdapters.EmployeesTableAdapter();    
            Organization.EmployeesDataTable empTable  = new Organization.EmployeesDataTable();  
            empAdapter.Fill(empTable);
            //new row
            Organization.EmployeesRow newRow = empTable.NewEmployeesRow();
            newRow.FName= fname;
            newRow.LName   = lname;
            newRow.SSN= ssn;
            newRow.DeptID = deptId;
            newRow.Salary = salary;
            newRow.Sales = sales;
            newRow.Commision = commision;

            empTable.AddEmployeesRow(newRow);
            empAdapter.Update(empTable);


        }
        public static Organization.EmployeesDataTable getEmployee()
        {
            //1. adapter
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            
            //2. table
            Organization.EmployeesDataTable empTable = new Organization.EmployeesDataTable();

            empAdapter.Fill(empTable);

            return empTable;

        }

        public static  Organization.EmployeesDataTable getSingleEmployee(int empId)
        {
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();

            //2. table
            Organization.EmployeesDataTable empTable = new Organization.EmployeesDataTable();

            var emp = empTable.Where(x => x.EmpID == empId);
            empAdapter.Fill(empTable);

            return empTable;
        }
    }
}
