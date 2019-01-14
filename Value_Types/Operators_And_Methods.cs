using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class Operators_And_Methods
    {
        [TestMethod]
        public void UsingOperators()
        {
            int addition = 10;
            int additionTwo = 10;
            int a = addition + additionTwo;
            Assert.AreEqual(20, a);

            int subtraction = 40;
            int subtractionTwo = 20;
            int b = subtraction - subtractionTwo;
            Assert.AreEqual(20, b);

            int multiple = 5;
            int multipleTwo = 4;
            int c = multiple * multipleTwo;
            Assert.AreEqual(20, c);

            int divisor = 20;
            int divisorTwo = 1;
            int d = divisor / divisorTwo;
            Assert.AreEqual(20, d);

            int modulus = 20;
            int modulusTwo = 21;
            int e = modulus % modulusTwo;
            Assert.AreEqual(20, e);

            int power = 2;
            int power2 = 4;
            double f = Math.Pow(power, power2);
            Assert.AreEqual(16, f);
        }
        
        [TestMethod]
        public void UsingAMethod()
        {
            int addition = 10;
            int additionTwo = 10;
            int additionResult = AddTwoNumbers(addition, additionTwo);
            Assert.AreEqual(20, additionResult);


            int subtraction = 40;
            int subtractionTwo = 20;
            int subtractionResult = SubtractTwoNumbers(subtraction, subtractionTwo);
            Assert.AreEqual(20, subtractionResult);

            int divisor = 20;
            int divisorTwo = 1;
            int divisionResult = DivideTwoNumbers(divisor, divisorTwo);
            Assert.AreEqual(20, divisionResult);

            int multiple = 5;
            int multipleTwo = 4;
            int multiplicationResults = MultiplyTwoNumbers(multiple, multipleTwo);
            Assert.AreEqual(20, multiplicationResults);

            int modulus = 20;
            int modulusTwo = 21;
            int modulusResult = ModulusOfTwoNumbers(modulus, modulusTwo);
            Assert.AreEqual(20, modulusResult);

            double exponent = 2;
            double exponentTwo = 4;
            double exponentResult = Math.Pow(exponent, exponentTwo);
            Assert.AreEqual(16, exponentResult);

        }

        private int AddTwoNumbers(int first, int second)
        {
            int result = first + second;
            return result;
        }

        private int SubtractTwoNumbers(int first, int second)
        {
            int result = first - second;
            return result;
        }

        private int DivideTwoNumbers(int first, int second)
        {
            int result = first / second;
            return result;
        }

        private int MultiplyTwoNumbers(int first, int second)
        {
            int result = first * second;
            return result;
        }

        private int ModulusOfTwoNumbers(int first, int second)
        {
            int result = first % second;
            return result;
        }

        private double ExponentOfTwoNumbers(double first, double second)
        {
            double result = Math.Pow(first, second);
            return result;
        }
    }
}
