using System;

namespace _05_AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(SubtractTheThird(AddFirstTwo(first, second), third));
        }

        static int AddFirstTwo(int a, int b)
        {
            return a + b;
        }

        static int SubtractTheThird(int a, int b)
        {
            return a - b;
        }
    }
}
