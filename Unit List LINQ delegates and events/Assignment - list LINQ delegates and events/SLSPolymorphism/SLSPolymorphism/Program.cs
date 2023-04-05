using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLSPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
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


            Person s1 = new Student("Huy", "Nguyen", "W01000", "","");
            Person s2 = new Student("Hermione", "Granger", "W0200","","");
            Person i1 = new Instructor("Albus", "Dumbledore", "E00200","Hogwarts", "");
            List<Person> people = new List<Person>();
            people.Add(s1);
            people.Add(s2);
            people.Add(i1);

            System.Console.WriteLine();
            System.Console.WriteLine("********* Student check out book(1 over limit = fail) *************");

            s1.checkOutBook(hp1);
            s1.checkOutBook(hp2);
            s1.checkOutBook(hp3);
            s1.checkOutBook(hp4);

            System.Console.WriteLine();
            System.Console.WriteLine("********* Student check out book(1 already checked out = fail) *************");

            s2.checkOutBook(hp11);
            s2.checkOutBook(hp1);


            System.Console.WriteLine("********* Instructor checkout book (1 over limit = fail) *************");
            i1.checkOutBook(hp5);
            i1.checkOutBook(jn3);
            i1.checkOutBook(hp1e);
            i1.checkOutBook(jn1);
            i1.checkOutBook(jn2);
            i1.checkOutBook(mg3);

            System.Console.WriteLine();
            System.Console.WriteLine("********* Return book late and not late*************");

            DateTime aMonth = DateTime.Now.AddDays(-29);
            DateTime fourMonth = DateTime.Now.AddDays(-31 * 4);
            DateTime TwoWeek = DateTime.Now.AddDays(-7 * 2);

            hp1.setCheckOutDate(aMonth);
            hp2.setCheckOutDate(aMonth);
            
            /*hp3.setCheckOutDate(aMonth);
            hp4.setCheckOutDate(aMonth);
            hp5.setCheckOutDate(aMonth);
            hp1e.setCheckOutDate(aMonth);
            jn3.setCheckOutDate(aMonth);*/
            

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("************************ Book list *****************************");
            librarian.PrintBookList();
            System.Console.WriteLine();

            System.Console.WriteLine("************************ QUERY 1, book by a student *****************************");
            System.Console.WriteLine("List of student: ");
            foreach(Person p in people)
            {
                if (p is Student)
                {
                    System.Console.WriteLine(p.LastName);
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Please input name of one student: ");
            String lastName = System.Console.ReadLine();
            var l = people.Find(x => x.LastName.CompareTo(lastName) == 0);
            if (l != null)
            {
                if (!(l is Student)) return;
                Student s = (Student)l;
                List<LibraryItem> list = s.ItemList;
                list.OrderBy(x => x.CheckOutDate);
                foreach(LibraryItem i in list)
                {
                    System.Console.Write(i.Id);
                    System.Console.WriteLine(": Supposed return day {0:f}", i.CheckOutDate.ToShortDateString());
                }
            }


            System.Console.WriteLine("************************ QUERY 2, book by a person *****************************");
            System.Console.WriteLine("List of people: ");
            foreach (Person p in people)
            {
                System.Console.WriteLine(p.LastName);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Please input name of one person: ");
            lastName = System.Console.ReadLine();
            var l1 = people.Where(x => x.LastName.CompareTo(lastName) == 0).Select(x => ((Student)x).ItemList).ToList();
            var li = l1[0];
            var bl = li.Where(x => x is Book);
            foreach(Book i in bl)
            {
                Console.WriteLine(i.Title);
            }
            /*if (l1 != null)
            {
                if (!(l1.Any())) return;
                Person s = (Person)(l1.ToList()[0]);
                List<LibraryItem> list = s.ItemList;
                list.OrderBy(x => x.CheckOutDate);
                foreach (LibraryItem i in list)
                {
                    System.Console.Write(i.Id);
                    System.Console.WriteLine(": Supposed return day {0:f}", i.CheckOutDate.ToShortDateString());
                }
            }*/

            System.Console.WriteLine("************************ QUERY 3, return tommorow *****************************");
            
            librarian.PrintBorrwedItem();
            foreach(Person p in people)
            {
                List<LibraryItem> list = p.ItemList;
                foreach (LibraryItem i in list)
                {
                    double dateleft = p.GetSupposedReturnDate(i).Subtract(DateTime.Now).TotalDays;
                    if(dateleft.CompareTo(1) <= 0)
                    {
                        System.Console.WriteLine(p.LastName);
                        System.Console.WriteLine("should be return "+  i.Id);
                        System.Console.WriteLine("on {0:f}", p.GetSupposedReturnDate(i));
                    }
                    System.Console.WriteLine();

                }
            }

            var items = librarian.getBookCatalog();
            var book = items.Where(x => x is Magazine);
            foreach (Magazine bookitem in book)
            {
                Console.WriteLine(bookitem.Title);
            }
            System.Console.ReadLine();




        }
    }
}
