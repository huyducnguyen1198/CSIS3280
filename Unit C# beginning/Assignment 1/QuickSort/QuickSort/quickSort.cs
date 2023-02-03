using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSort
    {
        public QuickSort() { }

        public void swap(ref int i, ref int j)
        {
            int tmp = i;
            i = j;
            j = tmp;
        }

        public void quickSort(int[] arr, int low, int hgh)
        {
            if (low < hgh)
            {
                int pivot = partition(arr, low, hgh);
                quickSort(arr, low, pivot - 1);
                quickSort(arr, pivot + 1, hgh);
            }
        }
        public int partition(int[] arr, int low, int hgh)
        {

            int pivot = hgh;
            int storePivot = low - 1;

            for (int i = low; i < hgh; i++)
            {
                if (arr[i] <= arr[pivot])
                {
                    storePivot++;
                    this.swap(ref arr[i], ref arr[storePivot]);
                }
            }
            storePivot++;
            this.swap(ref arr[pivot], ref arr[storePivot]);
            return storePivot;
        }

        public int isSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
