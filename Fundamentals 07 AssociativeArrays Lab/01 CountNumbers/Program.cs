using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var numCount = new SortedDictionary<double, int>();
            foreach (var num in numbers)
            {
                if (numCount.ContainsKey(num))
                {
                    numCount[num]++;
                }
                else
                {
                    numCount.Add(num, 1);
                }
            }
            foreach (var number in numCount)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
