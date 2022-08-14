using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public class Cap
    {
        public  static void AddingCapDiscount(string upc,double CapAmount)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Product product = Product.GetProductWithSpecifiedUPC(upc);
            double CapCalculationAMount = product.ProductPrice * CapAmount;
            if (product.TotalDiscount > CapCalculationAMount)
            {
                product.TotalDiscount = CapCalculationAMount;
            }
            Report.ReportTotalExpensesAfterCAPDiscount(product);
        }
    }
}
