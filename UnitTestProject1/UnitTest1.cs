using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanAddTwoNumbers()
        {
            //Setup
            var sums = new Sums();
            double magicNumber = 10;
            double amount = 10;
            double expected = 20;
            //Act
             var result = sums.add(magicNumber, amount);
            //Assert
             Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CanSubtractTwoNumbers()
        {
            //Setup
            var sums = new Sums();
            double magicNumber = 10;
            double amount = 10;
            double expected = 0;
            //Act
            var result = sums.subtract(magicNumber, amount);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CanMultiplyTwoNumbers()
        {
            //Setup
            var sums = new Sums();
            double magicNumber = 10;
            double amount = 10;
            double expected = 100;
            //Act
            var result = sums.multiply(magicNumber, amount);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CanDivideTwoNumbers()
        {
            //Setup
            var sums = new Sums();
            double magicNumber = 10;
            double amount = 10;
            double expected = 1;
            //Act
            var result = sums.divide(magicNumber, amount);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void OriginalStringMatchesSong()
        {
            //Setup
            var sums = new Sums();
            string expected = "99 bottles of beer on the wall, 99 bottles of beer.";
            //Act
            var result = Program.play2();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
