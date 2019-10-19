using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class DisplayArchive : Program
    {
        public static void Displaylist()
        {
            Book book = new Book();
            Console.WriteLine("S.No" + "  " + "BookId" + "\t" + "BookName" + " \t" + "Price" + "  " + "Qty\n");
            foreach (Book display in bookList)
            {
                Console.WriteLine(Program.sno +"\t"+ display.bookId + "\t" + display.bookName + "\t" + display.bookPrice + "\t" + display.bookCount);
                Program.sno++;
            }
            Console.WriteLine();

        }
    }
}
