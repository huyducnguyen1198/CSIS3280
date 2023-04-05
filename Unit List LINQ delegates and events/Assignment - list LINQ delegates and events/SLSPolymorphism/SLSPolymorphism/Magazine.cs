using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    public enum MagazineType
    {
        NONE = -1,
        SCIENCE = 0,
        ARTS = 1,
        MATHS = 2,
        HISTORY = 3,
        EDUCATION = 4,
        FOOD = 5,
        FAMILY= 6,
        WOMAN = 7,
    };
    public class Magazine:LibraryItem
    {
        protected String _issue;
        protected String _company;
        protected MagazineType _type;
        public String Issue { get { return _issue; } set { _issue = value; } }
        public String Company { get { return _company; } set { _company = value; } }
        public MagazineType Type { get { return _type; } set { _type = value; } }
        public Magazine()
        {
            Id = "bk00000";
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;
            Location = LocationInLibrary.NONE;
            IsOnSHelf = false;
            IsCheckedOut = false;
        }
        public Magazine(String id, String title, String issue, String company, LocationInLibrary loc, MagazineType type)
        {
            if (id.Substring(0, 2).ToLower().CompareTo("mg") != 0)
            {
                throw new ArgumentException("Id", "Magazine id starts with mg");
            }
            Id = id;
            Title = title;
            Company= company;
            Location = loc;
            TimeLimit = 30;
            Issue = issue;
            Type = type;
            IsCheckedOut = false;
            IsOnSHelf = true;
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;


        }
        /**
         * Constructor for Clone
         */
        private Magazine(Magazine m)
        {
            int id = int.Parse(m.Id.Substring(2)) + 1;
            String newId = "mg" + id.ToString();


            Id = newId;
            Title = m.Title;
            Company = m.Company;
            Issue = m.Issue;
            Location = m.Location;
            TimeLimit = 30;
            Type = m.Type;

            IsCheckedOut = false;
            IsOnSHelf = true;
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;

        }
        /**
         * ChargeFee checks if Magazine returned later than 1 week(7 days)
         * Should be called after calling Return()
         * Params: none
         * Return: $1 if late, 0 if not
         */
        public override decimal ChargeFee()
        {
            
            return 0.5m;
        }

        /**
         *  Check out Magazine from library
         *  Params: none
         *  Return: 0 if checkout successfully, -1 if not
         */
        public override int CheckOut()
        {
            if (!IsCheckedOut)
            {
                IsCheckedOut = true;
                CheckOutDate = DateTime.Now;
                return 0;
            }
            return -1;
        }

        /**
        * Return the magazine to Library
        * Params: Object b-1 if not
        */
        public override decimal Return(Object b)
        {
            if (this.CompareTo(b) == 0)
            {
                if (IsCheckedOut)
                {
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
         * Clone a Magazine, new copy of the Magazine.
         * Auto generate id, same content.
         * Check for possible duplicate id from Class Librarian when add Magazine.
         */
        public override LibraryItem Clone()
        {
            Magazine newMag = new Magazine(this);
            return newMag;
        }

        /**
         * Compare two Magazine
         * Params: Object
         * return: 0 if two magazine have the same Id, -1 if not
         */
        public override int CompareTo(object obj)
        {
            if (obj is Magazine)
            {
                return Id.CompareTo(((Magazine)obj).Id);
            }
            return -1;
        }

        public override void PrintBookInfo()
        {
            System.Console.WriteLine("********** Magazine Information **********");
            System.Console.WriteLine("Id:       " + Id);
            System.Console.WriteLine("Title:    " + Title);
            System.Console.WriteLine("Issue:    " + Issue);
            System.Console.WriteLine("Type:     " + Type);

            System.Console.WriteLine("Company:  " + Company);
            System.Console.WriteLine("Location: " + Location);

            System.Console.WriteLine("");

        }
    }
}
