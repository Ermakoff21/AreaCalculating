using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculating.Test
{
    [TestFixture]
    class TriangleTest
    {
        [TestCase(1, 2, 3)]
        [TestCase(4, 1, 10)]
        [TestCase(5, 2, 10)]
        public void NonexistentTriangleTests(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<ArgumentException>(() => 
                CalculateArea.GetArea(new Triangle(firstSide, secondSide, thirdSide)));
        }

        [TestCase(-1, 3, 4)]
        [TestCase(1, -3, 6)]
        [TestCase(3, 6, -7)]
        [TestCase(-1, -1, -1)]
        public void NegativeSidesTests(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<ArgumentException>(() =>
                CalculateArea.GetArea(new Triangle(firstSide, secondSide, thirdSide)));
        }

        [TestCase(1, 1, 1, false)]
        [TestCase(3, 2, 3, false)]
        [TestCase(3, 4, 5, true)]
        [TestCase(6, 8 , 10, true)]
        [TestCase(5, 12, 13, true)]
        public void RightTriangleTests(double firstSide, double secondSide, 
            double thirdSide, bool result)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual(result, triangle.IsRightRectangle(triangle));
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 12, 13, 30)]
        [TestCase(7, 8, 9, 26.83)]
        [TestCase(8, 15, 17, 60)]
        [TestCase(9, 10, 17, 36)]
        [TestCase(1, 1, 1, 0.43)]
        public void TestCases(double firstSide, double secondSide,
            double thirdSide, double expectedResult)
        {
            var area = Math.Round(CalculateArea.GetArea(
                new Triangle(firstSide, secondSide, thirdSide)), 2);
            Assert.AreEqual(expectedResult, area);
        }
    }
}
