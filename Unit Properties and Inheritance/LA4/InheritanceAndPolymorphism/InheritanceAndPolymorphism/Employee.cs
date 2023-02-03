using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Employee : Object
    {
        protected String FirstName { get; set; }
        protected String LastName { get; set; }
        protected String SSN { get; }
        protected decimal _salary;

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("Salary", "Salary must be non-negative");
                }
                _salary = value;
            }
        }
        public Employee() { }

        public Employee(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
        }

        public decimal Earning()
        {
            return Salary;
        }
    }
}
