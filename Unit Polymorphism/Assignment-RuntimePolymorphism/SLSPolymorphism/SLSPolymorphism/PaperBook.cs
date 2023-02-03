using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    public class PaperBook:Book
    {
        public PaperBook()
        {
            Id = "pb00000";
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;
            Location = LocationInLibrary.NONE;
            IsOnSHelf = false;
            IsCheckedOut = false;
        }
        public PaperBook(String id, String title, int isbn, String author, LocationInLibrary loc, BookType type)
        {
            if (id.Substring(0, 2).ToLower().CompareTo("pb") != 0)
            {
                throw new ArgumentException("Id", "Paper Book id starts with pb");
            }
            Id = id;
            Title = title;
            Author = author;
            Location = loc;
            Type = type;
            ISBN = isbn;
            TimeLimit = 30;
            IsCheckedOut = false;
            IsOnSHelf = true;
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now;


        }
        /**
         * Constructor for Clone
         */
        private PaperBook(PaperBook b)
        {
            int id = int.Parse(b.Id.Substring(2)) + 1;
            String newId = "pb" + id.ToString();


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
            
            return 1.0m;
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
            PaperBook newBook = new PaperBook(this);
            return newBook;
        }

        /**
         * Compare two Book
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
