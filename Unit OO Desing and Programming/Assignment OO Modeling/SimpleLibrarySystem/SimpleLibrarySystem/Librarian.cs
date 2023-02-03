using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class Librarian
    {
        public String firstName;
        public String lastName;
        public String address;
        public int ssn;
        public int employeeId;


        public Book[] bookCatalog = new Book[100];
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

        public void addBook(Book book)
        {
            this.bookCatalog[numberOfBook] = book; 
            numberOfBook ++;
        }

        public void removeBook(Book book)
        {

            numberOfBook --;
            this.bookCatalog[numberOfBook] = null;
        }

        public Book[] getBookCatalog()
        {
            return this.bookCatalog;
        }

        public void printBookCatalog()
        {
            for(int i = 0; i< this.numberOfBook; i++)
            {
                this.bookCatalog[i].printBookInfo();
            }
        }
        public Book getBookByIsbn(int isbn)
        {
            for(int i = 0; i < this.numberOfBook; i++)
            {
                Book book = this.bookCatalog[i];
                if(book.isbn == isbn) return book;
            }
            return null;
        }
        /*
        public String FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        
        public String LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }

        }

        public String Address
        {
            get { return this.address; }
            set{
                this.address = value;
            }
        }

        public int Ssn
        {
            get { return this.ssn; }
            set
            {
                this.ssn = value;
            }
        }

        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                this.employeeId = value;
            }
        */
    }
}
