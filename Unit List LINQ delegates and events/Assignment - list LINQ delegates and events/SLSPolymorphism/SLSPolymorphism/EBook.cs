using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    public class EBook:Book
    {
        protected String _url;
        public String URL { get { return _url; } set { _url = value; } }

        public EBook(String id, String title, int isbn, String author, String url, BookType type)
        {
            if (id.Substring(0, 2).ToLower().CompareTo("eb") != 0)
            {
                throw new ArgumentException("Id", "EBook id starts with eb");
            }
            Id = id;
            Title = title;
            Author = author;
            Type = type;
            URL = url;
            ISBN = isbn;
            TimeLimit = 3 * 30;
            IsCheckedOut = false;
            IsOnSHelf = true;

            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;


        }

        private EBook(EBook b)
        {
            int id = int.Parse(b.Id.Substring(2)) + 1;
            String newId = "eb" + id.ToString();


            Id = newId;
            Title = b.Title;
            Author = b.Author;
            Location = b.Location;
            Type = b.Type;
            URL = b.URL;
            TimeLimit = 3 * 30;
            IsCheckedOut = false;
            IsOnSHelf = true;
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;

        }
        public override decimal ChargeFee()
        {
            
            return 0.5m;
        }

        /**
         * Clone an ebook, new copy of the ebook.
         * Auto generate id, same content.
         * Check for possible duplicate id from Class Librarian when add book.
         */
        public override LibraryItem Clone()
        {
            EBook newBook = new EBook(this);
            return newBook;
        }

        /**
         * Compare two eBook
         * Params: Object
         * return: 0 if two book have the same Id, -1 if not
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
            System.Console.WriteLine("********** EBook Information **********");
            System.Console.WriteLine("Id:       " + Id);
            System.Console.WriteLine("Title:    " + Title);
            System.Console.WriteLine("Author:   " + Author);
            System.Console.WriteLine("Type:     " + Type);
            System.Console.WriteLine("Location: " + URL);

            System.Console.WriteLine("");

        }
    }
}
