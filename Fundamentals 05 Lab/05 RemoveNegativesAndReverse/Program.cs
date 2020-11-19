using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. 
            //In case there are no elements left in the list, print "empty".

            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]<0)
                {
                    input.RemoveAt(i);
                    i--;
                }
            }
            if (input.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                input.Reverse();
                Console.WriteLine(string.Join(" ", input));
            }

        }
    }
}
