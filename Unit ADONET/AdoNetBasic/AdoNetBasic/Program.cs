using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ConnectionString = "Data Source=LAPTOP-DDK6LERA; Initial Catalog=cs3280Spr23;Integrated Security=True";

            SqlConnection sqlConnection= new SqlConnection(ConnectionString);   
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Departments", sqlConnection);
            command.CommandType = CommandType.Text;

            //Adapter

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand= command;

            //Dataset

            DataSet ds = new DataSet();

            //Use adapter to do Query

            adapter.Fill(ds);

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(row["DeptID"] + "\t" + row["DeptName"] + "\t" + row["Location"]);
            }

            System.Diagnostics.Debug.WriteLine(ds);
            System.Console.ReadLine();
        }
    }
}
