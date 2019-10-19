using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Bookstore;
using DocumentFormat.OpenXml.Drawing.Charts;
using Newtonsoft.Json;

namespace Bookstore
{
    class Bill : Program
    {
        public static void PrintBilltxt()
        {
            int total = 0;
            int fintot = 0;
            Customer cust = new Customer();
            StreamWriter sw = new StreamWriter(@"TXTBill.txt");
            sw.WriteLine("----------Welcome to HigginBothams-----------");
            sw.WriteLine("Customer ID" + cust.CustId);
            sw.WriteLine("Customer NAME" + cust.CustName);
            sw.WriteLine("Customer ADDRESS" + cust.CustAddress);
            cust.buyDate = DateTime.Now.ToString("MM/dd/yyyy");
            sw.WriteLine("DATE:" + cust.buyDate);
            sw.WriteLine("--------------------Your Bill--------------------");
            sw.WriteLine("S.No" + "  " + "BookId" + "\t" + "BookName" + " \t" + "Price" + "  " + "Qty" + "\t" + "Total\n");
            foreach (BuyDetails DisplayBuy in buyList)
            {
                total = DisplayBuy.buyCount * DisplayBuy.buyBookPrice;
                fintot += total;
                sw.WriteLine(sno + "\t" + DisplayBuy.buyBookId + "\t" + DisplayBuy.buyBookname + "\t" + DisplayBuy.buyBookPrice + "   \t" + DisplayBuy.buyCount + "\t" + total);
            }
            cust.Totalcost = fintot;

            sw.WriteLine("--------------------------------------------------");
            sw.WriteLine("The Total Cost is:" + fintot);
            sw.WriteLine("Thank You....Visit Again!");
            sw.Close();
        }
        public static void PrintBilljson()
        {
           
            Console.WriteLine("Your Bill is being processed...Please Wait!" + "\nThank You:)");
            using (StreamWriter file = File.CreateText(@"JsonBill.json"))
            {
                JsonSerializer serializer1 = new JsonSerializer();
                JsonSerializer serializer2 = new JsonSerializer();
                //serialize object directly into file stream
                serializer1.Serialize(file,buyList);
                serializer2.Serialize(file, customer);
            }
            File.Delete(@"XMLBill.xml");
        }
        public static void PrintBillxml()
        {

            Console.WriteLine("Your Bill is being processed...Please Wait!" + "\nThank You:)");
            

            XmlSerializer a = new XmlSerializer(typeof(List<BuyDetails>));
            XmlSerializer b = new XmlSerializer(typeof(List<Customer>));

            TextWriter txtWriter = new StreamWriter(@"XMLBill.xml");

            a.Serialize(txtWriter,buyList);
            b.Serialize(txtWriter, customer);

            txtWriter.Close();
            File.Delete(@"JsonBill.json");
        }
    }
}
