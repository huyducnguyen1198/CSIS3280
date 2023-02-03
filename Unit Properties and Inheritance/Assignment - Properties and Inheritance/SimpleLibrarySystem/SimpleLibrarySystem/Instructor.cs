using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class Instructor : Person
    {


        protected Book[] _bookList;
        protected int _limit;
        protected int _numberBookCheckedOut;
        protected int _timeLimit;
        public Book[] BookList
        {
            get { return _bookList; }
        }

        public int Limit
        {
            get { return _limit; }
            set { _limit = value; }
        }
        public int NumberBookCheckedOut
        {
            get { return _numberBookCheckedOut; }
        }
        public int TimeLimit
        {
            get { return _timeLimit; }
            set { _timeLimit = value; }
        }
        public Instructor() : base()
        {
            WNumber = "E000000000";
            initializeBook();
        }

        public void initializeBook()
        {
            this._limit = 5;
            this._numberBookCheckedOut = 0;
            this._bookList = new Book[this._limit];
            this._timeLimit = 2 * 30; //30 days as in 1 month
            for (int i = 0; i < this._bookList.Length; i++)
            {

                this._bookList[i] = null;
            }
        }
        public Instructor(string firstName, string lastName, string wNumber, string address, String ssn) :
            base(firstName, lastName, address, ssn, wNumber)
        {
            if (Char.ToLower(wNumber[0]) == 'e')
            {
                WNumber = wNumber;
            }
            else
            {
                throw new ArgumentOutOfRangeException("W number", "Instructor number start with E");
            }

            initializeBook();
        }

        public override void PrintBookInfo()
        {
            System.Console.WriteLine(FirstName + "'s book list: (" + this._numberBookCheckedOut + ")");
            for (int i = 0; i < this._limit; i++)
            {
                if (this._bookList[i] != null)
                    System.Console.WriteLine("      " + this._bookList[i].title + ", " + this._bookList[i].isbn);

            }
            System.Console.WriteLine();
        }

        public void checkOutBook(Book book)
        {
            if (this._numberBookCheckedOut < this._limit)
            {
                if (!book.isBookCheckedOut)
                {
                    //add book to student book list
                    for (int i = 0; i < this._limit; i++)
                    {
                        if (this._bookList[i] == null)
                        {
                            book.checkOutBook();
                            _bookList[i] = book;
                            this._numberBookCheckedOut++;
                            return;
                        }
                    }

                }
                else
                {
                    System.Console.WriteLine("Book " + book.title + " is currently checked out." +
                                        " Please choose other books or come back later. Thank you!");
                    System.Console.WriteLine();
                }
            }
            else
            {
                System.Console.WriteLine("Instructor " + FirstName + " has reached limit number of book, " +
                                        " Please return other books before borrow new books. Thank you!");
            }
        }

        public void returnBook(Book book)
        {
            if (book.isBookCheckedOut)
            {
                //remove book from student book list
                for (int i = 0; i < this._limit; i++)
                {
                    if (book.isbn == this._bookList[i].isbn)
                    {
                        book.returnBook();
                        this._numberBookCheckedOut--;
                        this._bookList[i] = null;

                        //check date limit
                        if (book.GetBorrowDays() > TimeLimit)
                        {
                            System.Console.WriteLine("Instructor " + FirstName + " is late to return book.");
                        }
                        return;
                    }
                }
                System.Console.WriteLine("Instructor " + FirstName + " does not borrow this book.");

            }
        }
    }
}
