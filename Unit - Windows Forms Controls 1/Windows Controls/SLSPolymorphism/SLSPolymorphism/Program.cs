using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLSPolymorphism
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {

            
             //book and ebook
            LibraryItem hp1 = new PaperBook("pb10000", "Harry Potter 1", 10000, "JK Rowling", LocationInLibrary.THIRDFLOOR, BookType.ARTS);
            LibraryItem hp2 = new PaperBook("pb20000", "Harry Potter 2", 20000, "JK Rowling", LocationInLibrary.THIRDFLOOR, BookType.ARTS);
            LibraryItem hp3 = new PaperBook("pb30000", "Harry Potter 3", 30000, "JK Rowling", LocationInLibrary.THIRDFLOOR, BookType.ARTS);
            LibraryItem hp4 = new PaperBook("pb40000", "Harry Potter 4", 40000,"JK Rowling", LocationInLibrary.THIRDFLOOR, BookType.ARTS);
            LibraryItem hp5 = new PaperBook("pb50000", "Harry Potter 5", 50000, "JK Rowling", LocationInLibrary.THIRDFLOOR, BookType.ARTS);
            LibraryItem hp11 = (PaperBook)hp1.Clone();
            LibraryItem hp1e = new EBook("eb10000", "Harry Potter 1",10000, "JK Rowling", "http.com", BookType.ARTS);



            // Magazine
            LibraryItem mg1 = new Magazine("mg10000", "Costco Connection","1000a","Costco", LocationInLibrary.SECONDFLOOR, MagazineType.FAMILY);
            LibraryItem mg2 = new Magazine("mg20000", "Woman's Day", "2000b", "Woman's Day", LocationInLibrary.FIRSTFLOOR, MagazineType.WOMAN);
            LibraryItem mg3 = new Magazine("mg20000", "National Geographic", "3000b", "Woman's Day", LocationInLibrary.FIRSTFLOOR, MagazineType.EDUCATION);

            //Journal

            LibraryItem jn1 = new Journal("jn10000", "Journal of Political Economy", 00223808, "University of Chicago", LocationInLibrary.SECONDFLOOR, JournalType.POLITIC);
            LibraryItem jn2 = new Journal("jn20000", "Nature", 00280836, "Nature Publishing Group", LocationInLibrary.SECONDFLOOR, JournalType.NATURE);
            LibraryItem jn3 = new Journal("jn30000", "IEEE Communications Surveys and Tutorialsopen access", 1553877, "Institute of Electrical and Electronics Engineers Inc.", LocationInLibrary.SECONDFLOOR, JournalType.TECH);

            //Librarian

            Librarian librarian = new Librarian();
            librarian.addItem(hp1);
            librarian.addItem(hp2);
            librarian.addItem(hp3);
            librarian.addItem(hp4);
            librarian.addItem(hp5);
            librarian.addItem(hp11);
            librarian.addItem(hp1e);
            librarian.addItem(mg1);
            librarian.addItem(mg2);
            librarian.addItem(mg3);
            librarian.addItem(mg1.Clone());
            librarian.addItem(jn1);
            librarian.addItem(jn2);
            librarian.addItem(jn3);
            librarian.addItem(jn2.Clone());
            librarian.addItem(hp1.Clone());



            
            /*
            Person s1 = new Student("Huy", "Nguyen", "W01000", "","");
            Person s2 = new Student("Hermione", "Granger", "W0200","","");
            Person i1 = new Instructor("Albus", "Dumbledore", "E00200","Hogwarts", "");


           
            s1.checkOutBook(hp1);
            s1.checkOutBook(hp2);
            s1.checkOutBook(hp3);
            s1.checkOutBook(hp4);

            s2.checkOutBook(hp11);


            i1.checkOutBook(hp5);
            i1.checkOutBook(jn3);
            i1.checkOutBook(hp1e);
            i1.checkOutBook(jn1);
            i1.checkOutBook(jn2);
            i1.checkOutBook(mg3);

            i1.returnBook(hp5);
            i1.returnBook(jn2);
            i1.returnBook(mg1);
            i1.returnBook(hp1);


            
            DateTime aMonth = DateTime.Now.AddDays(-31);
            DateTime fourMonth = DateTime.Now.AddDays(-31 * 4);
            DateTime TwoWeek = DateTime.Now.AddDays(-7 * 2);

            hp1.setCheckOutDate(fourMonth);
            hp2.setCheckOutDate(fourMonth);
            hp3.setCheckOutDate(fourMonth);
            hp4.setCheckOutDate(fourMonth);
            hp5.setCheckOutDate(fourMonth);
            hp1e.setCheckOutDate(fourMonth);
            s1.returnBook(hp1);
            s1.returnBook(hp2);
            s2.returnBook(hp11);
            i1.returnBook(hp1e);

            
            librarian.TakeItemOffShelf(jn1);
            librarian.TakeItemOffShelf(hp1);
            i1.checkOutBook(hp1);
            */

            
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LibraryForm(librarian));
            }
        }
    }
}
