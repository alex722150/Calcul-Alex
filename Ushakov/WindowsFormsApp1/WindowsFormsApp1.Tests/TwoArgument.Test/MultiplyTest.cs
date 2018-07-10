using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.TwoArgument.Test
{
    class MultiplyTest
    {
        [TestFixture]
        public class TestClass
        {
            [TestCase(0, 0, 0)]
            [TestCase(3, 4, 12)]
            [TestCase(-7, -2, 14)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Multiplay();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }
        }
    }

}
