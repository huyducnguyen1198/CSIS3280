using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class Student
    {
        public String firstName;
        public String lastName;
        public String wNumber;
        public String address;
        public int ssn;

        public Book[] bookList;
        public int limit;
        public int numberBookCheckedOut;

        public Student()
        {
            this.firstName = "";
            this.lastName = "";
            this.wNumber = "W";
            this.ssn = 0;
            this.address = "";

            this.limit = 3;
            this.numberBookCheckedOut = 0;

            initializeBook();
        }

        public void initializeBook()
        {
            this.bookList = new Book[this.limit];

            for (int i = 0; i< this.bookList.Length; i++)
            {

                this.bookList[i] = null;
            }
        }
        public Student(string firstName, string lastName, string wNumber, string address, int ssn)
        {
            
            this.firstName = firstName;
            this.lastName = lastName;
            this.wNumber = wNumber;
            this.address = address;
            this.ssn = ssn;
            this.limit = 3;
            this.numberBookCheckedOut = 0;
            initializeBook();
        }

        public void printBookList()
        {
            System.Console.WriteLine(this.firstName + "'s book list: ("+ this.numberBookCheckedOut+")");
            for(int i = 0; i< this.limit; i++)
            {
                if (this.bookList[i] != null)
                    System.Console.WriteLine("      "+this.bookList[i].title+ ", "+this.bookList[i].isbn);

            }
            System.Console.WriteLine();
        }

        public void checkOutBook(Book book)
        {
            if (this.numberBookCheckedOut < this.limit)
            {
                if (!book.isBookCheckedOut)
                {
                    for(int i = 0; i<this.limit; i++)
                    {
                        if (this.bookList[i] == null)
                        {
                            book.checkOutBook();
                            bookList[i] = book;
                            this.numberBookCheckedOut++;
                            return;
                        }
                    }
                    
                }
                else
                {
                    System.Console.WriteLine("Book " +book.title +" is currently checked out." +
                                        " Please choose other books or come back later. Thank you!");
                    System.Console.WriteLine();
                }
            }
            else
            {
                System.Console.WriteLine("Student "+ this.firstName +" has reached limit number of book, " +
                                        " Please return other books before borrow new books. Thank you!");
            }
        }

        public void returnBook(Book book) { 
            if(book.isBookCheckedOut)
            {
                for(int i = 0; i< this.limit; i++)
                {
                    if (book.isbn == this.bookList[i].isbn)
                    {
                        book.returnBook();
                        this.numberBookCheckedOut--;
                        this.bookList[i] = null;
                        return;
                    }
                }
                System.Console.WriteLine("Student " +this.firstName+" does not borrow this book.");

            }
        }
    }
}
