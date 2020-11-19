using System;

namespace _04_PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                PrintLine(1,i);
                Console.WriteLine();
            }
            for (int i = n-1; i >=1; i--)
            {
                PrintLine(1, i);
                Console.WriteLine();
            }

        }

        static void PrintLine(int start, int end)
        {
            for (int i = 1; i <=end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
