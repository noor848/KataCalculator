using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{

    public class Product
    {
        public string Name { get; set; }
        public string UPC { get; set; }
        public double ProductPrice { get; set; }
        public double PriceAfterTax { get; set; }
        public double PriceAfterDiscount { get; set; }
        public  string currencyOfProductSymbol { get; set; }
        public  double PriceAfterConfigureDiscount { get; set; }
        public double UPCdiscount { get; set; } = 7;

        public Product(string name, string upc, double price, string currency)
        {
            Name = name;
            UPC = upc;
            ProductPrice = price;
            PriceAfterTax = Tax.TaxCalculation(price)+price;
            currencyOfProductSymbol = currency;
        }
        public double UPCDiscount(double price)
        {
            if (Stock.SpecialUPC.Contains(UPC))
            {
                return (UPCdiscount / 100) * price;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            return 0;
        }
    }
}
