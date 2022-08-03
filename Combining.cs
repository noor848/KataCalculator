﻿using System;
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
            Console.WriteLine(" 0 - Additive discounts");
            Console.WriteLine(" 1 - Mltiplicative discounts");
            int Choice = Convert.ToInt16(Console.ReadLine());

            switch (Choice)
            {
                case 0:
                    Expenses.CombiningDiscountExpenses(upc);
                    break;
                case 1:
                    MultipliationDiscount(upc);
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Are you Satisfied ?");
            if (Console.ReadLine().ToLower().Equals("no"))
            {
                Console.Write("Enter Cap value:");
                double CapAmount = Convert.ToDouble(Console.ReadLine())/100;
                Cap.AddingCapDiscount(upc, CapAmount);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Great!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void MultipliationDiscount(string upc)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Product product = Stock.Items.First();

            Console.WriteLine("Do you Want To Transport?");
            if (Console.ReadLine().ToLower().Equals("yes"))
            {
                double PercentPackagingCost = .01;
                product.PackagingCost = PercentPackagingCost * product.ProductPrice;
                product.TransportCost = 2.2;
            }
            product.TaxAmount = Tax.TaxCalculation(product.ProductPrice);
            product.SecondDiscount=(product.ProductPrice- product.UniversalDiscountAmount(product.ProductPrice))*product.UPCdiscount/100;
            product.TotalDiscount = product.UniversalDiscountAmount(product.ProductPrice) + product.SecondDiscount;
            Report.ReportTotalExpenses(product);
        }
    }
    }
