using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using GFLib.Classes;

namespace GFLib_Test
{
    [TestClass]
    public class UnitTest_Calculate
    {
        [TestMethod]
        public void Test_Area_Circle() 
        {
            double expected = Math.PI * 2 * 2;
            double actual = Сalculate.AreaCircle(2);
            Console.WriteLine(Сalculate.AreaCircle(2));
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void Test_Perimeter_Circle() 
        {
            double expected = 2 * Math.PI * 2;
            double actual = Сalculate.PerimeterCircle(2);
            Console.WriteLine(Сalculate.PerimeterCircle(2));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Area_Triangle()
        {
            double expected = Math.Sqrt(6 * (6 - 3) * (6 - 4) * (6 - 5));
            double actual = Сalculate.AreaTriangle(3, 4, 90);
            Console.WriteLine(Сalculate.AreaTriangle(3,4,90));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Perimeter_Triangle() 
        {
            double expected = 3 + 4 + 5;
            double actual = Сalculate.PerimeterTriangle(3, 4, 90);
            Console.WriteLine(Сalculate.PerimeterTriangle(4, 3, 90));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_ToRadians() 
        {
            double expected = 90 * Math.PI / 180.0;
            double actual = Сalculate.ToRadians(90);
            Console.WriteLine(Сalculate.ToRadians(90));
            Assert.AreEqual(expected, actual);
        }
    }
       
    
}