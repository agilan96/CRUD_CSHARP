using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class AddBook : Program
    {
        public static void GetBook(int noofbooks)
        {

            Book book = new Book();
            Console.Write("Book Id:");
            book.bookId = int.Parse(Console.ReadLine()); 
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);

        }
    }
}
