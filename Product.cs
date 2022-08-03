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
        public string currencyOfProductSymbol { get; set; }
        public double PriceAfterConfigureDiscount { get; set; }
        public double UPCdiscount { get; set; } = 7;
        public double UniversalDiscountnumber { get; set; }
        public double RemainingPrice { get; set; }
        public double TaxAmount { get; set; }
        public double PackagingCost { get; set; }
        public double TransportCost { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalExpenses { get; set; }
        public double SecondDiscount { get; set; }
        public Product(string name, string upc, double price, string currency)
        {
            Name = name;
            UPC = upc;
            ProductPrice = price;
            PriceAfterTax = Tax.TaxCalculation(price)+price;
            currencyOfProductSymbol = currency;
        }
        public double UniversalDiscountAmount(double price)
        {
            return (UniversalDiscountnumber * price / 100);
        }
        public double UPCDiscount(double price)
        {
            if (Stock.SpecialUPC.Contains(UPC))
            {
                return (UPCdiscount / 100) * price;
            }
            return 0;
        }
        public static Product GetProductWithSpecifiedUPC(string upc)
        {
            Console.ForegroundColor = ConsoleColor.White;
            return Stock.Items.First();
        }
    }
}
