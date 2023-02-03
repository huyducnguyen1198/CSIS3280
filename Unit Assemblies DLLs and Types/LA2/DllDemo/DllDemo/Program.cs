using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace DllDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathLibrary.Math math = new MathLibrary.Math();
            int sum = math.Add(3, 4);

            System.Diagnostics.Debug.WriteLine("3 + 4 = " + sum);



            Double sumDouble = math.AddDouble(3.14, 2.17);
            System.Diagnostics.Debug.WriteLine("3.14 + 2.17 = " + sumDouble);

            System.Console.ReadLine();
        }
    }
}
