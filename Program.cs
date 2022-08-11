
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Stock ProductStock = new Stock();
        
            int NumberOfProduct = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter Tax Amount");
            try
            {
                Tax.TaxRate = Convert.ToDouble(Console.ReadLine());
                    break;
                }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Tax Value");
                }
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter Number Of Product!");
                try
                {
                    NumberOfProduct = Convert.ToInt32(Console.ReadLine());
                    ProductStock.EnterProductDetails(NumberOfProduct);
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Product Number!");
                }
            }

                Report.ReportBeforeDiscount();
                Console.WriteLine("Do You Want To Enter Discout To Whole Product(Yes/No) ?");
                if (Console.ReadLine().ToLower().Equals("yes"))
                {     
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter Discount Amount:");
                    try
                    {
                        string DiscountAmount = Console.ReadLine();
                        Discount.ApplyDiscountToAllProduct(Convert.ToInt32(DiscountAmount));
                        break;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid Discount Value!");
                    }
                }

                Console.WriteLine("Do You Want A Report?(yes/no)");

                    if (Console.ReadLine()!.ToLower().Equals("yes"))
                    {
                        Report.ReportAfterDiscount();
                    }
                }
                else
                {
                    Discount.ApplyDiscountToAllProductAnswerIsNo();
                    Report.ReportNoDiscount();
                }

                Console.WriteLine("Do you have A special Code try out !");

            string? upc = "";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                { 
                    Console.Write("Enter UPC :");
                    upc = Console.ReadLine();
                    Selective.selective(upc!);
                    Console.WriteLine("Preceding:");
                    Precedence.preceding(upc!);
                    Console.WriteLine("Choose Discount Type :");
                    Combining.ChoosingBetweenTwoDiscountMethods(upc!);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Do You Want To Know Total Expenses? ");
                    if (Console.ReadLine()!.ToLower().Equals("yes"))
                    {
                        Product product = Product.GetProductWithSpecifiedUPC(upc!);
                        Report.ReportTotalExpenses(product);
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid UPC Code Number!");
                }
            }


          
        }
    }
}
