using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareAPI;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetRightTriangleSquareTest1()
        {
            SquareApi sa = new SquareApi();
            Assert.AreEqual(24, sa.GetRightTriangleSquare(10,8,6));
            Assert.AreEqual(44, sa.GetRightTriangleSquare(9, 11, 16));
        }

    }
}
