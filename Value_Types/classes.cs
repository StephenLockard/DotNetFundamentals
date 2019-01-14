using DotNet_Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    class classes
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Cookie chineseCookie = new Cookie();
            chineseCookie.Name = "Almond";
            chineseCookie.batchSize = 18;
            chineseCookie.HasRaisins = false;

            Cookie choco = new Cookie();
            choco.Name = "Chocolate Chip";
            choco.batchSize = 18;
            choco.HasRaisins = false;

            Cookie raisin = new Cookie();
            raisin.Name = "Raisin";
            raisin.batchSize = 12;
            raisin.HasRaisins = true;

            Assert.AreEqual("Almond", chineseCookie.Name);
            Assert.AreEqual(18, chineseCookie.batchSize);
            Assert.AreEqual(false, chineseCookie.HasRaisins);

            Assert.AreEqual("Chocolate Chip", choco.Name);
            Assert.AreEqual(18, choco.batchSize);
            Assert.AreEqual(false, choco.HasRaisins);

            Assert.AreEqual("Raisin", raisin.Name);
            Assert.AreEqual(12, raisin.batchSize);
            Assert.AreEqual(true, raisin.HasRaisins);

        }
    }
}
