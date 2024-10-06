using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate string ProcessBookDelegate(Book book);

    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, ProcessBookDelegate deligate)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(deligate(book));
            }

        }

        public static void ProcessBooksv2(List<Book> books, Func<Book, string> fbtr)
        {
            foreach (Book B in books)
            {
                Console.WriteLine(fbtr(B));
            }
        }
    }
}
