using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModeling
{
    public class Instructor
    {
        // fields + operations
        public string _firstName;
        public string _lastName;
        public string _wNumber;
        public string _department;

        public Instructor() {}

        public Instructor(string fname, string lname, string wnumber, string dept) {
            _firstName = fname;
            _lastName = lname;
            _wNumber = wnumber;
            _department = dept;
        }

        public void OffersACourse(ClassCatalog catalog, WeberClass weberClass) {
            weberClass._instructor = this;
            weberClass._department = _department;
            catalog._weberClasses[catalog._currentClassesCount] = weberClass;
            catalog._currentClassesCount++;

        }

        public void OffersACourse(ClassCatalog catalog, string classID, string className, string classNum, int classCapacity) {
            WeberClass weberClass = new WeberClass(classID, className, classNum, this, _department, classCapacity);
            catalog._weberClasses[catalog._currentClassesCount] = weberClass;
            catalog._currentClassesCount++;

        } 

        public void PrintInstructor() {
            System.Console.WriteLine("************************* Printing Instructor Info **********************");
            System.Console.WriteLine("Instructor Name: " + _firstName + " " + _lastName);
            System.Console.WriteLine("Instructor WNumber: " + _wNumber);
            System.Console.WriteLine("Instructor Department: " + _department);
            
        }



    }
}
