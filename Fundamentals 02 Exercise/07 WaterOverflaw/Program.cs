using System;

namespace _07_WaterOverflaw
{
    class Program
    {
        static void Main(string[] args)
        {
            byte rounds = byte.Parse(Console.ReadLine());
            var capacity = 255;
            for (int i = 0; i < rounds; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                if (litres > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= litres;
                }
            }
            Console.WriteLine(Math.Abs(capacity-255));
        }
    }
}
