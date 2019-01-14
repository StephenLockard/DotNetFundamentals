using System;
using Insurance_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class InsuranceChallengeTests
    {
        [TestMethod]
        public void Vehicle_ShouldHoldCorrectValues() /// test to ensure values are being held properly. 
        {
            Vehicle car = new Vehicle("Subaru", "Outback", 2019, "SUV", 4, false, 0); // Creates a 2019 Subaru Outback 4wheel SUV with 0 accidents and 0 previous owners. 

            // assigns a variable to each individual value held in our new vehicle, and then creates a new variable manually inputting what SHOULD match. 
            string actual = car.Make;
            string expected = "Subaru";

            string actualOne = car.Model;
            string expectedOne = "Outback";

            int actualTwo = car.Year;
            int expectedTwo = 2019;

            string actualThree = car.Type;
            string expectedThree = "SUV";

            int actualFour = car.NumberOfWheels;
            int expectedFour = 4;

            bool actualFive = car.InvolvedInCollision;
            bool expectedFive = false;

            int actualSix = car.PreviousOwners;
            int expectedSix = 0;

            // Assertions to run our equivalence checks. 
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);
            Assert.AreEqual(actualFive, expectedFive);
            Assert.AreEqual(actualSix, expectedSix);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            CarRepo repo = new CarRepo();
            Vehicle car = new Vehicle();
            car.Year = 2018;
            decimal testCost = repo.InsuranceCost(car);

            decimal actual = testCost;
            decimal expected = 200m;

            Assert.AreEqual(actual, expected);

        }


    }
}
