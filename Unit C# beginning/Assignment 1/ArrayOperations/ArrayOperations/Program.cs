using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
    
            // create array of n random int
            System.Console.WriteLine("Input array length: ");
            String arrLength = System.Console.ReadLine();
            int n = int.Parse(arrLength);

            int [] array = new int[n];

            for(int i = 0; i < n; i++) 
                array[i] = rnd.Next(1, 100000);


            //print
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //Create object of ArrayOperations.

            ArrayOperations arrOp = new ArrayOperations();
            System.Console.WriteLine("Max: " + arrOp.Max(array));
            System.Console.WriteLine("Min: " + arrOp.Min(array));
            System.Console.WriteLine("Avg: " + arrOp.Average(array));

            System.Console.ReadLine();

                        
        }
    }
}
