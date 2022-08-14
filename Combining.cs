 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public class Combining
    {
        public static void ChoosingBetweenTwoDiscountMethods(string upc)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    Console.WriteLine(" 0 - Additive discounts");
                    Console.WriteLine(" 1 - Mltiplicative discounts");
                    int Choice = Convert.ToInt16(Console.ReadLine());

                    switch (Choice)
                    {
                        case 0:
                            CombiningDiscountExpenses(upc);
                            break;
                        case 1:
                            MultipliationDiscount(upc);
                            break; 
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Choice !");
                }
            }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Are you Satisfied ? (yes/no)");
                    if (Console.ReadLine()!.ToLower().Equals("no"))
            { 

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    try
                    {
                        Console.Write("Enter Cap value:");
                        string CapValue = Console.ReadLine()!;
                        double CapAmount = Convert.ToDouble(CapValue) / 100;
                        Cap.AddingCapDiscount(upc, CapAmount);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("CAP Value!");
                    }
                }
            }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Great!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
            }
        
        public static void MultipliationDiscount(string upc)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Product product = Stock.Items.First();

                Console.WriteLine("Do you Want To Transport? (yes/no)");
                if (Console.ReadLine()!.ToLower().Equals("yes"))
                {
                    Report.EnterPackigingAndTransport(product);
                }

                product.TaxAmount = Tax.TaxCalculation(product.ProductPrice);
                product.SecondDiscount = (product.ProductPrice - product.GetUniversalDiscountAmount(product.ProductPrice)) * product.UPCdiscount / 100;
                product.TotalDiscount = product.GetUniversalDiscountAmount(product.ProductPrice) + product.SecondDiscount;
                Report.ReportTotalExpenses(product);
            }


            public static void CombiningDiscountExpenses(string upc)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Product product = Product.GetProductWithSpecifiedUPC(upc);

                Console.WriteLine("Do you Want To Transport? (yes/no)");
                if (Console.ReadLine()!.ToLower().Equals("yes"))
                {
                    Report.EnterPackigingAndTransport(product);
                }
                product.TaxAmount = Tax.TaxCalculation(product.ProductPrice);
                product.TotalDiscount = product.GetUniversalDiscountAmount(product.ProductPrice) + product.UPCDiscount(product.ProductPrice);
                Report.ReportTotalExpenses(product);
            }
        
    }
    }

