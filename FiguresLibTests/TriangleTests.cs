using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleAreaTest()
        {
            //Arrange
            double aSide = 3;
            double bSide = 4;
            double cSide = 5;
            double expected = 6;

            //Act
            Triangle triangle = new Triangle(aSide, bSide, cSide);
            double actual = triangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect.");
        }

        [TestMethod]
        public void TrianglePerimeterTest()
        {
            //Arrange
            double aSide = 3;
            double bSide = 4;
            double cSide = 5;
            double expected = 12;

            //Act
            Triangle triangle = new Triangle(aSide, bSide, cSide);
            double actual = triangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect.");
        }
    }
}
