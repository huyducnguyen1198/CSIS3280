using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 build your adapter
            //2 build your datatable
            //3 adapter.Fill to fill datatable
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter =
                                        new OrganizationTableAdapters.DepartmentsTableAdapter();
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            deptAdapter.Fill(dtDeptTable);



            Organization.DepartmentsRow newRow = dtDeptTable.NewDepartmentsRow();
            newRow.DeptName = "Computer Science";
            newRow.Location = "SLC";

            ;
            dtDeptTable.AddDepartmentsRow(newRow);

            deptAdapter.Update(dtDeptTable);




            foreach (Organization.DepartmentsRow row in dtDeptTable.Rows)
            {
                Console.WriteLine(row.DeptID + "\t" + row.DeptName + "\t" + row.Location);
            }
            Console.ReadLine();
        }
    }
}
