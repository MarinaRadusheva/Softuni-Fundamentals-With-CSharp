using System;
using System.Linq;

namespace ConsoleApp1_ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            for (int i = 1; i <=n; i++)
            {
                int[] currentArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    first[i-1] = currentArr[0];
                    second[i-1] = currentArr[1];
                }
                else
                {
                    second[i-1] = currentArr[0];
                    first[i-1] = currentArr[1];
                }
            }
            Console.WriteLine(string.Join(' ',second));
            Console.WriteLine(string.Join(' ',first));
        }
    }
}
