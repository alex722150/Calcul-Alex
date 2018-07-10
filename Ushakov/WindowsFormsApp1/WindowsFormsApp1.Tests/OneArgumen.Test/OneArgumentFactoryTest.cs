using System;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.OneArgumen.Test
{
    public class OneArgumentFactoryTest
    {
        [TestCase("Sqrt", typeof(Sqrt))]
        [TestCase("Squaring", typeof(Squaring))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

    }
}