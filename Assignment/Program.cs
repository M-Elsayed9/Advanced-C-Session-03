using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
  

        static void Main(string[] args)
        {
            #region Book
            //List<Book> books = new List<Book>()
            //{
            //    new Book("1", "C#", new[] {"Omar", "Ahmed", "Ali"}, DateTime.Now, 50),
            //    new Book("2", "OOP", new[] {"Mohamed"}, DateTime.Now, 30),
            //    new Book("3", "SQL", new[] {"Hamada", "Aya"}, DateTime.Now, 40)
            //};

            //// A
            //BookDelegate title = BookFunctions.GetTitle;
            //BookDelegate price = BookFunctions.GetPrice;
            //BookDelegate authors = BookFunctions.GetAuthors;

            //LibraryEngine.ProcessBooks(books, title);
            //LibraryEngine.ProcessBooks(books, price);
            //LibraryEngine.ProcessBooks(books, authors);

            //// B
            //Func<Book, string> func = BookFunctions.GetTitle;

            //LibraryEngine.ProcessBooksv2(books, func);

            //// C
            //LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });
            //LibraryEngine.ProcessBooksv2(books, delegate (Book b) { return b.ISBN; });

            //// D
            //LibraryEngine.ProcessBooks(books, b => $"Publication Date: {b.PublicationDate}");
            //LibraryEngine.ProcessBooksv2(books, b => $"Publication Date: {b.PublicationDate}"); 
            #endregion

        }
    }
}
