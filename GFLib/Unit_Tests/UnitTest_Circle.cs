using GFLib.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GFLib
{
    [TestClass]
    public class UnitTest_Circle
    {
        [TestMethod]
        public void Test_Area()
        {
            Circle c = new Circle(2);
            double expected = Math.PI * 2 * 2;
            double actual = c.Area;
            Console.WriteLine(c.Area);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Perimeter() 
        {
            Circle c = new Circle(2);
            double expected = 2 * Math.PI * 2;
            double actual = c.Perimeter;
            Console.WriteLine(c.Perimeter);
            Assert.AreEqual(expected, actual);
        }


    }
}