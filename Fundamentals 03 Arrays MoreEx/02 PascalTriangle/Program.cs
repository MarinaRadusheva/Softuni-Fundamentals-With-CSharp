using System;

namespace _02_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] initial = new int[] { 1 };
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(string.Join(" ",initial));
                int[] nextLine = new int[i + 1];
                nextLine[0] = 1;
                nextLine[nextLine.Length - 1] = 1;
                for (int j = 1; j < nextLine.Length-1; j++)
                {
                    nextLine[j] = initial[j - 1] + initial[j];
                }
                initial = nextLine;                
            }
        }
    }
}
