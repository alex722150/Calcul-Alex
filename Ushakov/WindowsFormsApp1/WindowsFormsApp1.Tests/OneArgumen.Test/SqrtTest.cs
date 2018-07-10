using System;
using WindowsFormsApp1;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.OneArgumen.Test
{
    public class SqrtTest
    {
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        public void SqrtTest2(double firstValue, double expected)
        {
            IOneArgumentCalculate calculator = new Sqrt();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
        [Test]
        public void SqrtTest2()
        {
            IOneArgumentCalculate calculator = new Sqrt();
            Assert.Throws<Exception>(() => calculator.Calculate(12));
        }
    }
}