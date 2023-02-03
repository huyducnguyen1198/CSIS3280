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
            BasePlusCommisionEmployee basePlusComissionEmployee2 = new BasePlusCommisionEmployee("Jane", "Lee", "222-222-2222", 3000m, 0.08m, 900m);

            System.Console.WriteLine("***************** CommisionEmployee = CommisionEmployee *****************");
            System.Console.WriteLine(commisionEmployee.Earning());
            System.Console.WriteLine();

            System.Console.WriteLine("***************** basePlusComissionEmployee = basePlusComissionEmployee *****************");
            System.Console.WriteLine(basePlusComissionEmployee.Earning());
            System.Console.WriteLine();

            System.Console.WriteLine("Polymorphism");
            CommisionEmployee commisionEmployee1 =  new BasePlusCommisionEmployee("Jane", "Lee", "222-222-2222", 4000m, 0.10m, 800m);
            System.Console.WriteLine(commisionEmployee1.Earning());
            System.Console.WriteLine();

            System.Console.WriteLine("***************** CommisionEmployee = basePlusComissionEmployee *****************");
            commisionEmployee = basePlusComissionEmployee;
            System.Console.WriteLine(commisionEmployee.Earning());
            System.Console.WriteLine();


            CommisionEmployee[] array = new CommisionEmployee[3];

            array[0] = commisionEmployee;
            array[1] = basePlusComissionEmployee;
            array[2] = basePlusComissionEmployee2;


            System.Console.WriteLine("******************** Array ***************");

            foreach (CommisionEmployee i in array)
            {
                System.Console.WriteLine(i.Earning());
            }
            System.Console.ReadLine();
        }
    }
}
