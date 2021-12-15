using FigureLibrary.Abstract;
using System;

namespace FigureLibrary.Figures
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <inheritdoc />
        public double CalculateSquare()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
