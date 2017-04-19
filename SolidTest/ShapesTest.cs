using Moq;
using NUnit.Framework;
using SolidPractice;
using System;

namespace SolidTest
{
    [TestFixture]
    public class ShapesTest
    {
        private Square _square;
        private Circle _circle;
        private Cube _cube;
        private Equilateral_Triangle _equilateral_triangle;

        [SetUp]
        public void Setup()
        {
            _square = new Square();
            _circle = new Circle();
            _cube = new Cube();
            _equilateral_triangle = new Equilateral_Triangle();
        }

        [TestCase(5,25.0)]
        [TestCase(6,36.0)]
        [TestCase(1,1.0)]
        public void GetArea_ShouldSquareValue(int width,double result)
        {
            _square.Width = width;
            Assert.That(_square.GetArea(), Is.EqualTo(result));
        }


        
        [TestCase(5, Math.PI * (5 / 2.0) * (5 / 2.0))]
        [TestCase(6, Math.PI * (36 / 2.0) * (36 / 2.0))]
        [TestCase(1, 0.78539816339744828)]
        public void GetArea_ShouldCircleValue(int width, double result)
        {
            _circle.Width = width;
            Assert.That(_circle.GetArea(), Is.EqualTo(result));
        }

        [TestCase(5, 150.0)]
        [TestCase(6, 216.0)]
        [TestCase(1, 6.0)]
        public void GetArea_ShouldCubeValue(int width, double result)
        {
            _cube.Width = width;
            Assert.That(_cube.GetArea(), Is.EqualTo(result));
        }


        [TestCase(5, 25.0)]
        [TestCase(6, 36.0)]
        [TestCase(1, 1.0)]
        public void GetArea_ShouldEquilateralTValue(int width, double result)
        {
            _equilateral_triangle.Width = width;
            Assert.That(_equilateral_triangle.GetArea(), Is.EqualTo(result));
        }

    }
}
