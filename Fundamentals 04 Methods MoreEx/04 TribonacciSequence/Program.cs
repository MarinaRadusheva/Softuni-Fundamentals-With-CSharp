using System;

namespace _04_TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTribonacciSequence(n);
        }

        static void PrintTribonacciSequence(int n)
        {
            int[] fibonacciN = new int[n];
            fibonacciN[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (i==1)
                {
                    fibonacciN[i] = 1;
                }
                else if (i==2)
                {
                    fibonacciN[i] = 2;
                }
                else
                {
                    fibonacciN[i] = fibonacciN[i - 1] + fibonacciN[i - 2] + fibonacciN[i - 3];
                }
                    
                                
            }
            Console.WriteLine(string.Join(" ",fibonacciN));
        }
    }
}
