
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
 
    public class main
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
            Discount.ReportBeforeDiscount();

            Console.WriteLine("Do You Want To Enter Discout To Whole Product ?");
            if (Console.ReadLine().ToLower().Equals("yes"))
            {
                Console.WriteLine("Enter Discount Amount:");
                Discount.UniversalDiscountnumber = Convert.ToInt32(Console.ReadLine());
                Discount.ApplyDiscountToAllProduct();
                Console.WriteLine("Do You Want A Report?(yes/no)");
                if (Console.ReadLine().ToLower().Equals("yes"))
                {
                    Discount.ReportAfterDiscount();
                }
            }

            Console.WriteLine("Do you have A special Code try out !"); 
                Console.WriteLine("Enter UPC :");
                string upc = Console.ReadLine();
            Selective. Selective(upc);
           
         






        }
    }
}
