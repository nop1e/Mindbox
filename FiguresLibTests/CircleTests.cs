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
    public class CircleTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            //Arrange
            double r = 5;
            double expected = 78.53981633974483;

            //Act
            Circle circle = new Circle(r);
            double actual = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void CirclePerimeterTest()
        {
            //Arrange
            double r = 5;
            double expected = 31.41592653589793;
                
            //Act
            Circle circle = new Circle(r);
            double actual = circle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }
    }
}