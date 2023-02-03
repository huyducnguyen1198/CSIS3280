using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class OutsideEntity
    {
        public void ViewEmployee(Employee employee)
        {
            System.Console.WriteLine("************** Employee information viewed by an outside entity");
            System.Console.WriteLine("Full Name: " + employee.FirstName + " " + employee.LastName);
        }
    }
}
