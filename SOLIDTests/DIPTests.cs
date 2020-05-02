using DIP;
using NUnit.Framework;
using static DIP.Operations;

namespace SOLID.Tests
{
    public class DIPTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Can_add_two_values()
        {
            // Arrange
            Calculator calculator = new Calculator(new AddCalculatorOperation());

            // Act
            double result = calculator.Solve(24, 3);

            // Assert
            Assert.AreEqual(result, 27);
        }

        [Test]
        public void Can_multiply_two_values()
        {
            // Arrange
            Calculator calculator = new Calculator(new MultiplyCalculatorOperation());

            // Act
            double result = calculator.Solve(24, 3);

            // Assert
            Assert.AreEqual(result, 72);
        }

        [Test]
        public void Can_subtract_two_values()
        {
            // Arrange
            Calculator calculator = new Calculator(new SubtractCalculatorOperation());

            // Act
            double result = calculator.Solve(24, 3);

            // Assert
            Assert.AreEqual(result, 21);
        }

        [Test]
        public void Can_divide_two_values()
        {
            // Arrange
            Calculator calculator = new Calculator(new DivideCalculatorOperation());

            // Act
            double result = calculator.Solve(24, 3);

            // Assert
            Assert.AreEqual(result, 8);
        }
    }
}