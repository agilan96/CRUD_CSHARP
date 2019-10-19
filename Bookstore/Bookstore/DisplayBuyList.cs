using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class DisplayBuyList : Program
    {
        public static void Displaylist1()
        {
            int sno = 1;
            int total;
            int fintot=0;
            int billformat;
            bool confirm = true;
            Customer cust = new Customer();
            Console.Clear();
            Console.WriteLine("--------------------Your Cart--------------------");
            Console.WriteLine("S.No" + "  " + "BookId" + "\t" + "BookName" + " \t" + "Price" + "  " + "Qty"+"\t"+"Total\n");
            foreach (BuyDetails DisplayBuy in buyList)
            {
                total = DisplayBuy.buyCount * DisplayBuy.buyBookPrice;
                fintot += total;
                Console.WriteLine(sno+"\t"+DisplayBuy.buyBookId + "\t" + DisplayBuy.buyBookname + "\t" + DisplayBuy.buyBookPrice + "   \t" + DisplayBuy.buyCount+"\t"+total);
            }
            cust.Totalcost = fintot;
            
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("The Total Cost is:" + fintot);
            
            Console.WriteLine("Choose any one Option:\n");
            Console.WriteLine("1.Bill\n");
            Console.WriteLine("2.Edit\n");
            Console.WriteLine("3.Delete\n");
            Console.WriteLine("4.Continue Shopping\n");

            int opt = int.Parse(Console.ReadLine());

            if(opt==1)
            {
                Console.WriteLine("Select Bill Format:\n" + "1.XML\n" + "2.Json");
                billformat = int.Parse(Console.ReadLine());
                do
                {

                    if (billformat == 1)
                    {
                        Console.WriteLine("Enter Customer ID:");
                        cust.CustId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Customer Name");
                        cust.CustName = Console.ReadLine();
                        Console.WriteLine("Enter Customer Address");
                        cust.CustAddress = Console.ReadLine();
                        cust.buyDate = DateTime.Now.ToString("MM/dd/yyyy");
                        customer.Add(cust);
                        Bill.PrintBillxml();
                        Bill.PrintBilltxt();
                        confirm = false;
                    }
                    else if(billformat==2)
                    {
                        Console.WriteLine("Enter Customer ID:");
                        cust.CustId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Customer Name");
                        cust.CustName = Console.ReadLine();
                        Console.WriteLine("Enter Customer Address");
                        cust.CustAddress = Console.ReadLine();
                        cust.buyDate = DateTime.Now.ToString("MM/dd/yyyy");
                        customer.Add(cust);
                        Bill.PrintBilljson();
                        Bill.PrintBilltxt();
                        confirm = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Option");
                    }

                } while (confirm == true);
            }
            else if(opt==2)
            {
                BuyBook.BuyEdit();
            }
            else if (opt == 3)
            {
                BuyBook.BuyDelete();
            }
            else if (opt == 4)
            {
                BuyBook.BuyContinue();
            }

        }

    }
}
