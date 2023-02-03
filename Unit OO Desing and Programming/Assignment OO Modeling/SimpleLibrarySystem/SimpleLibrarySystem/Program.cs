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

            librarian.addBook(hp1);
            librarian.addBook(hp2);
            librarian.addBook(hp3);
            librarian.addBook(hp4);
            librarian.addBook(hp5);



            Student s1 = new Student("Huy", "Nguyen", "W1111", "abc", 1234);
            Student s2 = new Student("Hermione", "Granger", "W2222", "Hogwarts", 4321);

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


            s1.printBookList();

            s2.checkOutBook(librarian.getBookByIsbn(5000));
            s2.printBookList();


            librarian.printBookCatalog();

            System.Console.ReadLine();


        }
    }
}
