using System;
using System.Linq;

namespace _05_TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxValue = int.MinValue;
            string result = "";
            for (int i = input.Length-1; i >=0; i--)
            {
                if (maxValue<input[i])
                {
                    maxValue = input[i];
                    result += maxValue + " ";
                }
            }
            string[] output = result.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            string[] outputReversed = new string[output.Length];
            for (int i = 0; i < output.Length; i++)
            {
                outputReversed[i] = output[output.Length - 1 - i];
            }
            Console.WriteLine(string.Join(' ',outputReversed));
        }
    }
}
