using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculating.Test
{
    [TestFixture]
    class RectangleTests
    {
        [Test]
        public void TestNegativeSides()
        {
            Assert.Throws<ArgumentException>(() => 
                CalculateArea.GetArea(new Rectangle(1, -1)));
            Assert.Throws<ArgumentException>(() => 
                CalculateArea.GetArea(new Rectangle(-1, 1)));
            Assert.Throws<ArgumentException>(() => 
                CalculateArea.GetArea(new Rectangle(-1, -1)));
        }

        [TestCase(1, 0, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 7, 14)]
        [TestCase(8, 8, 64)]
        public void TestCases(double firstSide, double secondSide, double expectedResult)
        {
            Assert.AreEqual(expectedResult, CalculateArea.GetArea(
                new Rectangle(firstSide, secondSide)));
        }
    }
}
