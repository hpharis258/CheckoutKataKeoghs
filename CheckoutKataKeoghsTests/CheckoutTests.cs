using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutKataKeoghs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckoutKataKeoghs.Tests
{
    [TestClass()]
    public class CheckoutTests
    {
        [TestMethod()]
        public void CheckoutNotNull()
        {
            Dictionary<string, Promotion> keyValuePairs = new Dictionary<string, Promotion>();
            List<Item> items = new List<Item>();
            Basket basket = new Basket();
            ActivePromotions activePromotions = new ActivePromotions(keyValuePairs);
            Checkout TestCheckout = new Checkout(items, basket, activePromotions);
            Assert.IsNotNull(TestCheckout);
        }

        [TestMethod()]
        public void CheckoutCorrectType()
        {
            Dictionary<string, Promotion> keyValuePairs = new Dictionary<string, Promotion>();
            List<Item> items = new List<Item>();
            Basket basket = new Basket();
            ActivePromotions activePromotions = new ActivePromotions(keyValuePairs);
            Checkout TestCheckout = new Checkout(items, basket, activePromotions);
            Assert.IsInstanceOfType(TestCheckout, typeof(Checkout));
        }

        [TestMethod()]
        public void CheckoutCalculateTotalNoDiscount()
        {
            Promotion TestPromotion = new Promotion(3, 40);
            Dictionary<string, Promotion> keyValuePairs = new Dictionary<string, Promotion>();
            keyValuePairs.Add("SKU", TestPromotion);
            List<Item> items = new List<Item>();
            Item A = new Item("A", new Price(10.00));
            Item B = new Item("B", new Price(15.00));
            Basket basket = new Basket();
            basket.AddItem(A);
            basket.AddItem(B);
            ActivePromotions activePromotions = new ActivePromotions(keyValuePairs);
            Checkout TestCheckout = new Checkout(items, basket, activePromotions);
            Double Total = TestCheckout.Calculate_Total();
            Assert.AreEqual(25.00, Total);
        }
    }
}