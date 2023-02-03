using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutMySelf
{
    public enum MonthOfYear
    {
        January = 0, February = 1,
        March = 2, April = 3,
        May = 4, June = 5,
        July = 6, August = 7,
        September = 8, October = 9,
        November = 10, December = 11
    }
    public class MyPersonalInformation
    {
        public static void Main(String []args) {
            System.Console.WriteLine("HUy");
            System.Console.ReadLine();
        }
        public MyPersonalInformation() {}  

        public String MyName()
        {
            return "Huy D. Nguyen";
        }

        public void WhatWhatImportantAmIDoingThisMonth(MonthOfYear month)
        {
            switch(month)
            {
                case MonthOfYear.January:
                    System.Console.WriteLine("Focus on getting ahead in class.");
                    break;
                case MonthOfYear.February:
                    System.Console.WriteLine("Actively try to find a job.");
                    break;
                case MonthOfYear.March:
                    System.Console.WriteLine("Focus on the job if having one, or keep trying.");
                    break;
                case MonthOfYear.April:
                    System.Console.WriteLine("work on finishing the term.");
                    break;
                case MonthOfYear.May:
                    System.Console.WriteLine("Put all effort into the job or send out resume ");
                    break;
                case MonthOfYear.June:
                    System.Console.WriteLine("Job and personal project.");
                    break;
                case MonthOfYear.July:
                    System.Console.WriteLine("Register for courses for fall term");
                    break;
                case MonthOfYear.August:
                    System.Console.WriteLine("Keep on with the Job thingy and personal project.");
                    break;
                case MonthOfYear.September:
                    System.Console.WriteLine("Be ready and come back for fall term.");
                    break;
                case MonthOfYear.October:
                    System.Console.WriteLine("Focus on getting ahead in class and job.");
                    break;
                case MonthOfYear.November:
                    System.Console.WriteLine("Keep everything steady.");
                    break;
                case MonthOfYear.December:
                    System.Console.WriteLine("Work on finishing fall term and register for next Spring and relax for Christmas.");
                    break;
                default:
                    System.Console.WriteLine("Work hard, study hard, find a job, and relax if possible.");
                    break;
            }
        }
    }
}
