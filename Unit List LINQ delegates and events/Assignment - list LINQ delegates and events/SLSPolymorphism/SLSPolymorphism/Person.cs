using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    public class Person 

    {
        protected List<LibraryItem> _list;
        public List<LibraryItem> ItemList
        {
            get { return _list; }
        }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }

        protected String _ssn;
        
        protected String _wNumber;

        public String SSN
        {
            get
            {
                return _ssn;
            }
            set
            {
                _ssn = value;
            }
        }

        public String WNumber
        {
            get { return _wNumber; }
            set { _wNumber = value; }
        }
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public Person() {
            this.FirstName = String.Empty;
            this.LastName = String.Empty;
            this.Address = String.Empty;
            this.SSN = String.Empty;
            this.WNumber = String.Empty;
        }

        public Person(string fName, String lName, String address)
        {
            FirstName = fName;
            LastName = lName;
            Address = address;
        }
        public Person(string firstName, string lastName, string address, string ssn, string wNumber)
            :this(firstName, lastName, address) { 
            _ssn = ssn;
            WNumber = wNumber;
        }

        //to be overriden
        public virtual void PrintBookInfo(){}
        public virtual int checkOutBook(LibraryItem item) { return -1; }
        public virtual int returnBook(LibraryItem item) { return -1; }
        public virtual DateTime GetSupposedReturnDate(LibraryItem item) { return DateTime.Today; }
        public void UserInfo()
        {
            System.Console.WriteLine("******** Person info ********");
            System.Console.WriteLine("School ID:    " + WNumber);
            System.Console.WriteLine("Full Name:    " + FullName);
            System.Console.WriteLine("SSN:          " + SSN);
            System.Console.WriteLine("Address:      " + Address);
        }
        public override String ToString()
        {
            return "WNumber: " + WNumber +"\nFull Name: " + FullName ;
        }
        public override bool Equals(object obj)
        {
            if((obj == null) && !(this.GetType().Equals(obj.GetType()))){
                return false;
            }
            Person p = (Person)obj;
            return String.Compare(p.WNumber, this.WNumber) == 0 ? true : false;
        }
    }
}
