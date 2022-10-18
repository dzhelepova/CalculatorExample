using CalculatorExample;
using NUnit.Framework;

namespace Calculator.Test
{
    public class TestsAddition
    {

        [Test]
        public void TestAdditionOfTwoPositiveIntegerNumbers()
        {
            //Arrange
            int number1 = 2, number2 = 145;

            //Act
            double result = Program.Add(number1, number2);

            //Assert
            Assert.AreEqual(147, result);

        }
        [Test]
        public void TestAdditionTwoPositiveDoubleNumbers()
        {
            //Arrange
            double number1 = 4.5643, number2 = 2.345523;

            //Act
            double result = Program.Add(number1, number2);

            //Assert
            Assert.AreEqual(6.909823, result);

        }
        [Test]
        public void TestAdditionTwoNegativeAndPositiveNumbers()
        {
            //Arrange
            double number1 = -4.9868468236746, number2 = 0.345523;

            //Act
            double result = Program.Add(number1, number2);

            //Assert
            Assert.AreEqual(-4.6413238236746, result);
        }
        [Test]
        public void TestAdditionTwoNegativeNumbers()
        {
            //Arrange
            double number1 = -8, number2 = -12;

            //Act
            double result = Program.Add(number1, number2);

            //Assert
            Assert.AreEqual(-20, result);
        }
     


    }
}