using FigureLibrary.Abstract;
using FigureLibrary.Figures;
using System;
using System.Collections.Generic;

namespace FigureClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangleOne = new Triangle(9, 10, 11);
            var trinagleTwo = new Triangle(30, 30, 30);
            var circle = new Circle(50);

            List<IFigure> figures = new List<IFigure> { triangleOne, trinagleTwo, circle };

            // Площадь в рантайме без знания типа фигуры
            Console.WriteLine("Calculating Squares:");
            figures.ForEach(fig => Console.WriteLine(fig.CalculateSquare()));

            // Для примера проверка - прямоугольный ли треуголник
            Console.WriteLine($"Is rectangular: {trinagleTwo.IsRectangularTriangle()}");
            Console.ReadKey();
        }
    }
}
