
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
                Console.WriteLine("Enter Tax Amount");
                Tax.TaxRate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Number Of Product!");
                NumberOfProduct = Convert.ToInt32(Console.ReadLine());
                ProductStock.EnterProductDetails(NumberOfProduct);
                Report.ReportBeforeDiscount();

                Console.WriteLine("Do You Want To Enter Discout To Whole Product(Yes/No) ?");
                if (Console.ReadLine().ToLower().Equals("yes"))
                {
                    Console.WriteLine("Enter Discount Amount:");
                    Discount.ApplyDiscountToAllProduct(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Do You Want A Report?(yes/no)");
                    if (Console.ReadLine().ToLower().Equals("yes"))
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
                Console.Write("Enter UPC :");
                string upc = Console.ReadLine();
                Selective.selective(upc);
                Console.WriteLine("Preceding:");
                Precedence.preceding(upc);
            Console.WriteLine("DO You Want To Know Total Expenses? ");
            if (Console.ReadLine().ToLower().Equals("yes"))
            {
                Combining.ChoosingBetweenTwoDiscountMethods(upc);
            }

        }
    }
}
