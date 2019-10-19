using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class DeleteBook : Program
    {
        public static void RemoveBook()
        {
            Book book = new Book();

            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del)) //lambda exp
            {
                bookList.RemoveAll(idel => idel.bookId == Del);
                Console.WriteLine("Book id - {0} has been deleted", Del);
                Program.sno--;
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }


        }
    }
}
