using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class CommisionEmployee : Object
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        protected string SSN { get; }

        private decimal _grossSales; // should be positive.
        private decimal _commisionRate; // positive and between 0.0 to 1.0.

        public decimal GrossSales {
            get { return _grossSales; }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("GrossSales", "Gross sales can only be positive.");
                }
                _grossSales = value;
            }
        }

        public decimal CommisionRate {
            get { return _commisionRate; }
            set {
                if (value < 0.0m || value > 1.0m) {
                    throw new ArgumentOutOfRangeException("CommisonRate", "Commision Rate should be between 0.0 and 1.0");
                }
                _commisionRate = value;

            }
        }

        public CommisionEmployee() { }

        public CommisionEmployee(string fname, string lname, string ssn, decimal sales, decimal commision) {
            FirstName = fname;
            LastName = lname;
            SSN = ssn;
            GrossSales = sales;
            CommisionRate = commision;
        
        }

        public void PrintInfo() {
            System.Console.WriteLine("*********************Commision Employee Information: ");
            PrintCommonInfo();
            System.Console.WriteLine("Earning: " + Earning());

        }

        protected void PrintCommonInfo() {
            System.Console.WriteLine("Name: " + FirstName + " " + LastName);
            System.Console.WriteLine("SSN " + SSN);
            System.Console.WriteLine("Gross Sales: " + GrossSales);
            System.Console.WriteLine("Commision Rate: " + CommisionRate);
        }

        public decimal Earning() {
            return GrossSales * CommisionRate;
        }

    }
}
