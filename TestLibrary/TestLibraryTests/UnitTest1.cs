using NUnit.Framework;
using System;
using TestLibrary;

namespace LibraryTests
{
    [TestFixture]
    public class CircleCalculatorTests
    {
        [Test]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            CircleCalculator calculator = new CircleCalculator();
            double radius = 5;

            // Act
            double area = calculator.CalculateArea(radius);

            // Assert
            Assert.That(Math.PI * Math.Pow(radius, 2), Is.EqualTo(area));
        }
    }

    [TestFixture]
    public class TriangleCalculatorTests
    {
        [Test]
        public void CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            TriangleCalculator calculator = new TriangleCalculator();
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            // Act
            double area = calculator.CalculateArea(side1, side2, side3);

            // Assert
            Assert.That(6, Is.EqualTo(area));

        }

        [Test]
        public void IsRightAngled_ValidSides_ReturnsTrue()
        {
            // Arrange
            TriangleCalculator calculator = new TriangleCalculator();
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            // Act
            bool isRightAngled = calculator.IsRightAngled(side1, side2, side3);

            // Assert
            Assert.That(isRightAngled, Is.True);
        }
    }
}
