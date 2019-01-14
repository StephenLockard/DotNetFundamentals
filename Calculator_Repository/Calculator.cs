using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Repository
{
    public class Calculator
    {
        public  double additionResult(double num1, double num2)
        {
            double total;
            total = num1 + num2;
            return total;
        }

        public double subtractionResult(double num1, double num2)
        {
            double total;
            total = num1 - num2;
            return total;
        }

        public double multiplicationResult(double num1, double num2)
        {
            double total;
            total = num1 * num2;
            return total;
        }

        public double divisionResult(double num1, double num2)
        {
            double total;
            total = num1 / num2;
            return total;
        }

        public double modulusResult(double num1, double num2)
        {
            double total;
            total = num1 % num2;
            return total;
        }

        public double exponentResult(double num1, double num2)
        {
            double total;
            total = Math.Pow(num1, num2);
            return total;
        }
    }
}
