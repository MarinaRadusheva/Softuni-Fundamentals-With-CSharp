using System;

namespace _11_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multipl = int.Parse(Console.ReadLine());
            if (multipl <= 10)
            {
                for (int i = multipl; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
            else
            {
                Console.WriteLine($"{num} X {multipl} = {num * multipl}");
            }
        }
    }
}
