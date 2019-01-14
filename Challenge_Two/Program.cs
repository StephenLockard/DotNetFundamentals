using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceAfterTax = TotalAfterTax(450, 0.07);
            Console.WriteLine(priceAfterTax);
        }

        public static double TotalAfterTax(double saleTotal, double taxRate)
        {
            double result = saleTotal * 1 + (taxRate);
            return result;
        }
    }
}
