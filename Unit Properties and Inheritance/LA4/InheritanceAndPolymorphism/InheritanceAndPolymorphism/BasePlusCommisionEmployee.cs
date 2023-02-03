using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class BasePlusCommisionEmployee : CommisionEmployee
    {
        private decimal _baseSalary;

        public decimal BaseSalary
        {
            get { return _baseSalary; }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Base Salary", "Base Salary must be non-negative");
                }
                _baseSalary = value;
            }
        }

        public BasePlusCommisionEmployee() { }

        public BasePlusCommisionEmployee(Decimal baseSalary):
            base("fName", "lName", "SSN",0, 0)
        {
            BaseSalary = baseSalary;
        }

        public BasePlusCommisionEmployee(String fName, String lName, String ssn, Decimal commisionRate, Decimal grossSales, Decimal baseSalary):
            base(fName,lName, ssn, commisionRate, grossSales)
        {
            BaseSalary = baseSalary;
        }

        public decimal Earning()
        {
            return BaseSalary + base.Earning();
        }

        public void PrintInfo()
        {
            System.Console.WriteLine("*********************Base + Commssion Employee Information: ");
            PrintCommonInfo();
            System.Console.WriteLine("Base Salary: " + BaseSalary);
            System.Console.WriteLine("Earning: " + Earning());

        }
    }
}
