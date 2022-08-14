using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public class Stock
    {
        public  static List<Product> Items;
        public static List<string> SpecialUPC;
        public Stock()
        {
            Items = new List<Product>();
            SpecialUPC = new List<string>(){"1111","2222","3333"};
        }
        public void EnterProductDetails(int itemNumber)
        {
            int i = 0;
            while (i < itemNumber)
            {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\nProduct Num: #{i + 1}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter Name of Product ");
                    string? NameOfProduct = Console.ReadLine();

                string? UPC = "";
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Enter 4 character of UPC of Product ");
                    UPC=Console.ReadLine();
                    if (UPC!.Length < 4 || UPC!.Length > 4 || UPC.Length == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please check the Length of UPC\n TRY AGAIN!");
                        continue;
                    }
                    break;
                }

                double PriceOfProduct = 0;

                while (true)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Enter Price of Product ");
                        string? ReadingProductPrice = Console.ReadLine();
                        PriceOfProduct = Convert.ToDouble(ReadingProductPrice);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please check the Price of Product!");
                    }
                }

                string? currencyOfProduct = "";
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter Currency of Product (US,Jordan,Shekel)");
                    currencyOfProduct = Console.ReadLine();
                    try
                    {
                        currencyOfProduct = Currency.CurrencyType(currencyOfProduct!);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Enter one of these types(US,Jordan,Shekel)!");
                    }
                }

                Items.Add(new Product(NameOfProduct!, UPC, PriceOfProduct, currencyOfProduct));
                    
                i++;
                }
            ChangeEacProductDataToFourDecimalPlaces(Items!);
            } 
        public static void ChangeToFourDecimaPlaces(Product product)
        {
            product.TotalDiscount=Report.FourDecimalPlaces(product.TotalDiscount);
            product.ProductPrice = Report.FourDecimalPlaces(product.ProductPrice);
            product.PriceAfterTax = Report.FourDecimalPlaces(product.PriceAfterTax);
            product.PriceAfterDiscount = Report.FourDecimalPlaces(product.PriceAfterDiscount);
            product.PriceAfterConfigureDiscount = Report.FourDecimalPlaces(product.PriceAfterConfigureDiscount);
            product.UPCdiscount = Report.FourDecimalPlaces(product.UPCdiscount);
            product.UniversalDiscountnumber = Report.FourDecimalPlaces(product.UniversalDiscountnumber);
            product.RemainingPrice = Report.FourDecimalPlaces(product.RemainingPrice);
            product.TaxAmount = Report.FourDecimalPlaces(product.TaxAmount);
            product.PackagingCost = Report.FourDecimalPlaces(product.PackagingCost);
            product.TransportCost = Report.FourDecimalPlaces(product.TransportCost);
            product.TotalExpenses = Report.FourDecimalPlaces(product.TotalExpenses);
            product.SecondDiscount = Report.FourDecimalPlaces(product.SecondDiscount);
        }


        public static void ChangeEacProductDataToFourDecimalPlaces(List<Product> ProductList)
        {
            foreach (var item in ProductList)
            {
                Stock.ChangeToFourDecimaPlaces(item);
            }
        }
    }
}
