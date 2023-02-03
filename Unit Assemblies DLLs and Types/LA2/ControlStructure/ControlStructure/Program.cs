using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            System.Console.WriteLine("*******Max of two numbers*********");
            Random rnd = new Random();
            int num1 = rnd.Next(0, 10000);
            int num2 = rnd.Next(0, 10000);

            Max max = new Max();

            System.Console.WriteLine("First  Num:   "+num1);
            System.Console.WriteLine("Second Num:   "+num2);
            System.Console.WriteLine("Max:          "+max.maxOf2Numbers(num1, num2));


            int num3 = rnd.Next(0, 10000);
            System.Console.WriteLine("*******Max of three numbers*********");
            System.Console.WriteLine("First  Num:   " + num1);
            System.Console.WriteLine("Second Num:   " + num2);
            System.Console.WriteLine("Thrid  Num:   " + num3);
            System.Console.WriteLine("Max:          " + max.maxOf3Numbers(num1, num2, num3));



            System.Console.WriteLine("*******Iterative Search*********");

            System.Console.WriteLine("Input number of elements: ");

            String sNum = System.Console.ReadLine();
            int n = int.Parse(sNum);
            int[] intArray = new int[n];
            for(int i = 0; i < n; i++)
            {
                intArray[i] = rnd.Next(0, 10000);
                System.Console.Write(intArray[i] + " " );
            }

            System.Console.WriteLine("\nWhich value to search for index?");
            int key = int.Parse(System.Console.ReadLine());

            Search search = new Search();
            int idx = search.IterativeSearch(intArray, key);
            if (idx == -1)
            {
                System.Console.WriteLine("Wrong key");
            } else 
                System.Console.WriteLine(key + " is at index " + idx );



            System.Console.WriteLine("******* Binary Iterative Search*********");

            Array.Sort(intArray);

            foreach(int val in intArray)
            {
                System.Console.Write(val + " ");
            }
            System.Console.WriteLine();

            System.Console.WriteLine("\nWhich value to search for index?");
            key = int.Parse(System.Console.ReadLine());

            idx = search.BinaryIterativeSearch(intArray, key);
            if (idx == -1)
            {
                System.Console.WriteLine("Wrong key");
            }
            else
                System.Console.WriteLine(key + " is at index " + idx);

            System.Console.ReadLine();
            */

            Console.WriteLine("---------------------- Enum - Switch - Case--------------------");

            DaysOfWeek3280 today = DaysOfWeek3280.Tuesday;
            ClassSchedule schedule = new ClassSchedule();

            schedule.WhatAreYouDoingToday(today);
            System.Console.ReadLine();
        }
    }
}
