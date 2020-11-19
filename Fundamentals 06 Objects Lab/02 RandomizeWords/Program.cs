using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Random randIndex = new Random();
            for (int i = 0; i < input.Count; i++)
            {
                int swapIndex = randIndex.Next(0, input.Count);
                string temp = input[i];
                input[i] = input[swapIndex];
                input[swapIndex] = temp;
            }
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
