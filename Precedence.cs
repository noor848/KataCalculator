using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public class Precedence
    {
        public static void preceding(string upc)
        {
            Product product = Product.GetProductWithSpecifiedUPC(upc);
            product.RemainingPrice = product.ProductPrice - product.UPCDiscount(product.ProductPrice);
            product.TaxAmount = ((product.RemainingPrice * Tax.TaxRate)/100);
            double FinalProduct = product.RemainingPrice + product.TaxAmount - product.UniversalDiscountAmount(product.RemainingPrice);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Report.TwoDecimalPlaces(FinalProduct));
            Console.WriteLine($"Program Reports Total Discount Amount For " +
                $"UPC = {upc} Is { Report.TwoDecimalPlaces(product.UniversalDiscountAmount(product.RemainingPrice)+ product.UPCDiscount(product.ProductPrice))}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
