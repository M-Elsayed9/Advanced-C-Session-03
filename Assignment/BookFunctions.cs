using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            if (book is null)
                return "No book found";

            return $"Title: {book.Title}";
        }

        public static string GetAuthors(Book book)
        {
            if(book is null)
                return "No book found";
            else if(book.Authors.Length == 0)
                return "No authors found";

            return string.Join(", ", book.Authors);
        }

        public static string GetPrice(Book book)
        {
            if(book is null)
                return "No book found";
            
            return $"Price: { book.Price.ToString("C")}";
        }
    }
}
