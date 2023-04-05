using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    public enum JournalType
    {
        NONE = -1,
        SCIENCE = 0,
        ARTS = 1,
        MATHS = 2,
        HISTORY = 3,
        EDUCATION = 4,
        FOOD = 5,
        FAMILY = 6,
        WOMAN = 7,
        TECH = 8,
        POLITIC = 9,
        NATURE = 10,
    };
    public class Journal:LibraryItem
    {
        protected String _publisher;
        protected JournalType _type;
        protected int _issn;
        public String Publisher { get { return _publisher; } set { _publisher = value; } }
        public JournalType Type { get { return _type; } set { _type = value; } }
        public int ISSN { get { return _issn; } set { _issn = value; } }
        public Journal()
        {
            Id = "bk00000";
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;
            Location = LocationInLibrary.NONE;
            IsOnSHelf = false;
            IsCheckedOut = false;
        }
        public Journal(String id, String title, int issn, String publisher, LocationInLibrary loc, JournalType type)
        {
            if (id.Substring(0, 2).ToLower().CompareTo("jn") != 0)
            {
                throw new ArgumentException("Id", "Journal id starts with jn");
            }
            Id = id;
            Title = title;
            Publisher = publisher;
            Location = loc;
            TimeLimit = 30;
            ISSN = issn;
            Type = type;
            IsCheckedOut = false;
            IsOnSHelf = true;
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;


        }
        /**
         * Constructor for Clone
         */
        private Journal(Journal m)
        {
            int id = int.Parse(m.Id.Substring(2)) + 1;
            String newId = "jn" + id.ToString();


            Id = newId;
            Title = m.Title;
            Publisher = m.Publisher;
            Location = m.Location;
            TimeLimit = 30;
            Type = m.Type;
            ISSN = m.ISSN;
            IsCheckedOut = false;
            IsOnSHelf = true;
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;

        }
        /**
         * ChargeFee checks if Journal returned later than 2 Months(60 days)
         * Should be called after calling Return()
         * Params: none
         * Return: $0.5 if late, 0 if not
         */
        public override decimal ChargeFee()
        {
            
            return 0.5m;
        }

        /**
         *  Check out Journal from library
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
        * Return the Journal to Library
        * Params: Object b
        * return: 0 if return successfully  -1 if not
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
         * Clone a Journal, new copy of the Journal.
         * Auto generate id, same content.
         * Check for possible duplicate id from Class Librarian when add Journal.
         */
        public override LibraryItem Clone()
        {
            Journal newMag = new Journal(this);
            return newMag;
        }

        /**
         * Compare two Journal
         * Params: Object
         * return: 0 if two Journal have the same Id, -1 if not
         */
        public override int CompareTo(object obj)
        {
            if (obj is LibraryItem)
            {
                return Id.CompareTo(((LibraryItem)obj).Id);
            }
            return -1;
        }

        public override void PrintBookInfo()
        {
            System.Console.WriteLine("********** Journal Information **********");
            System.Console.WriteLine("Id:       " + Id);
            System.Console.WriteLine("Title:    " + Title);
            System.Console.WriteLine("Type:     " + Type);

            System.Console.WriteLine("Publisher:" + Publisher);
            System.Console.WriteLine("Location: " + Location);

            System.Console.WriteLine("");

        }
    }
}
