using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class BuyBook : Program
    {
        public static void Buy()
        {
            Book book = new Book();
            BuyDetails buy = new BuyDetails();
            Console.Write("Book id :");
            buy.buyBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            buy.buyCount = int.Parse(Console.ReadLine());
            
           
            

            if (bookList.Exists(x => x.bookId == buy.buyBookId))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == buy.buyBookId)
                    {
                        if (searchId.bookCount >= searchId.bookCount - buy.buyCount && searchId.bookCount - buy.buyCount >= 0)
                        {
                            searchId.bookCount = searchId.bookCount - buy.buyCount;
                            buy.buyBookname = searchId.bookName;
                            buy.buyBookPrice = searchId.bookPrice;

                        }
                        else
                        {
                            Console.WriteLine("Only {0} books are found", searchId.bookCount);
                            break;
                        }
                        buyList.Add(buy);
                    }


                }

            }
            else
            {
                Console.WriteLine("Book id {0} not found", buy.buyBookId);
            }

            Console.WriteLine("");
        }

        

        public static void BuyEdit()
        {
            bool Confirmresult = true;
            bool result = true;         
            int UpdateOption = 0;
            int UpdateQuantity = 0;
            String edit;
            String qty;
            Book book = new Book();
            BuyDetails buy = new BuyDetails();
            Console.WriteLine("Enter BookId to be deleted");
            do
            {
                edit = Console.ReadLine();
                while (!int.TryParse(edit, out UpdateOption))
                {
                    Console.WriteLine("This is not a number!");
                    edit = Console.ReadLine();
                }


                foreach (BuyDetails searchId in buyList)
                {
                    if (searchId.buyBookId == UpdateOption)
                    {
                        Console.WriteLine("Enter the Qty you want edit");
                        do
                        {
                            qty = Console.ReadLine();
                            while (!int.TryParse(qty, out UpdateQuantity))
                            {
                                Console.WriteLine("This is not a number!");
                            }
                            if (UpdateQuantity > 0)
                            {
                                
                                foreach (Book matchId in bookList)
                                {
                                    if (matchId.bookId == searchId.buyBookId)
                                    {
                                        if (UpdateQuantity <= matchId.x)
                                        {
                                            searchId.buyCount = UpdateQuantity;
                                            matchId.bookCount = matchId.x - UpdateQuantity;
                                            DisplayBuyList.Displaylist1();
                                            result = false;
                                        }
                                        else
                                        { 
                                          
                                                Console.WriteLine("Only {0} books are found", matchId.x);
                                                Console.WriteLine("Re-Enter Quantity");
                                        }

                                    }
                                }
                            }
                            
                        } while (result == true);
                        
                    }

                    else
                    {
                        Console.WriteLine("Book id {0} not found", UpdateOption);
                    }

                    }
                
            } while (Confirmresult == true);    
         }
        public static void BuyDelete()
        {
            bool Confirmresult = true;
            int UpdateOption = 0;
            String del;
            Book book = new Book();
            BuyDetails buy = new BuyDetails();

            Console.WriteLine("Enter BookId to be deleted");
            do {

                 del = Console.ReadLine();
                while (!int.TryParse(del, out UpdateOption))
                {
                    Console.WriteLine("This is not a number!");
                    del = Console.ReadLine();
                }
                foreach(BuyDetails matchId in buyList)
                {
                    if (matchId.buyBookId == UpdateOption)
                    {
                        Confirmresult = false;
                        foreach (Book SearchId in bookList)
                        {
                            if(SearchId.bookId==matchId.buyBookId)
                            {
                                SearchId.bookCount += matchId.buyCount;
                            }

                            
                        }
                       
                    }

                    else
                    {
                        Console.WriteLine("Book id {0} not found", UpdateOption);
                    }
                }
                buyList.RemoveAll(idel => idel.buyBookId == UpdateOption);



            } while (Confirmresult == true);
            Console.WriteLine("Updated cart");
            DisplayBuyList.Displaylist1();

        }

        public static void BuyContinue()
        {
            DisplayArchive.Displaylist();
            Book book = new Book();
            BuyDetails buy = new BuyDetails();
            Console.WriteLine("Select Book Id you want to shop");
            buy.buyBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            buy.buyCount = int.Parse(Console.ReadLine());
            if (bookList.Exists(x => x.bookId == buy.buyBookId))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == buy.buyBookId)
                    {
                        if (searchId.bookCount >= searchId.bookCount - buy.buyCount && searchId.bookCount - buy.buyCount >= 0)
                        {
                            searchId.bookCount = searchId.bookCount - buy.buyCount;
                            buy.buyBookname = searchId.bookName;
                            buy.buyBookPrice = searchId.bookPrice;

                        }
                        else
                        {
                            Console.WriteLine("Only {0} books are found", searchId.bookCount);
                            break;
                        }
                        buyList.Add(buy);
                    }


                }

            }
            else
            {
                Console.WriteLine("Book id {0} not found", buy.buyBookId);
            }

            Console.WriteLine("");
            DisplayBuyList.Displaylist1();
        }
        

    }
}

    

