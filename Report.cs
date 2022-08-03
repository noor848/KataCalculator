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
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in Stock.Items)
            {
                Console.WriteLine($"\n Product Name is {item.Name} and UPC {item.UPC} " +
                    $"price reported as before tax {item.ProductPrice}{item.currencyOfProductSymbol}" +
                    $" and {TwoDecimalPlaces(item.PriceAfterTax)}{item.currencyOfProductSymbol}" +
                    $" after tax {Tax.TaxRate}%\n");
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
                    $"and {TwoDecimalPlaces(product.PriceAfterTax)}{product.currencyOfProductSymbol} after tax {Tax.TaxRate}%" +
                    $"and discount {product.UniversalDiscountnumber}% and Product Price After discount is {TwoDecimalPlaces(product.PriceAfterDiscount)}{product.currencyOfProductSymbol}\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void ReportNoDiscount()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var product in Stock.Items)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n Product Name is {product.Name} and UPC {product.UPC}" +
                    $" price reported as before tax {product.ProductPrice}{product.currencyOfProductSymbol} " +
                    $"and {product.PriceAfterTax.ToString("0.00")}{product.currencyOfProductSymbol} after tax {Tax.TaxRate}%" +
                    $"and discount {product.UniversalDiscountnumber}% and No discount ! ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static void ReportPrintSelective(Product product)
        {
            product.PriceAfterConfigureDiscount = product.ProductPrice - product.UniversalDiscountAmount(product.ProductPrice) -
                  product.UPCDiscount(product.ProductPrice) + Tax.TaxCalculation(product.ProductPrice);

            product.TotalDiscount = product.UniversalDiscountAmount(product.ProductPrice) + product.UPCDiscount(product.ProductPrice);
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (product.UPCDiscount(product.ProductPrice) == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"\n Product Name is {product.Name} and UPC {product.UPC}" +
                $" price reported as before tax {product.ProductPrice}{product.currencyOfProductSymbol} " +
                $"and {TwoDecimalPlaces(product.PriceAfterTax)}{product.currencyOfProductSymbol}\n after tax {Tax.TaxRate}%" +
                $"and discount {product.UniversalDiscountnumber}%" +
                $" and Product Price After discount is {product.PriceAfterDiscount.ToString("0.00")}{product.currencyOfProductSymbol}" +
                $"and specific discount {product.UPCDiscount(product.ProductPrice).ToString("0.00")}% and Product Price After discount {product.PriceAfterConfigureDiscount.ToString("0.00")}{product.currencyOfProductSymbol}\n" +
                $" Program reports total discount amount {TwoDecimalPlaces(product.TotalDiscount)}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static string TwoDecimalPlaces(double text)
        {
            return text.ToString("0.00");
        }
        public static void ReportTotalExpenses(Product product)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Product Cost = {TwoDecimalPlaces(product.ProductPrice)}");
            Console.WriteLine($"Tax = {TwoDecimalPlaces(product.TaxAmount)}");
            Console.WriteLine($"Discounts = {TwoDecimalPlaces(product.TotalDiscount)}");
            Console.WriteLine($"Packaging = {TwoDecimalPlaces(product.PackagingCost)}");
            Console.WriteLine($"Transport = {TwoDecimalPlaces(product.TransportCost)}");
            product.TotalExpenses = product.ProductPrice + product.TaxAmount - product.TotalDiscount + product.PackagingCost + product.TransportCost;
            Console.WriteLine($"Total Expenses = {TwoDecimalPlaces(product.TotalExpenses)}");
            Console.WriteLine($"Program separately reports {TwoDecimalPlaces(product.TotalDiscount)}");
        }

    }
}

