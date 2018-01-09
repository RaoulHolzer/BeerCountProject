using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeerCountProject.Console.Test
{
    [TestClass]
    public class BeerTest
    {
        [TestMethod]
        public void Beer_DrinkOne_BillIsOneTimePrice()
        {
            decimal price = 1.5M;
            var sut = new Beer(price);
            sut.Drink();
            Assert.AreEqual(price, sut.Bill);
        }
        [TestMethod]
        public void Beer_DrinkTwoTimes_BillIsTwoPrice()
        {
            // Arrange
            decimal price = 1.5M;
            var sut = new Beer(price);
            // Act
            sut.Drink();
            sut.Drink();
            // Assert
            Assert.AreEqual(price*2, sut.Bill);

        }
    }
}
