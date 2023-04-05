using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment
{
    public class MathSingleParameterOperations
    {
        public double sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        public double sqr(double x)
        {
            return Math.Pow(x, 2);
        }

        public double cub(double x)
        {
            return Math.Pow(x, 3);

        }

    }
}
