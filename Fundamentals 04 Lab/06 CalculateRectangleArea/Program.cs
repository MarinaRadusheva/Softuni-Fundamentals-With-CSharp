using System;

namespace _06_CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateRectangleArea(width, height);
            Console.WriteLine(area);
        }

        static double CalculateRectangleArea(double a, double b)
        {
            return a * b;
        }

    }
}
