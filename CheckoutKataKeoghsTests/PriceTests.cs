using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutKataKeoghs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKataKeoghs.Tests
{
    [TestClass()]
    public class PriceTests
    {
        [TestMethod()]
        public void PriceTestNotNull()
        {
            Price NewPriceInstance = new Price(10.00);
            Assert.IsNotNull(NewPriceInstance);
        }

        [TestMethod()]
        public void PriceTestValueCorrect()
        {
            Price NewPriceInstance = new Price(10.00);
            double CorrectValue = 10.00;
            Assert.AreEqual(NewPriceInstance.Unit_Price, CorrectValue);

        }

        [TestMethod()]
        public void PriceTestTypeCorrect()
        {
            Price NewPriceInstance = new Price(10.00);
            Assert.IsInstanceOfType(NewPriceInstance, typeof(Price));

        }
    }
}