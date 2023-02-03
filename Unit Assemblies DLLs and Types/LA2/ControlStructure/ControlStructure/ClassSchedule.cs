using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    public enum DaysOfWeek3280 { Sunday = 0,
                                 Monday = 1,
                                 Tuesday = 2,
                                 Wednesday = 3,
                                 Thursday = 4,
                                 Friday = 5,
                                 Saturday = 6};
    internal class ClassSchedule
    {
        public void WhatAreYouDoingToday(DaysOfWeek3280 day)
        {
            switch (day)
            {
                case DaysOfWeek3280.Sunday:
                    System.Console.WriteLine("Work");
                    break;
                case DaysOfWeek3280.Monday:
                    System.Console.WriteLine("Work");
                    break;
                case DaysOfWeek3280.Tuesday:
                    System.Console.WriteLine("CSIS 3280");
                    break;
                case DaysOfWeek3280.Wednesday:
                    System.Console.WriteLine("Self Study, find job");
                    break;
                case DaysOfWeek3280.Thursday:
                    System.Console.WriteLine("CSIS 3280");
                    break;
                case DaysOfWeek3280.Friday:
                    System.Console.WriteLine("Work");
                    break;
                case DaysOfWeek3280.Saturday:
                    System.Console.WriteLine("Work");
                    break;
                default:
                    System.Console.WriteLine("Eat study work sleep repeat");
                    break;
            }
        }
    }
}
