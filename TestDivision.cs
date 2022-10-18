using CalculatorExample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Test
{
    class TestDivision
    {

        [Test]
        public void TestDivisionTwoDoubleNumbers()
        {

            double number1 = -3.3847329; double number2 = -8.764832;
            double result = Program.Division(number1, number2);
            Assert.AreEqual(number1 / number2, result);

        }

        [Test]
        public void TestDivisionTwoIntegereNumbers()
        {

            double number1 = 5; double number2 = 0;
            double result = Program.Division(number1, number2);
           Assert.Throws<DivideByZeroException>(() => { Program.Division(5, 0); });

        }
    }
}
