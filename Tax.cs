
namespace Kata_Calculator
{
    public class Tax
    {
       public static double TaxRate { get; set; }
        public static double TaxCalculation(double price)
        {
            return (TaxRate*price/100);
        }
   
    }
}