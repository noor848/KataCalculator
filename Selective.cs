using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public class Selective
    {
        public static void selective(string upc)
        {
            Product product = Product.GetProductWithSpecifiedUPC(upc);
            if (product.UPCDiscount(product.ProductPrice) == 0)
            {
                Console.Write("\n Not Special UPC\n");
            }
            Report.ReportPrintSelective(product);
        }
    }
}
