using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class SearchBook : Program
    {
        public static void SearchBook1()
        {
            Book book = new Book();
            Console.Write("Search by:\n" + "1.Book id\n" + "2.Book Name\n");
            int opt = int.Parse(Console.ReadLine());
           
            bool val = false;
            bool ConfirmResult = true;
            do
            {

                if (opt == 1)
                {
                    Console.WriteLine("Enter Id");
                    int find1 = int.Parse(Console.ReadLine());
                    if (bookList.Exists(x => x.bookId == find1))
                    {
                        foreach (Book searchId in bookList)
                        {
                            if (searchId.bookId == find1)
                            {
                                Console.WriteLine("Book id :{0}\n" +
                                "Book name :{1}\n" +
                                "Book price :{2}\n" +
                                "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Book id {0} not found", find1);
                    }
                    ConfirmResult = false;
                }
                if (opt == 2)
                {
                    Console.WriteLine("Enter Book name");
                    String find = Console.ReadLine();
                    foreach (Book Search in bookList)
                    {
                        
                        if (Search.bookName.Contains(find))
                        {
                            Console.WriteLine("Book id :{0}\n" +
                             "Book name :{1}\n" +
                             "Book price :{2}\n" +
                             "Book Count :{3}", Search.bookId, Search.bookName, Search.bookPrice, Search.bookCount);
                            val = true;
                        }

                    }
                    if (val == false)
                    {
                        Console.WriteLine("Book not Found");
                    }
                    ConfirmResult = false;
                }
                else
                {

                    Console.WriteLine("Enter Correct Option");
                }
            } while (ConfirmResult == true);

        }

    }
}
