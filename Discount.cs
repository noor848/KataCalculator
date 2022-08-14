using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator
{
    public static class Discount
    {
        public static void ApplyDiscountToAllProduct(double UniversalDiscount)
        {
            foreach (Product product in Stock.Items)
            {
                product.UniversalDiscountnumber = UniversalDiscount;
                product.PriceAfterDiscount = Math.Abs(product.GetUniversalDiscountAmount(product.ProductPrice) - product.PriceAfterTax);
            }
        }
        public static void ApplyDiscountToAllProductAnswerIsNo()
        {
            foreach (Product product in Stock.Items)
                {
                product.PriceAfterDiscount = product.ProductPrice;
                }
        }
    }
}
