using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Employee
    {
        private String _firstName;
        private String _lastName;
        private String _ssn;
        public decimal _salary;
        private decimal _tax;
        //private String _address;

        public Employee() {
            this._firstName = String.Empty;
            this._lastName = String.Empty;
            this._tax = 0;
            this._salary = 0;
            this._ssn = String.Empty;
            this.Address = String.Empty;
        }

        public Employee(String firstName, String lastName, String ssn)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._ssn = ssn;
            this.Address = String.Empty;
        }

        public Employee(String firstName, String lastName, String ssn, decimal salary)
            : this(firstName, lastName, ssn)
        {
            this._salary = salary;
        }

        public Employee(String firstName, String lastName,  String ssn, decimal salary, String address)
            :this(firstName, lastName, ssn, salary)
        { 
            this.Address = address;
        }


        public String FirstName {
            get { return this._firstName; }
            set { 
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("First Name", "First name cannot be null or empty.");
                }

                this._firstName = value; }
    
        }

        public String LastName
        {
            get { return this._lastName; }

            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Last Name", "Last name cannot be null or emnpty.");
                }
                this._lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this._salary; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary", "Salary cannot be negative");
                }
                this._salary = value;
            }
        }

        public String SSN
        {
            get {
                if (String.IsNullOrEmpty(this._ssn))
                {
                    throw new ArgumentOutOfRangeException("SSN", "SSN cannot be null or empty.");
                }
                return this._ssn; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("SSN", "SSN cannot be null or empty.");
                }
                this._ssn = value;
            }
        }

        //auto properties
        public String Address
        {
            set;
            get;
        }

        //read only properties;

        public String FullName
        {
            get
            {
                return this._firstName + " " + this._lastName;
            }
            //set not implemented
        }

        // read only property where we apply some data integrity rules or validity checks

        public decimal Tax
        {
            get { return this._tax < 0 ? 0 : this._tax; }
        }


        public void PrintEmployeeInfo()
        {
            System.Console.WriteLine("************** Employee information: ");
            System.Console.WriteLine("Full Name: " + FullName);
            System.Console.WriteLine("SSN: " + SSN);
            System.Console.WriteLine("Salary: " + Salary);
            System.Console.WriteLine("Tax: " + Tax);
            System.Console.WriteLine("Address: " + Address);

        }

        public void computeTax(decimal taxRate)
        {
            this._tax =  taxRate * this.Salary;
        }
    }
}
