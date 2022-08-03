using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public  class Expenses
    {
        public static void TotalExpenses(string upc)
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
            Report.ReportTotalExpenses(product);
        }

    }
}
