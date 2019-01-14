using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThanksgivingConsole;

namespace Value_Types
{
    [TestClass]
    public class ThanksgivingTests
    {
        [TestMethod]
        public void Thanksgiving_Constructor_ShouldHoldCorrectValues()
        {
            Thanksgiving dinner = new Thanksgiving("Turkey", "Stuffing", "Cranberry Sauce", "Mashed Potatoes", true);

            bool actual = dinner.TurkeyIsDone;
            bool expected = true;

            string actualOne = dinner.FoodOne;
            string expectedOne = "Turkey";

            string actualTwo = dinner.FoodTwo;
            string expectedTwo = "Stuffing";

            string actualThree = dinner.FoodThree;
            string expectedThree = "Cranberry Sauce";

            string actualFour = dinner.FoodFour;
            string expectedFour = "Mashed Potatoes";

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);
        }
    }
}
