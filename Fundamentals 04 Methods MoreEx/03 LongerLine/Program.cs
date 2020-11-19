using System;

namespace _03_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double firstLine = FindLineLength(x2, x1, y2, y1);
            double secondLine = FindLineLength(x4, x3, y4, y3);
            if (firstLine>=secondLine)
            {
                PrintPointsStartingWithClosest(x1, x2, y1, y2);
            }
            else
            {
                PrintPointsStartingWithClosest(x3, x4, y3, y4);
            }

        }
        static  double FindLineLength(double x2, double x1, double y2, double y1)
        {
            double distanceSq = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distanceSq;
        }

        static void PrintPointsStartingWithClosest(double x1, double x2, double y1, double y2)
        {
            double hypotenuseSq = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double hypotenuseSq2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (hypotenuseSq > hypotenuseSq2)
            {
                Console.WriteLine($"({ x2}, { y2})({ x1}, { y1})");
            }
            else
            {
                Console.WriteLine($"({ x1}, { y1})({ x2}, { y2})");
            }
        }
    }
}
