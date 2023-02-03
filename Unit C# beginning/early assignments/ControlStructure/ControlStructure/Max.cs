using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    public class Max
    {
        public Max() { }

        public int maxOf2Numbers(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        public int maxOf3Numbers(int num1, int num2, int num3) {
            int firstCompare = maxOf2Numbers(num1, num2);
            int secondCompare = maxOf2Numbers(firstCompare, num3);
            return secondCompare;
        }
    }
}
