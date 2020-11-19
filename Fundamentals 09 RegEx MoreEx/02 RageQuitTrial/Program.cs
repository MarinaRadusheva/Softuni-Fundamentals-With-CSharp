using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02_RageQuitTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            //aSd2&5s@1
            //read input
            string input = Console.ReadLine();
            string pattern = @"(?<str>\D+)(?<rep>\d+)";

            //make a collection of matches and add the new string to a stringbuilder.
            // keep track of unique symbols in a List of symbols
            var matches = Regex.Matches(input, pattern);
            List<char> symbols = new List<char>();
            StringBuilder message = new StringBuilder();
            foreach (Match match in matches)
            {
                string stringToAdd = match.Groups["str"].Value;
                int repetitions = int.Parse(match.Groups["rep"].Value);
                for (int i = 0; i < repetitions; i++)
                {
                    message.Append(stringToAdd);
                }

            }
            string output = message.ToString().ToUpper();
            for (int i = 0; i <output.Length; i++)
            {
                if (!symbols.Contains(output[i]))
                {
                    symbols.Add(output[i]);
                }
            }
            
            Console.WriteLine($"Unique symbols used: {symbols.Count}");
            Console.WriteLine(output);
        }
    
    }
}
