using System;

namespace _02_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintClosestToCenterPoint(x1, x2, y1, y2);
        }
        static void PrintClosestToCenterPoint(double x1, double x2, double y1, double y2)
        {
            double hypotenuseSq = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double hypotenuseSq2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (hypotenuseSq>hypotenuseSq2)
            {
                Console.WriteLine($"({ x2}, { y2})");
            }
            else
            {
                Console.WriteLine($"({ x1}, { y1})");
            }
        }
    }
}
