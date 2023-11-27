using System;

namespace TestLibrary
{
    public class CircleCalculator
    {
        public double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
    public class TriangleCalculator
    {
        public double CalculateArea(double side1, double side2, double side3)
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public bool IsRightAngled(double side1, double side2, double side3)
        {
            // Проверка на прямоугольность с использованием теоремы Пифагора
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}