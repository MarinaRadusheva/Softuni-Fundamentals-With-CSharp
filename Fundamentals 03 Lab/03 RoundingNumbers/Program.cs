using System;

namespace _03_RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split();
            double[] arr = new double[items.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(items[i]);
                Console.WriteLine($"{(decimal)arr[i]} => {(decimal)Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
