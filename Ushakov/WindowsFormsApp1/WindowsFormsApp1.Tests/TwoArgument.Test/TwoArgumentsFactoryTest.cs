using System;
using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;


    namespace WindowsFormsApp1.Tests.TwoArgument.Test
    {
        public class TwoArgumentsFactoryTest
        {
            [TestCase("Add", typeof(AddCalculator))]
            [TestCase("Divide", typeof(Divide))]
            [TestCase("Multiply", typeof(Multiplay))]
            [TestCase("Substract", typeof(Substract))]
            public void CalculateTest(string name, Type type)
            {
                var calculator = TwoArgumentFactory.CreateCalculator(name);
                Assert.IsInstanceOf(type, calculator);
            }

        }
    }
