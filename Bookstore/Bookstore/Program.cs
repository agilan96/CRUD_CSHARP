using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore
{
    
    

    class Program
    {
        public static List<Book> bookList = new List<Book>
        {
            new Book{bookId=10,bookName="Angular JS",bookPrice=250,bookCount=4,x=4},
            new Book{bookId=21,bookName="C# Bascics",bookPrice=450,bookCount=6,x=6},
            new Book{bookId=32,bookName="HTML & CSS",bookPrice=150,bookCount=2,x=2},
            new Book{bookId=44,bookName="SDLC 3.0",bookPrice=190,bookCount=1,x=1},
            new Book{bookId=59,bookName="Clean Coder",bookPrice=90,bookCount=5,x=5},
            new Book{bookId=68,bookName="Effective C++",bookPrice=590,bookCount=6,x=6},
            new Book{bookId=75,bookName="Cloudonomics",bookPrice=400,bookCount=9,x=9},
            new Book{bookId=81,bookName="Begin Python",bookPrice=510,bookCount=8,x=8},
            new Book{bookId=92,bookName="R for Data",bookPrice=740,bookCount=1,x=1},
            new Book{bookId=12,bookName="Android Funda",bookPrice=620,bookCount=3,x=3},
        };
        public static List<BuyDetails> buyList = new List<BuyDetails>();
        public static List<Customer> customer = new List<Customer>();
        static Book book = new Book();
        static BuyDetails buy = new BuyDetails();
        static Customer cust = new Customer();
        public static int sno = 01;


        static void Main(string[] args)
        {

            Console.Write("\t\t\t\t\t\tWelcome To HigginBothams!!!\n" + "Login\n");
            Console.Write("Enter Username:\n");
            string username = Console.ReadLine();
            Console.Write("Enter password:\n");
            string password = Console.ReadLine();
            int noofbooks = 4;
            if ((username == "user1") && (password == "pass1"))
            {
                bool close = true;
                while (close)
                {
                    Console.WriteLine("\nList:\n" +
                    "1)Display books\n" +
                    "2)Buy book\n" +
                    "3)Search book\n" +
                    "4)Proceed To Cart\n" +
                    "5)Add book\n" +
                    "6)Delete book\n" +
                    "7)Close\n\n");
                    Console.Write("Choose your option from List :");

                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        DisplayArchive.Displaylist();
                    }
                    else if (option == 2)
                    {
                        BuyBook.Buy();
                    }
                    else if (option == 3)
                    {
                        SearchBook.SearchBook1();
                    }
                    else if (option == 4)
                    {
                        DisplayBuyList.Displaylist1();
                        close = false;
                    }
                    else if (option == 5)
                    {
                        noofbooks = noofbooks + 1;
                        AddBook.GetBook(noofbooks);
                    }
                    else if (option == 6)
                    {
                        DeleteBook.RemoveBook();
                    }
                    else if (option == 7)
                    {
                        Console.WriteLine("Thank you");
                        close = false;
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }
            Console.ReadLine();
        }







        
        


    }
}


