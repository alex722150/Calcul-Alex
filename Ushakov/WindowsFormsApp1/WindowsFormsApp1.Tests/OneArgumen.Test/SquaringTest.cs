using System;
using WindowsFormsApp1;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.OneArgumen.Test
{
    [TestFixture]
    public class SquaringTest
    {
        [TestCase(4, 16)]
        [TestCase(2, 4)]
        public void SquaringTest2(double firstValue, double expected)
        {
            IOneArgumentCalculate calculator = new Squaring();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }

        [Test]
        public void SquaringTest2()
        {
            IOneArgumentCalculate calculator = new Squaring();
            Assert.Throws<Exception>(() => calculator.Calculate(12));
        }
    }
}

