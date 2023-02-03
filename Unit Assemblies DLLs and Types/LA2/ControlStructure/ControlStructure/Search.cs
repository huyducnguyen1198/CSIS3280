using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    public class Search
    {
        public Search() { }

        public int IterativeSearch(int[] intArray, int key)
        {
            for(int i = 0; i < intArray.Length; i++)
            {
                if(key == intArray[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /**
         * The array needs to be sorted before using this method. 
         **/
        public int BinaryIterativeSearch(int[] intArray, int key)
        {
            int fst = 0;
            int lst = intArray.Length - 1;
            
            while (fst <= lst)
            {
                int mid = (fst + lst) / 2;
                if ( key == intArray[mid])
                {
                    return mid;
                }else if(key > intArray[mid])
                {
                    fst = mid + 1;
                }
                else
                {
                    lst = mid - 1;
                }
            }
            return -1;
        }
    }
}
