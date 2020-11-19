using System;

namespace _05_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CostOfOrder(quantity, item);

        }

        static void CostOfOrder(int q, string item)
        {
            switch (item)
            {
                case "coffee":
                    Console.WriteLine($"{(double)q * 1.50:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(double)q * 1.40:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{(double)q * 1.00:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(double)q * 2.00:f2}");
                    break;
                default:
                    break;
            }
        }
    }
}
