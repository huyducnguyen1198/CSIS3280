using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preperties
{
    // Access Modifiers: private, public
    // Properties in C#;
    public class Employee
    {

        private string _firstName;
        private string _lastName;
        private string _ssn;
        public decimal _salary;
        private decimal _tax;



        public Employee() { }

        public Employee(string firstname, string lastname, string ssn) {
            _firstName = firstname;
            _lastName = lastname;
            SSN = ssn;
            Address = string.Empty;
        }

        public Employee(string firstname, string lastname, string ssn, decimal salary) {
            _firstName = firstname;
            _lastName = lastname;
            SSN = ssn;
            Salary = salary;
            Address = string.Empty;
        }

        // this is an example of constructor chaining
        public Employee(string firstname, string lastname, string ssn, decimal salary, string address)
            : this(firstname, lastname, ssn, salary)
        {
            Address = address;
        }

        public string FirstName {
            get {
                return _firstName;
            }
            set {
                _firstName = value;
            }
        }

        public string LastName {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                // data integrity, to ensure that variables don't hold inappropriate values based on business rules. 
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("Salary", "Salary cannot be negative.");
                }
                _salary = value;
            }
        }

        public string SSN {
            get {
                if (string.IsNullOrEmpty(_ssn)) {
                    throw new ArgumentOutOfRangeException("SSN", "SSN cannot be null or empty");
                }
                return _ssn;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentOutOfRangeException("SSN", "SSN cannot be null or empty");
                }
                _ssn = value;
            }

        }

        // auto property or auto implemented property.
        public string Address { get; set; }

        // read only property, get only property

        public string FullName {
            get { return _firstName + " " + _lastName; }
            // set is not implemented.
        }

        // read only property where we apply some data integrity rules or validity checks
        public decimal Tax {
            get { return _tax < 0 ? 0 :  _tax; }

        }

       







        public void PrintEmployeeInfo() {
            System.Console.WriteLine("************** Employee information: ");
            System.Console.WriteLine("Full Name: " + FullName);
            System.Console.WriteLine("SSN: " + SSN);
            System.Console.WriteLine("Salary: " + Salary);
            System.Console.WriteLine("Tax: " + Tax);
            System.Console.WriteLine("Address: " + Address);

        }

        public void ComputeTax(decimal taxRate) {  // taxrate is between 0 to 1
            _tax = Salary * taxRate;
        
        }


    }
}
