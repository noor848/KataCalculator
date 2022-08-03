using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Calculator 
{
    public class Currency
    {
        public static string CurrencyType(string currencyOfProduct)
        { 
            if (currencyOfProduct.ToLower().Equals("us"))
            {
                return "$";
            }
            else if (currencyOfProduct.ToLower().Equals("shekel"))
            {
                Console.WriteLine();
                return "ILS";
            }
            else if (currencyOfProduct.ToLower().Equals("jordan"))
            {
                return "JOD";
            }
            else
            {
                throw new Exception();
            }
        }

    }
}
