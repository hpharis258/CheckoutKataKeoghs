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
    public class PromotionTests
    {
        [TestMethod()]
        public void PromotionNotNull()
        {
            Promotion TestPromotion = new Promotion(5);
            Assert.IsNotNull(TestPromotion);
        }

        [TestMethod()]
        public void PromotionCorrectType()
        {
            Promotion TestPromotion = new Promotion(5);
            Assert.IsInstanceOfType(TestPromotion, typeof(Promotion));
        }
        [TestMethod()]
        public void PromotionCorrectValues()
        {
            Promotion TestPromotion = new Promotion(5, 10.00, 50.00);
            Assert.AreEqual(5, TestPromotion.Quantity);
            Assert.AreEqual(10.00, TestPromotion.Fixed_Price);
            Assert.AreEqual(50.00, TestPromotion.Percentage_Discount);
        }
    }
}