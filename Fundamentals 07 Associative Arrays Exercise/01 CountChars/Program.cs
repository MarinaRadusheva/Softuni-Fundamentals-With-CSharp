using System;
using System.Collections.Generic;

namespace _01_CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]==' ')
                {
                    input=input.Remove(i, 1);
                    //if (i != input.Length - 1)
                    { i--; }
                }
            }
            var charOccurances = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (charOccurances.ContainsKey(input[i]))
                {
                    charOccurances[input[i]]++;
                }
                else
                {
                    charOccurances.Add(input[i], 1);
                }
            }
            foreach (var c in charOccurances )
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
