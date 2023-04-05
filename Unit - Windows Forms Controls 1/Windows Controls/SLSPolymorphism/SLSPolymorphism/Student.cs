using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    /**
     * Time limite for an each of a library item 
     * that an Student can borrow by day.
     * one month is 30 days.
     */
    public enum StudentCheckOutTimeLimit
    {
        PAPERBOOK = 30,
        EBOOK = 3*30,
        JOURNAL = 2 * 30,
        MAGAZINE = 7,
        UND =0,
    }
    public class Student : Person
    {
        

        protected List<LibraryItem> _list;
        protected int _limit;
        protected int _numberBookCheckedOut;
        protected int _timeLimit;
        public List<LibraryItem> ItemList
        {
            get { return _list; }
        }

        public int Limit
        {
            get { return _limit; }
            set { _limit = value; }
        }
        public int NumberBookCheckedOut
        {
            get { return _numberBookCheckedOut;}
        }
        public int TimeLimit
        {
            get { return _timeLimit; }
            set { _timeLimit = value; }
        }
        public Student():base()
        {
            WNumber = "W000000000";
            initializeBook();
        }

        public void initializeBook()
        {
            this._limit = 3;
            this._numberBookCheckedOut = 0;
            this._list = new List<LibraryItem>();
            this._timeLimit = 30; //30 days as in 1 month

        }
        public Student(string firstName, string lastName, string wNumber, string address, String ssn):
            base(firstName, lastName,address,ssn, wNumber)
        {
            if (Char.ToLower(wNumber[0]) == 'w')
            {
                WNumber = wNumber;
            }
            else
            {
                throw new ArgumentOutOfRangeException("W number", "Student number start with w");
            }

            initializeBook();
        }

        public override void PrintBookInfo()
        {
            System.Console.WriteLine(FirstName + "'s book list: ("+ this._numberBookCheckedOut +")");
            foreach(LibraryItem item in this._list)
            {
                System.Console.WriteLine(item.ToString());
            }
            System.Console.WriteLine();
        }

        public override int checkOutBook(LibraryItem item)
        {
            if (!item.IsOnSHelf)
            {
                System.Console.WriteLine("Item " + item.Title + " is not in catalog.");
                return -1;
            }
            if (this._numberBookCheckedOut < this._limit)
            {
                if (!item.IsCheckedOut && (NumberBookCheckedOut < Limit))
                {
                    _numberBookCheckedOut++;
                    ItemList.Add(item);
                    item.CheckOut();
                    return 0 ;
                    
                }
                else
                {
                    System.Console.WriteLine("Book " +item.Title +" is currently checked out." +
                                        " Please choose other books or come back later. Thank you!");
                    System.Console.WriteLine();
                }
            }
            else
            {
                System.Console.WriteLine("Student " + FirstName +" has reached limit number of book, " +
                                        " Please return other books before borrow new books. Thank you!");
            }
            return -1;
        }

        private StudentCheckOutTimeLimit GetDayLimit(LibraryItem item)
        {
            if(item is PaperBook)
            {
                return StudentCheckOutTimeLimit.PAPERBOOK;
            }
            if (item is EBook)
            {
                return StudentCheckOutTimeLimit.EBOOK;
            }
            if (item is Magazine)
            {
                return StudentCheckOutTimeLimit.MAGAZINE;
            }
            if (item is Journal)
            {
                return StudentCheckOutTimeLimit.JOURNAL;
            }
            return StudentCheckOutTimeLimit.UND;
        }
        public override int returnBook(LibraryItem item) { 
            if(item.IsCheckedOut)
            {
                //remove book from student book list
                foreach(LibraryItem i in ItemList)
                {
                    if (i.CompareTo(item) == 0)
                    {
                        item.Return(item);
                        this._numberBookCheckedOut--;
                        ItemList.Remove(i);
                        if(item.GetCheckOutTimeInDay() > (int)GetDayLimit(item))
                        {
                            System.Console.WriteLine("Student: " + this.FirstName + " Return item "+item.Title+" late, Fine: $" + item.ChargeFee());
                        }
                        return 0;
                    }
                }
                System.Console.WriteLine("Student " + FirstName +" does not borrow this book.");
                return -1;
            }
            return -1;
        }
    }
}
