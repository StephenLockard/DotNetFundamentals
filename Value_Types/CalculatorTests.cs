using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Repository;

namespace Value_Types
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculator_AdditionResult_CorrectValue()
        {
            Calculator calculator = new Calculator();

            double actualOne = calculator.additionResult(2, 2);
            double expectedOne = 2;

            double actualTwo = calculator.subtractionResult(2, 0);
            double expectedTwo = 2;

            double actualThree = calculator.divisionResult(2, 2);
            double expectedThree = 1;

            double actualFour = calculator.multiplicationResult(2, 2);
            double expectedFour = 4;

            double actualFive = calculator.modulusResult(10, 11);
            double expectedFive = 10;

            double actualSix = calculator.exponentResult(2, 2);
            double expectedSix = 4;

            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);
            Assert.AreEqual(actualFive, expectedFive);
            Assert.AreEqual(actualSix, expectedSix);

        }
    }
}
