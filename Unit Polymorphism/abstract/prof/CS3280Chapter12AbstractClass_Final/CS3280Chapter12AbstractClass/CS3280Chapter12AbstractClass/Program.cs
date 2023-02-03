using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280Chapter12AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee salariedEmploye = new SalariedEmployee("John", "Smith", "111-111-1111", 800m);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-222-222", 22.5m, 40);
            CommisionEmployee commisionEmployee = new CommisionEmployee("Sue", "Jones", "333-333-333", 1000m, 0.10m);
            BasePlusCommisionEmployee basePlusCommisionEmployee = new BasePlusCommisionEmployee("Bob", "Lewis", "444-444-4444", 1000m, 0.08m, 300);

            

            Employee[] employeeArray = new Employee[4];
            employeeArray[0] = salariedEmploye;
            employeeArray[1] = hourlyEmployee;
            employeeArray[2] = commisionEmployee;
            employeeArray[3] = basePlusCommisionEmployee;

            foreach (Employee emp in employeeArray) {
                System.Console.WriteLine(emp);
                if (emp is BasePlusCommisionEmployee) {
                    BasePlusCommisionEmployee b = (BasePlusCommisionEmployee)emp;
                    b.BaseSalary = b.BaseSalary * 1.1m;
                }

                System.Console.WriteLine(emp.Earning());
                
            }



            Console.ReadLine();
        }
    }
}
