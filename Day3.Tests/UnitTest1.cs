using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void squareComputesCorrectly()
        {
            var sut = new square(5, 3);
            Assert.AreEqual(sut.height, 5);
            Assert.AreEqual(sut.width, 3);

            Assert.AreEqual(sut.Area(), 15);
        }

        [TestMethod]
        public void circleComputesCorrectly()
        {
            var sut = new circle(5);
            Assert.AreEqual(sut.radius, 5);
            Assert.AreEqual(sut.diameter, 10);
            //third parameter is delta tolerance
            Assert.AreEqual(sut.Area(), 78.54, 0.01);
            //Assert.
        }

        [TestMethod]
        public void shapeComputesCorrectly()
        {
            var sut = new shape();
            Assert.AreEqual(sut.height, 0);
            Assert.AreEqual(sut.width, 0);
            Assert.AreEqual(sut.radius, 0);
            Assert.AreEqual(sut.Area(), 0);

        }


    }
}
