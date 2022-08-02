using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public class Report
    {
        public static void ReportBeforeDiscount()
        {
            string PriceSymbole = "";
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var item in Stock.Items)
            {
                Console.WriteLine($"\n Product Name is {item.Name} and UPC {item.UPC} price reported as before tax {item.ProductPrice}{item.currencyOfProductSymbol} and {item.PriceAfterTax.ToString("0.00")}{item.currencyOfProductSymbol} after tax {Tax.TaxRate}%");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static void ReportAfterDiscount()
        {
            foreach (Product product in Stock.Items)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n Product Name is {product.Name} and UPC {product.UPC}" +
                    $" price reported as before tax {product.ProductPrice}{product.currencyOfProductSymbol} " +
                    $"and {product.PriceAfterTax.ToString("0.00")}{product.currencyOfProductSymbol} after tax {Tax.TaxRate}%" +
                    $"and discount {UniversalDiscountnumber}% and Product Price After discount is {product.PriceAfterDiscount.ToString("0.00") ?? "no discount"}{product.currencyOfProductSymbol}");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

    }
}
