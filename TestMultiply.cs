using CalculatorExample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Test
{
    
    public class TestMultiply
    {
        [Test]
        public void TestMultiplyTwoDoubleNumbers()
        {
           
            double number1 = -3.3847329; double number2 = -8.764832;
        double result = Program.Multiply(number1, number2);


        Assert.AreEqual(number1* number2, result);
            
        }
    }
}   


