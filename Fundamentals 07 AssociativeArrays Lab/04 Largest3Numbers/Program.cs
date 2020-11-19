using System;
using System.Linq;

namespace _04_Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] sorted = input.OrderByDescending(n=>n).ToArray();
            //if (sorted.Length>2)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write(sorted[i] + " ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(string.Join(" ", sorted));
            //}
            int[] input = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
