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
    public class BasketTests
    {
        [TestMethod()]
        public void BasketNotNull()
        {
            Basket TestBasket = new Basket();
            Assert.IsNotNull(TestBasket);
        }

        [TestMethod()]
        public void BasketValueCorrect()
        {
            Price TestPrice = new Price(10.00);
            Item TestItem = new Item("TEST" ,TestPrice);
            Basket TestBasket = new Basket();
            TestBasket.AddItem(TestItem);
            Assert.AreEqual(TestItem, TestBasket.SelectedItems[0]);
        }

        [TestMethod()]
        public void BasketTypeCorrect()
        {
            Basket TestBasket = new Basket();
            Assert.IsInstanceOfType(TestBasket, typeof(Basket));
        }

        [TestMethod()]
        public void SelectedItemCountTest()
        {
            Price TestPrice = new Price(10.00);
            Item TestItem = new Item("TEST", TestPrice);
            Basket TestBasket = new Basket();
            TestBasket.AddItem(TestItem);
            Assert.AreEqual(1, TestBasket.Count);
        }
    }
}