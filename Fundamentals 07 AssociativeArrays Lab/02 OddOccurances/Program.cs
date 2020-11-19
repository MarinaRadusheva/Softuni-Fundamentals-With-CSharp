using System;
using System.Collections.Generic;

namespace _02_OddOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            var wordOccurances = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string wordToLower = word.ToLower();
                if (wordOccurances.ContainsKey(wordToLower))
                {
                    wordOccurances[wordToLower]++;
                }
                else
                {
                    wordOccurances.Add(wordToLower, 1);
                }
            }
            foreach (var word in wordOccurances)
            {
                if (word.Value%2!=0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
