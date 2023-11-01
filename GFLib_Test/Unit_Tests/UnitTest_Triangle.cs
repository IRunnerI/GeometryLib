using GFLib.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GFLib_Test
{
    [TestClass]
    public class UnitTest_Triangle
    {
        [TestMethod]
        public void Test_Area() 
        {
            Triangle t = new Triangle(3, 4, 90);
            double expected = Math.Sqrt(6 * (6 - 3) * (6 - 4) * (6 - 5));
            double actual = t.Area;
            Console.WriteLine(t.Area);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Perimeter() 
        {
            Triangle t = new Triangle(3, 4, 90);
            double expected = 3 + 4 + 5;
            double actual = t.Perimeter;
            Console.WriteLine(t.Perimeter);
            Assert.AreEqual(expected, actual);
        }
    }
}