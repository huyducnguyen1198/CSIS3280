using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    public class Librarian
    {
        public String firstName;
        public String lastName;
        public String address;
        public int ssn;
        public int employeeId;


        private List<LibraryItem> LibraryCatalog = new List<LibraryItem>();
        public int numberOfBook = 0;

        public Librarian() {
            this.firstName = "";
            this.lastName = "";
            this.address = "";
            this.ssn = 0;
            this.employeeId = 0;

        }

        public Librarian(string firstName, string lastName, string address, int sSN, int employeeId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.ssn = sSN;
            this.employeeId = employeeId;
        }

        public void addItem(LibraryItem  item)
        {
            LibraryItem newItem = item;
            while (LibraryCatalog.Exists(x => (x.Id.CompareTo(newItem.Id) == 0))){
                newItem = newItem.Clone();
            }
            this.LibraryCatalog.Add(newItem); 
            newItem.IsOnSHelf= true;
            numberOfBook ++;
        }

        public void removeItem(LibraryItem item)
        {
            if(!LibraryCatalog.Exists(x => x.CompareTo(item) == 0))
            {
                System.Console.WriteLine("Item " + item.Title + " is not in the catalog.");
                return;
            }
            numberOfBook --;
            this.LibraryCatalog.Remove(item);
        }

        public List<LibraryItem> getBookCatalog()
        {
            return this.LibraryCatalog;
        }

        public void PrintLibraryCatalog()
        {
            for(int i = 0; i< this.numberOfBook; i++)
            {
                this.LibraryCatalog[i].PrintBookInfo();
            }
        }
        public void PrintBookList()
        {
            foreach(LibraryItem item in LibraryCatalog)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
        
        public void TakeItemOffShelf(LibraryItem item)
        {
            if (item.IsCheckedOut)
            {
                System.Console.WriteLine("Item is currently checked out.");
                return;
            }
            foreach(LibraryItem i in this.LibraryCatalog){
                if (i.CompareTo(item) == 0)
                {
                    i.IsOnSHelf = false;
                    LibraryCatalog.Remove(i);
                    return;
                }
            }
        }
        public void TakeItemOffShelf(String id)
        {
            foreach (LibraryItem i in this.LibraryCatalog)
            {
                if (i.Id.CompareTo(id) == 0)
                {
                    i.IsOnSHelf = false;
                    LibraryCatalog.Remove(i);
                    return;
                }
            }
        }

        /**
         * Search a item by its id
         * Params: String is
         * Return: LibraryItem objeect, null if not found
         * 
         */
        public LibraryItem searchBookById(String id){
            foreach(LibraryItem i in this.LibraryCatalog)
            {
                if(i.Id.CompareTo(id) == 0)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
