using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empJohnDoe = new Employee("Jonh", "Doe", "111-111-1111", 35000m);
            empJohnDoe.FirstName = "John";
            Employee empJaneLee= new Employee("Jane", "Lee", "222-222-2222", 40000m, "123 Main St Layton UT");

            System.Console.WriteLine("Jane SSN: " +  empJaneLee.SSN);
            System.Console.WriteLine("Jane Address: " +  empJaneLee.Address);

            empJaneLee.Address = "123 Main St Ogden UT";
            System.Console.WriteLine("Jane Address: " + empJaneLee.Address);

            System.Console.WriteLine("Full name Jane: " + empJaneLee.FullName);

            System.Console.WriteLine("Jane lee tax before calculation is: " + empJaneLee.Tax);

            empJaneLee.ComputeTax(0.12m);
            System.Console.WriteLine("Jane lee tax after calculation is: " + empJaneLee.Tax);


            Employee empArpit = new Employee("Arpit", "Christi", "333-333-3333");
            try
            {
                empArpit.Salary = 20000m;
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException) {
                System.Console.WriteLine("ERRROR: " + argumentOutOfRangeException.Message);
            }
            System.Console.WriteLine("Full name Arpit: " + empArpit.FullName);


            OutsideEntity outsideEntity = new OutsideEntity();
            outsideEntity.ViewEmployee(empJohnDoe);

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("*********************** Printing Jane Lee Employee Information ");
            empJaneLee.PrintEmployeeInfo();

            System.Console.ReadLine();

        }
    }
}
