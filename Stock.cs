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
        public  void EnterProductDetails(int itemNumber)
        {
            int i = 0;
            while (i < itemNumber)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"\nProduct Num: #{i + 1}\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter Name of Product ");
                string? NameOfProduct = Console.ReadLine();

                Console.WriteLine("Enter 4 character of UPC of Product ");

                string ? UPC = Console.ReadLine();
                if(UPC!.Length<4 || UPC!.Length > 4 || UPC.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please check the Length of UPC\n TRY AGAIN!");
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Enter Price of Product ");
                double PriceOfProduct = Convert.ToDouble(Console.ReadLine());
                if (PriceOfProduct == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please check the Price of Product!");
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter Currency of Product (US,Jordan,Shekel)");
                string? currencyOfProduct = Console.ReadLine();
                try
                {
                    currencyOfProduct = Currency.CurrencyType(currencyOfProduct!);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter one of these types(US,Jordan,Shekel)\n TRY AGAIN !");
                    continue;
                }
                Items.Add(new Product(NameOfProduct!, UPC, PriceOfProduct, currencyOfProduct));
                i++;
            }



        }
   
    }
}
