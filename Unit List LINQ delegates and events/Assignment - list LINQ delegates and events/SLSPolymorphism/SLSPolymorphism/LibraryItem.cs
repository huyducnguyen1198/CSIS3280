using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    public enum LocationInLibrary
    {
        NONE = -1,
        FIRSTFLOOR = 0,
        SECONDFLOOR = 1,
        THIRDFLOOR = 2,
        ONLINE = 3,
    }
    public abstract class LibraryItem : ICloneable, IComparable, ILateFee
    {

        protected String _id;
        protected  String _title;
        protected LocationInLibrary _location;
        protected bool _isOnShelf;//to be removed
        protected bool _isChechedOut;
        protected int _timeLimit;
        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public String Id { get { return _id; } set { _id = value; } }
        public virtual String Title { get { return _title; } set { _title = value; } }
        public LocationInLibrary Location { get { return _location; } set { _location = value; } }
        public bool IsOnSHelf { get { return _isOnShelf; } set { _isOnShelf = value; } }
        public bool IsCheckedOut { get { return _isChechedOut; } set { _isChechedOut = value; } }
        public int TimeLimit { get { return _timeLimit; } set { _timeLimit = value; } }

        /**
         * Check out an Library Item from library.
         * Params: none
         * Return: 0 if success, -1 otherwise.
         */
        public abstract int CheckOut();
        public abstract decimal Return(Object obj);

        /**
         * this class set checkoutdate some time in the pass
         * used for testing purpose
         */
        public virtual void setCheckOutDate(DateTime d)
        {
            CheckOutDate = d;
        }
        /**
         * Update information of Library Item, can be overriden by inherited class.
         * Params: none
         * Return: none
         */

        public virtual void Update()
        {

        }

        public virtual void PrintBookInfo()
        {
            System.Console.WriteLine("********** Book Information **********");
            System.Console.WriteLine("Id:       " + Id);
            System.Console.WriteLine("Location: " + Location);

            System.Console.WriteLine("");

        }        /**
         * Take an item off the shelf
         * Params: none
         * return: 0 if item is on shelf(successfully taken off), 1 otherwise.
         */
        public virtual int TakeOffShelf()
        {
            if (IsOnSHelf)
            {
                _isOnShelf = false;
                return 0;
            }
            return 1;
        }


        // below are interface implementation

        //Here is IClonable
        public abstract LibraryItem Clone();
        object ICloneable.Clone()
        {
            return Clone(); 
        }

        //Here is IComparable
        public abstract int CompareTo(object obj);

        int IComparable.CompareTo(object obj)
        {
            return CompareTo(obj);
        }
        //here is userdefined interface ILateFee
        public abstract decimal ChargeFee();
        decimal ILateFee.ChargeFee() { return ChargeFee(); }

        //Run after 
        public virtual int GetCheckOutTimeInDay()
        {
            return ReturnDate.Subtract(CheckOutDate).Days;
        }
        //Here ToString of class object overriden
        public override string ToString()
        {
            return "ID: " + Id + ", Name: " + Title +", Borrowed: "+IsCheckedOut;
        }
    }
}
