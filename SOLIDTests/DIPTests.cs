using DIP;
using NUnit.Framework;

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
            Assert.AreEqual(27, result);
        }

        [Test]
        public void Can_multiply_two_values()
        {
            // Arrange
            Calculator calculator = new Calculator(new MultiplyCalculatorOperation());

            // Act
            double result = calculator.Solve(24, 3);

            // Assert
            Assert.AreEqual(72, result);
        }

        [Test]
        public void Can_subtract_two_values()
        {
            // Arrange
            Calculator calculator = new Calculator(new SubtractCalculatorOperation());

            // Act
            double result = calculator.Solve(24, 3);

            // Assert
            Assert.AreEqual(21, result);
        }

        [Test]
        public void Can_divide_two_values()
        {
            // Arrange
            Calculator calculator = new Calculator(new DivideCalculatorOperation());

            // Act
            double result = calculator.Solve(24, 3);

            // Assert
            Assert.AreEqual(8, result);
        }
    }
}