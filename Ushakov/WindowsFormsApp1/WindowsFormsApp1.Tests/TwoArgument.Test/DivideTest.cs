using System;
using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;



namespace WindowsFormsApp1.Tests.TwoArgument.Test
{
    [TestFixture]
    public class DivideTest

    {
        [TestCase(8, 2, 4)]
        [TestCase(8, 4, 2)]
        [TestCase(14, -7, -2)]
        public void CalculateDivide(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculate calculator = new Divide();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void CalculateDivide2()
        {
            ITwoArgumentsCalculate calculator = TwoArgumentFactory.CreateCalculator("Divide");
            Assert.Throws<Exception>(() => calculator.Calculate(7, 0));
        }
    }
}