using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessor
{
    public  class Utility
    {
        public static void SaveLibraryItem(
            String name,
            String author,
            String publisher,
            String isbn,
            String url,
            String genre,
            String location,
            int clone
            )
        {
            cs3280Spr23DataSetTableAdapters.LibraryitemsTableAdapter adapter 
                = new cs3280Spr23DataSetTableAdapters.LibraryitemsTableAdapter();

            cs3280Spr23DataSet.LibraryitemsDataTable table = new cs3280Spr23DataSet.LibraryitemsDataTable();
            adapter.Fill(table);


            for(int i = 0; i < clone; i++)
            {
                cs3280Spr23DataSet.LibraryitemsRow newRow = table.NewLibraryitemsRow();
                newRow.ItemName = name;
                newRow.Author = author;
                newRow.Publisher = publisher;
                newRow.ISBN = isbn;
                newRow.URL = url;
                newRow.Genre = genre;
                newRow.Location = location;
                table.AddLibraryitemsRow(newRow);
                adapter.Update(table);

            }
            

                



        }
    }

    
}
