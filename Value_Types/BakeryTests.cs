using System;
using BakeryChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class BakeryTests
    {
        [TestMethod]
        public void ValueFromSwitchCorrect()
        {
            ProductRepository repo = new ProductRepository();
            Product bakedGood = new Product();
            BakeType product = BakeType.Bread;

            decimal actualCost = repo.CostOfCart(product);
            decimal expectedCost = 600.01m;

            Assert.AreEqual(actualCost, expectedCost);
        }
    }
}
