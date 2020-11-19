using System;

namespace _01_SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int maxNum = Math.Max(Math.Max(num1, num2), num3);
            int minNum = Math.Min(Math.Min(num1, num2), num3);
            int avNum = num1 + num2 + num3 - maxNum - minNum;
            Console.WriteLine(maxNum);
            Console.WriteLine(avNum);
            Console.WriteLine(minNum);
        }
    }
}
