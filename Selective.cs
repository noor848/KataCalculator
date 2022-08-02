using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public class Selective
    {
        public static void Selective(string upc)
        {
            List<Product> SpecificProduct = Stock.Items.Where(s => s.UPC.Equals(upc)).ToList();
            Product product = SpecificProduct.First();

            if (product.UPCDiscount(product.ProductPrice) == 0)
            {
                Console.WriteLine(" Not Special UPC ");
            }

            product.PriceAfterConfigureDiscount = product.ProductPrice - Discount.UniversalDiscountAmount(product.ProductPrice) -
                    product.UPCDiscount(product.ProductPrice) + Tax.TaxCalculation(product.ProductPrice);
            double TotalDiscount = Discount.UniversalDiscountAmount(product.ProductPrice) + product.UPCDiscount(product.ProductPrice);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"\n Product Name is {product.Name} and UPC {product.UPC}" +
                $" price reported as before tax {product.ProductPrice}{product.currencyOfProductSymbol} " +
                $"and {product.PriceAfterTax.ToString("0.00")}{product.currencyOfProductSymbol}\n after tax {Tax.TaxRate}%" +
                $"and discount {Discount.UniversalDiscountnumber}%" +
                $" and Product Price After discount is {product.PriceAfterDiscount.ToString("0.00")}{product.currencyOfProductSymbol}" +
                $"and specific discount {product.UPCDiscount(product.ProductPrice).ToString("0.00")}% and Product Price After discount {product.PriceAfterConfigureDiscount.ToString("0.00")}{product.currencyOfProductSymbol}\n" +
                $" Program reports total discount amount {TotalDiscount.ToString("0.00")}");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
