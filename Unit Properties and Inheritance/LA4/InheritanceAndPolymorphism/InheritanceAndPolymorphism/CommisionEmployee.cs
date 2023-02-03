using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class CommisionEmployee : Employee
    {

        private decimal _grossSales; //>=0
        private decimal _commisionRates; // [0,1]

        public decimal CommisionRate
        {
            get { return _commisionRates; }
            set
            {
                if(value > 1.0m || value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("Commision Rate", "Commision Rate can only be from 0.0 to 1.0");

                }
                _commisionRates = value;
            }
        }

        public decimal GrossSales
        {
            get { return _grossSales; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Gross sale", "Gross sales must be non-negative");
                }
                _grossSales = value;
            }
                
        }

        public CommisionEmployee(){}
        
        public CommisionEmployee(string firstName, string lastName, string ssn, decimal grossSales, decimal commisionRates):
            base(firstName, lastName, ssn)
        {
            CommisionRate = commisionRates;
            GrossSales = grossSales;
        }

        public decimal Earning()
        {
            return CommisionRate * GrossSales;
        }

        public void PrintInfo()
        {
            System.Console.WriteLine("*********************Commision Employee Information: ");
            PrintCommonInfo();
            System.Console.WriteLine("Earning: " + Earning());

        }

        protected void PrintCommonInfo()
        {
            System.Console.WriteLine("Name: " + FirstName + " " + LastName);
            System.Console.WriteLine("SSN " + SSN);
            System.Console.WriteLine("Gross Sales: " + GrossSales);
            System.Console.WriteLine("Commision Rate: " + CommisionRate);
        }
    }
}
