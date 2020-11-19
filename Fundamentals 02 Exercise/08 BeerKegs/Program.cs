using System;

namespace _08_BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string model = "";
            double volume = double.MinValue;
            
            for (byte i = 0; i < n; i++)
            {
                string currModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                if (volume < Math.PI * Math.Pow(radius,2) * height)
                {
                    volume = Math.PI * Math.Pow(radius, 2) * height;
                    model = currModel;
                }
            }
            Console.WriteLine(model);
        }
    }
}
