using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoordinateAreaCalculationProblem
{
    [TestClass]
    public class CoordinateAreaCalculation
    {
        [TestMethod]
        public void TestCoordinateAreaCalculation()
        {
            Assert.AreEqual(18, AreaCalculation(p1,p2,p3), 0.01);
        }
        public struct point
        {
            public double coordX;
            public double coordY;
            public point (double x, double y)
            {
                coordX = x;
                coordY = y;
            }
        }

        point p1 = new point(2, 2);
        point p2 = new point(4, 10);
        point p3 = new point(8, 8);

        public static double AreaCalculation(point p1, point p2, point p3)
        {
            double area = -(p1.coordX * p2.coordY - p1.coordX * p3.coordY + p2.coordX * p3.coordY - p2.coordX * p1.coordY + p3.coordX * p1.coordY - p3.coordX * p2.coordY ) / 2;
            return area;
        }
    }
}