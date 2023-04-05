using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    public enum BookType
    {
        NONE = -1,
        SCIENCE = 0,
        ARTS = 1,
        MATHS = 2,
        HISTORY = 3,
        EDUCATION = 4,

    };
    /**
     * Book class inherited from Library Item class
     * Id for book has form of "bk00000"
     * 
     */
    public class Book : LibraryItem
    {
        protected int _isbn;
        protected String _author;
        protected BookType _type;
        public int ISBN{ get { return _isbn; } set { _isbn = value; }}
        public String Author { get { return _author; } set { _author = value;} }
        public BookType Type { get { return _type; } set { _type = value; }}

        public Book() {
            Id = "bk00000";
            CheckOutDate= DateTime.Now;
            ReturnDate= DateTime.Now;
            Location = LocationInLibrary.NONE;
            IsOnSHelf= false;
            IsCheckedOut= false;
        }
        public Book(String id, String title, int isbn, String author, LocationInLibrary loc, BookType type) {
            if (id.Substring(0, 2).ToLower().CompareTo("bk") != 0)
            {
                throw new ArgumentException("Id", "Book id starts with bk");
            }
            Id = id;
            Title = title;
            Author = author;
            Location = loc;
            Type = type;
            ISBN = isbn;
            TimeLimit = 30;
            IsCheckedOut= false;
            IsOnSHelf = true;
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;


        }
        /**
         * Constructor for Clone
         */
        private Book(Book b)
        {
            int id = int.Parse(b.Id.Substring(2)) + 1;
            String newId = "bk"+ id.ToString();


            Id = newId;
            Title = b.Title;
            Author = b.Author;
            Location = b.Location;
            Type = b.Type;
            TimeLimit = 30;
            IsCheckedOut = false;
            IsOnSHelf = true;
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;

        }
        /**
         * ChargeFee checks if book returned later than 1 month(30 days)
         * Should be called after calling Return()
         * Params: none
         * Return: $1 if late, 0 if not
         */
        public override decimal ChargeFee()
        {
            /*
            if (!IsCheckedOut)
            {
                int days = ReturnDate.Subtract(CheckOutDate).Days;
                if(days > TimeLimit)
                {
                    return 1.0m;
                }
            }*/
            return 0.0m;
        }

        /**
         *  Check out book from library
         *  Params: none
         *  Return: 0 if checkout successfully, -1 if not
         */
        public override int CheckOut()
        {

            if (!IsCheckedOut)
            {
                IsCheckedOut= true;
                CheckOutDate= DateTime.Now;
                return 0;
            }
            return -1;
        }

        /**
         * Return the book to Library
         * Params: Object b
         * return: 0 if return successfully  -1 if not
         */
        public override decimal Return(Object b)
        {
            if(this.CompareTo(b) == 0)
            {
                if(IsCheckedOut) { 
                    ReturnDate = DateTime.Now;
                    IsCheckedOut = false;                    
                    return 0;
                }
            }
            return -1;
        }

        public override void Update()
        {
            base.Update();
        }
        /**
         * Clone a book, new copy of the book.
         * Auto generate id, same content.
         * Check for possible duplicate id from Class Librarian when add book.
         */
        public override LibraryItem Clone()
        {
            Book newBook = new Book(this);
            return newBook;
        }

        /**
         * Compare two Book
         * Params: Object
         * return: 0 if two book have the same Id, -1 if not
         */
        public override int CompareTo(object obj)
        {
            if(obj is LibraryItem)
            {
                return Id.CompareTo(((LibraryItem)obj).Id);
            }
            return -1;
        }

        public override void PrintBookInfo()
        {
            System.Console.WriteLine("********** Book Information **********");
            System.Console.WriteLine("Id:       " + Id);
            System.Console.WriteLine("Title:    " + Title);
            System.Console.WriteLine("Author:   " + Author);
            System.Console.WriteLine("Type:     " + Type);
            System.Console.WriteLine("Location: " + Location);

            System.Console.WriteLine("");

        }
    }
}
