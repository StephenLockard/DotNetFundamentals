using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/* my first unit test
 * Also, testing multi-line comments */
namespace Value_Types
{
    [TestClass]
    public class Value_Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            char c = '!';

            bool isOn = false;
            bool isOff = true;

            long l = 98787;
            short sh = 32000;

            int intMin = -2147483648;
            int intMax = -2147483648;

            double doubleExample = 0.9998d;
            float floatExample = 1.9878f;
            decimal decimalExample = 234.123m;

            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1986, 5, 28);
        }

        [TestMethod]
        public void Declaration()
        {
            string name;
            int number;
            bool menuStateOn;
            decimal cashMoney;
        }

        [TestMethod]
        public void Declaration_Then_Initialization()
        {
            string name;
            int number;
            bool menuStateOn;
            decimal cashMoney;

            name = "Stephen";
            number = 2;
            cashMoney = 234.12m;
            menuStateOn = false;
        }
        [TestMethod]
        public void Declaration_And_Initialization()
        {
            string name = "Stephen";
            int number = 23;
            bool menuStateOn = true;
            decimal cashMoney = 4234.12m;
        }
    }
}
