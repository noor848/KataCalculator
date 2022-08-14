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
            if (currencyOfProductToLower(currencyOfProduct).Equals("us"))
            {
                return "$";
            }
             if (currencyOfProductToLower(currencyOfProduct).Equals("shekel"))
            {
                return "ILS";
            }
             if (currencyOfProductToLower(currencyOfProduct).Equals("jordan"))
            {
                return "JOD";
            }
                throw new Exception("Enter one of these types(US,Jordan,Shekel)\n TRY AGAIN !");
        }

        public static string currencyOfProductToLower(string currencyOfProduct) {
            return currencyOfProduct.ToLower();
        }
    }
}
