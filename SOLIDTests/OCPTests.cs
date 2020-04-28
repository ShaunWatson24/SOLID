using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using NUnit.Framework;
using OCP;

namespace SOLID.Tests
{
    public class OCPTests
    {
        private AreaCalculator _areaCalc;

        [SetUp]
        public void Setup()
        {
            _areaCalc = new AreaCalculator();
        }

        [Test]
        public void Can_calculate_area_of_circle()
        {
            // Arrange
            var circle = new Circle
            {
                Radius = 300
            };

            // Act
            var area = circle.Area();

            // Assert
            Assert.AreEqual(282743.33, Math.Truncate(area * 100) / 100);
        }

        [Test]
        public void Can_calculate_area_of_rectangle()
        {
            // Arrange
            var rectangle = new Rectangle
            {
                Height = 100,
                Width = 200
            };

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(20000.0d, Math.Truncate(area * 100) / 100);
        }

        [Test]
        public void Can_calculate_area_of_collection_of_shapes()
        {
            // Arrange
            var shapes = new Shape[] { new Rectangle { Height = 10, Width = 4 }, new Circle { Radius = 10 } };

            // Act
            var areas = _areaCalc.Area(shapes);

            // Assert
            Assert.AreEqual(354.15, Math.Truncate(areas * 100) / 100);
        }
    }
}