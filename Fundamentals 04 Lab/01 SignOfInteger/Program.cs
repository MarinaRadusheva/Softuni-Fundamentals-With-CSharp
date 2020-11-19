using System;

namespace _01_SignOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SignOfInteger(n);
        }

        static void SignOfInteger(int n)
        {
            if (n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n==0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else if (n>0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
        }
    }
}
