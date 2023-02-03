using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReferenceVsValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int originalValue = 10;

            Car car = new Car();

            car._make = "Toyota";
            car._model = "Camry";
            car._price = 23000m;
            car._yearBuilt = 2019;

            System.Console.WriteLine("-----------before change ------------");
            System.Console.WriteLine("Original value: " + originalValue);

            System.Console.WriteLine("Make: " + car._make + ", Model: " + car._model + ", Price: " + car._price + ", Year: " + car._yearBuilt);
            

            PassByReferenceValue passByReferenceValue= new PassByReferenceValue();
            passByReferenceValue.ExampleMethod(originalValue, car);

            System.Console.WriteLine("-----------After change ------------");

            System.Console.WriteLine("Changed value: " + originalValue);

            System.Console.WriteLine("Make: " + car._make + ", Model: " + car._model + ", Price: " + car._price + ", Year: " + car._yearBuilt);



            System.Console.WriteLine("-----------Change int by passing as ref ------------");

            int orgVal = 10;

            System.Console.WriteLine("-----------before change ------------");
            System.Console.WriteLine("Original value: " + orgVal);

            passByReferenceValue.ChangeIntValueByPassingAsReference(ref orgVal);

            System.Console.WriteLine("-----------After change ------------");

            System.Console.WriteLine("Changed value: " + orgVal);
            System.Console.ReadLine();


        }
    }
}
