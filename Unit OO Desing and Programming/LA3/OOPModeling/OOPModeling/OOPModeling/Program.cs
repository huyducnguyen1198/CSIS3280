using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModeling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             We will have one instructor
             that instructor will offer 2 courses
             So, catalog will have two course. 
             we will  have two student.
             First student will register for both the courses in catalog.
             Second student will registesr for only one course in the catalog. 
             */


            Instructor instructor1 = new Instructor("Arpit", "Chrisit", "W123456", "CS");
            //instructor1.PrintInstructor();

            ClassCatalog classCatalog = new ClassCatalog();

            WeberClass weberClassFinance = new WeberClass("12345", "Finance 101", "FIN101", null, "Finacnce", 2);
            instructor1.OffersACourse(classCatalog, weberClassFinance);
            //weberClassFinance.PrintClassInfo();
            instructor1.OffersACourse(classCatalog, "98765", "Windows OOP", "CS3280", 24);

            //weberClassFinance and catalog._weberClasse[0]

            // students are created here. 

            Student student1 = new Student("W99999", "Aric", "Doe");
            Student student2 = new Student("W88888", "Jane", "Lee");
            Student student3 = new Student("W77777", "Huy", "Nguyen");

            Student[] studentArray = new Student[3];
            studentArray[0] = student1;
            studentArray[1] = student2;
            studentArray[2] = student3;

            // student 1 registers for both the classes

            student1.RegistersForAClass(classCatalog._weberClasses[0]);
            student1.RegistersForAClass(classCatalog._weberClasses[1]);
            
            // studnet 2 registers for finance class
            student2.RegistersForAClass(classCatalog._weberClasses[0]);

            // student 3 register for Window Opp, which is already full.
            // should return not registered

            student3.RegistersForAClass(classCatalog._weberClasses[0]);

            // studnet 1 current enrollement is 2
            // student 2 current enrollment is 1
            // student 3 current enrollment is 0
            // finance has 2 students. and full
            // Windows OOP has only 1 student. 
            
            classCatalog.PrintCatalog();

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            student1.PrintStudnetInfo();
            student2.PrintStudnetInfo();
            student3.PrintStudnetInfo();

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();


            //Print 
            System.Console.WriteLine("***** print a list of class for each student *****");
            for(int i = 0; i < studentArray.Length; i++)
            {
                System.Console.WriteLine(studentArray[i].getStudentName());
                studentArray[i].PrintClassesInformationForStudent();
                System.Console.WriteLine();

            }




            System.Console.WriteLine("***** print student list from each class *****");
            for(int i = 0; i < classCatalog._currentClassesCount; i++)
            {
                System.Console.WriteLine(classCatalog._weberClasses[i]._className + ": ");
                classCatalog._weberClasses[i].PrintListOfStudentsForClass();
                System.Console.WriteLine();
            }

            System.Console.ReadLine();


           
        }
    }
}
