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
    public class ItemTests
    {
        [TestMethod()]
        public void ItemNotNull()
        {
            // Arrange
            Price TestPrice = new Price(10.00);
            // Act 
            Item TestItem = new Item("SKU", TestPrice);
            // Assert
            Assert.IsNotNull(TestItem);
        }

        [TestMethod()]
        public void ItemVlaueCorrect()
        {
            // Arrange
            Price TestPrice = new Price(10.00);
            // Act 
            Item TestItem = new Item("SKU", TestPrice);
            // Assert
            Assert.AreEqual("SKU", TestItem.SKU);
            Assert.AreEqual(TestPrice, TestItem.Price);
        }

        [TestMethod()]
        public void ItemTypeCorrect()
        {
            // Arrange
            Price TestPrice = new Price(10.00);
            // Act 
            Item TestItem = new Item("SKU", TestPrice);
            // Assert
            Assert.IsInstanceOfType(TestItem, typeof(Item));
            Assert.IsInstanceOfType(TestItem.Price, typeof(Price));
        }
    }
}