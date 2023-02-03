using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReferenceVsValue
{
    public class PassByReferenceValue
    {
        public void ExampleMethod(int intValue, Car car)
        {
            //increament pass by value(original value) by one
            intValue++;

            //change data pass by reference
            car._make = "Nissan";
            car._model = "Altima";
            car._price = 22000;
        }

        public void ChangeIntValueByPassingAsReference(ref int intValue)
        {
            intValue++;
        }
    }
}
