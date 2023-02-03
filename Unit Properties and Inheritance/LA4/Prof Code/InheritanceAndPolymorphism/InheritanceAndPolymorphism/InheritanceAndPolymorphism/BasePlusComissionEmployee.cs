using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class BasePlusComissionEmployee : CommisionEmployee
    {
        private decimal _baseSalary;

        public decimal BaseSalary {
            get { return _baseSalary; }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("BaseSalary", "Base Salary can only be positive.");
                }
                _baseSalary = value;
            }
            
        }


        public BasePlusComissionEmployee() { 
        
        }

        public BasePlusComissionEmployee(string fname, string lname, string ssn, decimal sales, decimal commision, decimal basesalary) 
            : base(fname,lname,ssn,sales,commision)  {
            
           BaseSalary = basesalary;

        }

        public BasePlusComissionEmployee(decimal baseSalary) : base("DummyFname","DummyLname", "", 0, 0) {
            BaseSalary = baseSalary;
            
        
        }

        public decimal Earning() {
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
