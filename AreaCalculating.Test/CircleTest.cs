using NUnit.Framework;

namespace AreaCalculating.Test
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void TestNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void TestZeroRadius() 
        {
            Assert.AreEqual(0, CalculateArea.GetArea(new Circle(0)));
        }

        [TestCase(1, Math.PI)]
        [TestCase(Math.PI, Math.PI * Math.PI * Math.PI)]
        [TestCase(100, 10000 * Math.PI)]
        public void TestCases(double radius, double expectedResult)
        {
            Assert.AreEqual(expectedResult, CalculateArea.GetArea(new Circle(radius)));
        }
    }
}