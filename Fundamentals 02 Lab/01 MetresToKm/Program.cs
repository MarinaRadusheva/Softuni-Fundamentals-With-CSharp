using System;

namespace _01_MetresToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            double km = 0.001*metres;
            Console.WriteLine($"{km:f2}");
        }
    }
}
