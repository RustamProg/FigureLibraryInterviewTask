using FigureLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FigureLibrary.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Строна А
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Строна B
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Строна C
        /// </summary>
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            CheckTriangleExists(sideA, sideB, sideC);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <inheritdoc />
        public double CalculateSquare()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        /// <summary>
        /// Является ли прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRectangularTriangle()
        {
            return CheckByPifagorExpression(SideA, SideB, SideC) 
                || CheckByPifagorExpression(SideB, SideC, SideA) 
                || CheckByPifagorExpression(SideC, SideB, SideA);
        }

        /// <summary>
        /// Проверка на соответствие равенству c2 = a2 + b2
        /// </summary>
        /// <param name="sideA">Строна </param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        private bool CheckByPifagorExpression(double sideA, double sideB, double sideC)
        {
            return (sideA * sideA) == (sideB * sideB + sideC * sideC);
        }

        /// <summary>
        /// Проверка на существование подобного треугольника
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void CheckTriangleExists(double sideA, double sideB, double sideC)
        {
            if (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideA + sideB)
            {
                throw new Exception($"Треугольник со стронами: {sideA}, {sideB}, {sideC} не может сущесвовать");
            }
        }
    }
}
