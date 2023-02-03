using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Math
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

        public double AddDouble(double x, double y) { return x + y; }

        public double SubstractDouble(double x, double y) { return x - y; }

        public double MultipleDouble(double x, double y) { return x * y; }

        public double DivideDouble(int x, int y) { return x / y; }
    }
}
