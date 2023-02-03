using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public enum BookType{
                        NONE = -1,       
                         SCIENCE    = 0, 
                         ARTS       = 1,
                         MATHS      = 2,
                         HISTORY    = 3,
                         EDUCATION  = 4,
                         
                        };

    public enum LocationInLibrary {
        NONE = -1,
        FIRSTFLOOR = 0,
                          SECONDFLOOR = 1,
                          THIRDFLOOR = 2,
                        }
    public class Book
    {

        public int bookId;
        public int isbn;
        public string title;
        public string author;
        public BookType type;
        public LocationInLibrary location;
        public bool isBookCheckedOut;

        public Book()
        {
            bookId = 0;
            isbn = 0;
            title = "";
            author= string.Empty;
            this.type= BookType.NONE;
            location = LocationInLibrary.NONE;
            isBookCheckedOut = false;
        }

        public Book(int isbn, String title, String author)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }

        public BookType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public LocationInLibrary Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public void checkOutBook()
        {
            this.isBookCheckedOut = true;
        }

        public void returnBook()
        {
            this.isBookCheckedOut = false;
        }

        public void printBookInfo()
        {
            System.Console.WriteLine("***** boook infomation *****");
            System.Console.WriteLine("Name:     " + this.title);
            System.Console.WriteLine("Author:   " + this.author);
            System.Console.WriteLine("ISBN:     " + this.isbn);
            System.Console.WriteLine("Tyep:     " + Enum.GetName(typeof(BookType), this.type));
            System.Console.WriteLine("Borrowed: " + (this.isBookCheckedOut ? "Yes" : "NO"));
            System.Console.WriteLine();
        }

       

    }
}
