using CalculatorExample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Test
{
    class TestSubtraction
    {
        [Test]
        [TestCase(4, 7)]
        [TestCase(6, 8)]
        [TestCase(5, 2)]

        public void TestSubtractTwoNumbers(double number1, double number2)
        {
            double result = Program.Subtract(number1, number2);
            Assert.AreEqual(number1-number2, result);
        }
    }
}
