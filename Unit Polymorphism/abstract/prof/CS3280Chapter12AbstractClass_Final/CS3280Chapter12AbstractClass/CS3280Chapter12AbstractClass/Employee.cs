using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280Chapter12AbstractClass
{
    public abstract class Employee :Object
    {
        // TODO: Question 3: What is the logical intention in keeping FirstName, LastName and SSN as get only property?
        // Where are we going to set them?
        // If an employee first-name changes one year after the employee is created into the system,
        // what is the way to change the name of the employee?
        public string FirstName { get; }
        public string LastName { get; }
        public string SSN { get; }

        public Employee() { }
        public Employee(string fname, string lname, string ssn) {
            FirstName = fname;
            LastName = lname;
            SSN = ssn;
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + "\n" + "SSN: " + SSN + "\n";
        }

        public abstract decimal Earning();


    }
}
