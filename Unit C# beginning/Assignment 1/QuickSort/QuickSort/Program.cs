using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            System.Console.WriteLine("input the number of element: ");
            int n = int.Parse(System.Console.ReadLine());

            int[] arr = new int[n]; 

            for(int i = 0; i< n; i++) arr[i] = rnd.Next(0,100000);

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //qsort

            QuickSort qsort = new QuickSort(); 

            qsort.quickSort(arr,0, n - 1);


            //after
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
