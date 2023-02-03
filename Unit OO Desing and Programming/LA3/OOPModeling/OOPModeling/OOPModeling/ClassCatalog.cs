using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModeling
{
    public class ClassCatalog
    {
        public WeberClass[] _weberClasses;
        public int _currentClassesCount;
        public int MAX_UNIVERSITY_CLASS_CAPATIY = 100;

        public ClassCatalog() 
        {
            _weberClasses = new WeberClass[MAX_UNIVERSITY_CLASS_CAPATIY];
            _currentClassesCount = 0;
        }

        public ClassCatalog(int universityCapacity) {
            _weberClasses = new WeberClass[universityCapacity];
            _currentClassesCount = 0;
        }

        public void PrintCatalog() {

            System.Console.WriteLine("****************** Printing the Course Catalog ********************");
            for (int i = 0; i < _weberClasses.Length; i++) {
                WeberClass weberClass = _weberClasses[i];
                if (weberClass != null) {
                    weberClass.PrintClassInfo();
                
                }

            
            }
        }

         
    }
}
