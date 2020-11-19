using System;

namespace _03_RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n==1)
            {
                Console.WriteLine(1);
                return;
            }
            int a = 0;
            int b = 1;
            int sum = 0;
            for (int i = 0; i < n-1; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            Console.WriteLine(sum);
        }
    }
}
