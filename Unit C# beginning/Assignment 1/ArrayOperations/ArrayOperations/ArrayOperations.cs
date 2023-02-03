using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class ArrayOperations
    {
        public ArrayOperations() { }


        /**
         * Max item in array
         * args: int array
         * return: max
         */

        public int Max(int []arr)
        {
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        /**
         * min item in array
         * args: int array
         * return: min
         */

        public int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        /**
         * avg of array
         * args: int array
         * return: avg
         */

        public double Average(int[] arr)
        {
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            return (1.0f * avg) / arr.Length ;
        }
    }    
}

