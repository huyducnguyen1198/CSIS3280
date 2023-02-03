using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // librarian and book list
            Librarian librarian= new Librarian();

            Book hp1 = new Book(1000, "Harry Potter 1", "JK Rowling");
            Book hp2 = new Book(2000, "Harry Potter 2", "JK Rowling");
            Book hp3 = new Book(3000, "Harry Potter 3", "JK Rowling");
            Book hp4 = new Book(4000, "Harry Potter 4", "JK Rowling");
            Book hp5 = new Book(5000, "Harry Potter 5", "JK Rowling");

            Book sh1 = new Book(1111, "A Study in Scarlet: A Novel", "Arthur Conan Doyle");
            Book sh2 = new Book(2222, "A Sign of Four: A Novel", "Arthur Conan Doyle");
            Book sh3 = new Book(3333, "Adventures of Sherlock Holmes: Short Stories", "Arthur Conan Doyle");
            Book sh4 = new Book(4444, "Memoirs of Sherlock Holmes: Short Stories", "Arthur Conan Doyle");
            Book sh5 = new Book(5555, "The Hound of the Baskervilles: A Novel", "Arthur Conan Doyle");

            librarian.addBook(hp1);
            librarian.addBook(hp2);
            librarian.addBook(hp3);
            librarian.addBook(hp4);
            librarian.addBook(hp5);

            librarian.addBook(sh1);
            librarian.addBook(sh2);
            librarian.addBook(sh3);
            librarian.addBook(sh4);
            librarian.addBook(sh5);



            Student s1 = new Student("Huy", "Nguyen", "W1111", "abc", "1234");
            Student s2 = new Student("Hermione", "Granger", "W2222", "Hogwarts", "1234");

            System.Console.WriteLine("************************** Student check out book (1 of 4 will fail) ****************************");
            //Student check out book
            s1.checkOutBook(librarian.getBookByIsbn(1000));
            s1.checkOutBook(librarian.getBookByIsbn(2000));
            s1.checkOutBook(librarian.getBookByIsbn(3000));
            //3 books limit met, should printout dening message
            s1.checkOutBook(librarian.getBookByIsbn(4000));
            System.Console.WriteLine();

            librarian.printBookCatalog();


            System.Console.WriteLine("************************** Student tries to check out borrowed book *****************************");

            //try to borrow checkedOut book, should printout denying message.
            s2.checkOutBook(librarian.getBookByIsbn(1000));


            System.Console.WriteLine("************************** Student return book ****************************");

            s1.returnBook(librarian.getBookByIsbn(1000));


            s1.PrintBookInfo();

            s2.checkOutBook(librarian.getBookByIsbn(5000));
            s2.PrintBookInfo();




            s1.UserInfo();
            System.Console.WriteLine("************************** Instructor borrow book, 1/6 fail ****************************");

            Instructor i1 = new Instructor("Harry", "Potter", "E11111", "privet drive", "4343");
            i1.checkOutBook(sh1);
            i1.checkOutBook(sh2);
            i1.checkOutBook(sh3);
            i1.checkOutBook(sh4);
            i1.checkOutBook(sh5);

            i1.checkOutBook(hp4);

            i1.PrintBookInfo();
            //librarian.printBookCatalog();

            System.Console.ReadLine();


        }
    }
}
