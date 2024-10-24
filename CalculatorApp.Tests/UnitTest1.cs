using NUnit.Framework;
using System;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        // “есты дл€ сложени€
        [Test]
        public void Addition_Test()
        {
            Assert.That(calculator.Add(2, 2), Is.EqualTo(4));
            Assert.That(calculator.Add(-1, 1), Is.EqualTo(0));
            Assert.That(calculator.Add(0, 0), Is.EqualTo(0));
        }

        [Test]//сложение с дробными числами (доп задание)
        public void Addition_With_Doubles_Returns_Correct_Result()
        {
            Assert.That(calculator.Add(1.5, 2.5), Is.EqualTo(4.0));
            Assert.That(calculator.Add(0.1, 0.2), Is.EqualTo(0.3).Within(0.0001));
        }

        // “есты дл€ вычитани€
        [Test]
        public void Subtraction_Test()
        {
            Assert.That(calculator.Subtract(5, 3), Is.EqualTo(2));
            Assert.That(calculator.Subtract(0, 4), Is.EqualTo(-4));
            Assert.That(calculator.Subtract(-2, -2), Is.EqualTo(0));
        }

        [Test]//вычитание с дробными числами (доп задание)
        public void Subtraction_With_Doubles_Returns_Correct_Result()
        {
            Assert.That(calculator.Subtract(5.5, 2.5), Is.EqualTo(3.0));
        }

        // “есты дл€ умножени€
        [Test]
        public void Multiplication_Test()
        {
            Assert.That(calculator.Multiply(3, 3), Is.EqualTo(9));
            Assert.That(calculator.Multiply(-2, 2), Is.EqualTo(-4));
            Assert.That(calculator.Multiply(0, 5), Is.EqualTo(0));
        }

        [Test]//умножение с дробными числами (доп задание)
        public void Multiplication_With_Doubles_Returns_Correct_Result()
        {
            Assert.That(calculator.Multiply(2.5, 2), Is.EqualTo(5.0));
        }

        // “есты дл€ делени€
        [Test]
        public void Division_Test()
        {
            Assert.That(calculator.Divide(10, 2), Is.EqualTo(5));
            Assert.That(calculator.Divide(5, -1), Is.EqualTo(-5));
            Assert.That(calculator.Divide(0, 3), Is.EqualTo(0));
        }

        [Test]//деление с дробными числами (доп задание)
        public void Division_With_Doubles_Returns_Correct_Result()
        {
            Assert.That(calculator.Divide(7.5, 2.5), Is.EqualTo(3.0));
        }

        [Test]//“ест деление на 0
        public void Division_By_Zero_Throws_Exception()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }

        
    }
}
