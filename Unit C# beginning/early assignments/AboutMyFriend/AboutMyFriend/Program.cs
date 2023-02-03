using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AboutMySelf;
namespace AboutMyFriend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AboutMySelf.MyPersonalInformation Justin = new AboutMySelf.MyPersonalInformation();
            AboutMySelf.MonthOfYear[] months = { AboutMySelf.MonthOfYear.January,
                                                    AboutMySelf.MonthOfYear.February,
                                                        AboutMySelf.MonthOfYear.March,
                                                            AboutMySelf.MonthOfYear.April,
                                                AboutMySelf.MonthOfYear.May,
                                                    AboutMySelf.MonthOfYear.June,
                                                        AboutMySelf.MonthOfYear.July,
                                                            AboutMySelf.MonthOfYear.August,
                                                AboutMySelf.MonthOfYear.September,
                                                    AboutMySelf.MonthOfYear.October,
                                                        AboutMySelf.MonthOfYear.November,
                                                            AboutMySelf.MonthOfYear.December };
            String[] monthNames = Enum.GetNames(typeof(AboutMySelf.MonthOfYear));
            for(int i = 0; i < months.Length;i++)
            {
                System.Console.Write(monthNames[i] + ": ");
                Justin.WhatImportantAmIDoingThisMonth(months[i]);
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
}
