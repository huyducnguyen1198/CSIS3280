using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModeling
{
    public class Student
    {
        public string _studentId;
        public string _firstName;
        public string _lastName;
        public int _noOfClassesCurrentlyEnrolled;
        public int MAX_CLASSES_STUDNET_IS_ALLOWED = 4;

        public WeberClass[] _weberClasses;

        public Student() {
            _noOfClassesCurrentlyEnrolled = 0;
            _weberClasses = new WeberClass[MAX_CLASSES_STUDNET_IS_ALLOWED];

        }

        public Student(string studentid, string fname, string lname) {
            _firstName = fname;
            _lastName = lname;
            _studentId = studentid;
            _noOfClassesCurrentlyEnrolled = 0;
            _weberClasses = new WeberClass[MAX_CLASSES_STUDNET_IS_ALLOWED];

        }

        public void RegistersForAClass(WeberClass weberClass) {
            if (IsMaxStudnetClassLimitReached())
            {
                System.Console.WriteLine("***** Studnet is registered for maximum courses. Try next semester");
            }
            else {

                // TODO: Implement preventing students from registering if the class is full.

                //TODO: Implement to make sure that student gets added to the class
                //TODO: To implement this, use the student array that you created
                int isRegister = weberClass.register(this);
                if (isRegister == 0)
                {
                    // the student still cannot register if class if full.
                    _weberClasses[_noOfClassesCurrentlyEnrolled] = weberClass;
                    _noOfClassesCurrentlyEnrolled++;
                    System.Console.WriteLine("***** " + weberClass._className + " is registered successfully *****");

                }
                else
                {
                    System.Console.WriteLine("***** " + weberClass._className + " is not registered *****");
                }
            }
            
        }

        public bool IsMaxStudnetClassLimitReached() {
            return _noOfClassesCurrentlyEnrolled >= 4;
                

        }

        public String getStudentName()
        {
            return _firstName +  _lastName;
        }
        public void PrintStudnetInfo() {
            System.Console.WriteLine("******************* Studnent Information ************************");
            System.Console.WriteLine("Studnet ID: " + _studentId);
            System.Console.WriteLine("Studnet Name: " + _firstName + " " + _lastName);
            System.Console.WriteLine("Studnet Current Enrollment Count: " + _noOfClassesCurrentlyEnrolled);
            
        }

        public void PrintClassesInformationForStudent() {
            System.Console.WriteLine("************Classes for Student: ");
            for (int i = 0; i < _weberClasses.Length; i++) {

                if (_weberClasses[i] != null) {
                    _weberClasses[i].PrintClassInfo();
                }
            }
            
        }
    }
}
