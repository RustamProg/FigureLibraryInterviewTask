using FigureLibrary.Abstract;
using FigureLibrary.Figures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Tests
{
    [TestFixture]
    public class FiguresTest
    {
        private static readonly Triangle TestRectangularTriangle = new Triangle(100, 100, 100);
        private static readonly object[] TestMultipleTrianglesWithSquares = new object[]
        {
            new object[] { 97.4279, new Triangle(15, 15, 15) },
            new object[] { 34.2701, new Triangle(21, 10, 12) },
            new object[] { 1469.6938, new Triangle(50, 60, 70) }
        };
        private static readonly object[] TestMultipleCirclesWithSquares = new object[]
        {
            new object[] { 9503.3178, new Circle(55) },
            new object[] { 530.9292, new Circle(13) },
            new object[] { 5026.5482, new Circle(40) },
        };
        private static readonly object[] TestFiguresWithSquares = new object[]
        {
            new object[] { 3741.6574, new Triangle(90, 90, 100) },
            new object[] { 1583.2695, new Triangle(50, 100, 69) },
            new object[] { 3631.6811, new Circle(34) },
            new object[] { 1809.5574, new Circle(24) }
        };

        [Test]
        public void WrongTriangleThrowsException()
        {
            Assert.Throws<Exception>(() => new Triangle(27, 14, 12));
        }

        [Test]
        public void IsRectangularTriangle_Returns_True()
        {
            var actual = TestRectangularTriangle.IsRectangularTriangle();

            Assert.IsFalse(actual);
        }

        [TestCaseSource(nameof(TestMultipleTrianglesWithSquares))]
        public void TriangleSquares_Calculates_Right_Near_Values(double expectedNearResult, Triangle triangle)
        {
            AssertFigureWithItsSquare(expectedNearResult, triangle);
        }

        [TestCaseSource(nameof(TestMultipleCirclesWithSquares))]
        public void CircleSqaure_Calculates_Right_Near_Values(double expectedNearResult, Circle circle)
        {
            AssertFigureWithItsSquare(expectedNearResult, circle);
        }

        [TestCaseSource(nameof(TestFiguresWithSquares))]
        public void FigureSquares_Calculates_Right_Near_Values(double expectedNearResult, IFigure figure)
        {
            AssertFigureWithItsSquare(expectedNearResult, figure);
        }

        private void AssertFigureWithItsSquare(double expectedNearResult, IFigure circle)
        {
            var actualSquare = circle.CalculateSquare();

            Assert.AreEqual(expectedNearResult, actualSquare, 0.001);
        }
    }
}
