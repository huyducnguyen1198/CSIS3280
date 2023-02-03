using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModeling
{
    public class WeberClass
    {
        //fields, operations. all fields are public. 

        public string _classID;
        public string _className;
        public string _classNumber;
        public Instructor _instructor;
        public string _department;
        public int _maxCapacity;
        public int _currentEnrollment;

        //TODO: Add an array of students here. Array of Student class. 
        public Student [] _studentArray; 
        // Constructors

        //default constructor
        public WeberClass() { }

        // constructor with parameters.
        public WeberClass(string classId, string className, string classNumber, Instructor instructor, string dept, int maxCapacity) 
        {
            _classID = classId;
            _className = className;
            _classNumber = classNumber;
            _department = dept;
            _maxCapacity = maxCapacity;
            _instructor = instructor;
            _currentEnrollment = 0;
            //TODO: initialize the student array with maximum class capacity.
            // use this as hint: _weberClasses = new WeberClass[MAX_UNIVERSITY_CLASS_CAPATIY];
            // here we are initializing total weber classes  based on university capacity
            // similarly, initialize student array with class capacity and not university capacity.
            _studentArray= new Student[maxCapacity];

        }

        // operations

        public void PrintClassInfo() {

            System.Console.WriteLine("**************** Weber Class Info: ***********************");
            System.Console.WriteLine("Class ID: " + _classID);
            System.Console.WriteLine("Class Name: " + _className);
            System.Console.WriteLine("Class Number: " + _classNumber);
            System.Console.WriteLine("Class Instructor: " + _instructor._firstName + " " + _instructor._lastName);
            System.Console.WriteLine("Class Department: " + _department);
            System.Console.WriteLine("Class Max Capacity: " + _maxCapacity);
            System.Console.WriteLine("Class Current Enrollment: " + _currentEnrollment);

        }

        public bool IsMaxCapacityReached() {
            return _currentEnrollment >= _maxCapacity;
        }
        /*
         * register student in class
         * return 0 if succesfully register,
         * 1 if class is full
         */
        public int register(Student student)
        {
            if (!IsMaxCapacityReached())
            {
                _studentArray[_currentEnrollment] = student;
                _currentEnrollment++;
            }
            else
            {
                return 1;
            }
            return 0;
        }
        public void PrintListOfStudentsForClass() { 
            for(int i = 0; i< _currentEnrollment; i++)
            {
                System.Console.WriteLine(_studentArray[i]._firstName + " " + _studentArray[i]._lastName);
            }
            // TODO: Use the array of students to print students who registered for a particular class.
        }


    }
}
