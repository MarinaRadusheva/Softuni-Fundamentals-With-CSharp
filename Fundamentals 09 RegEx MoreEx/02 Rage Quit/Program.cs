using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            //aSd2&5s@1
            //read input
            string input = Console.ReadLine().ToUpper();
            string pattern = @"(?<str>\D+)(?<rep>\d+)";

            //make a collection of matches and add the new string to a stringbuilder.
            // keep track of unique symbols in a List of symbols
            var matches = Regex.Matches(input, pattern);
            List<char> symbols= new List<char>();
            StringBuilder output = new StringBuilder();
            foreach (Match match in matches)
            {
                string stringToAdd = match.Groups["str"].Value;
                for (int i = 0; i < stringToAdd.Length; i++)
                {
                    char currentChar = stringToAdd[i];
                    if (!symbols.Contains(currentChar))
                    {
                        symbols.Add(currentChar);
                    }
                }
                int repetitions = int.Parse(match.Groups["rep"].Value);
                for (int i = 0; i < repetitions; i++)
                {
                    output.Append(stringToAdd);
                }

            }
            Console.WriteLine($"Unique symbols used: {symbols.Count}");
            Console.WriteLine(output);
        }
    }
}
