using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommisionEmployee commisionEmployee = new CommisionEmployee("Alex", "Doe", "111-111-1111", 5000m, 0.20m);
            BasePlusCommisionEmployee basePlusComissionEmployee = new BasePlusCommisionEmployee("Jane", "Lee", "222-222-2222", 4000m, 0.10m, 800m);

            //commisionEmployee.SSN = "333-333-3333"; Not allowed.
            System.Console.WriteLine("Commision Employee Info:");

            System.Console.WriteLine("Gross Sales:" + commisionEmployee.GrossSales);
            //System.Console.WriteLine("SSN:" + commisionEmployee.SSN);
            System.Console.WriteLine("Earning:" + commisionEmployee.Earning());


            // Base + Commision Employee Info
            System.Console.WriteLine("Base + Commision Employee Info:");
            System.Console.WriteLine("Gross Sales:" + basePlusComissionEmployee.GrossSales);
            //System.Console.WriteLine("SSN:" + basePlusComissionEmployee.SSN);
            System.Console.WriteLine("Earning:" + basePlusComissionEmployee.Earning());

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            commisionEmployee.PrintInfo();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            basePlusComissionEmployee.PrintInfo();

            System.Console.ReadLine();
        }
    }
}
