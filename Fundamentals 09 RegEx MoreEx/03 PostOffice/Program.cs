using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            string first = input[0];
            string second = input[1];
            string[] third = input[2].Split();
            string lettersPattern = @"([#\$%\*&])([A-Z]+)\1";
            Match letters = Regex.Match(first, lettersPattern);
            string firstLetters = letters.Groups[2].ToString();
            List<string> words = new List<string>();
            for (int i = 0; i < firstLetters.Length; i++)
            {
                int capitalLetter = firstLetters[i];
                string lengthPattern = @"" + capitalLetter + @":(?<lettersCount>\d{2})";
                Match wordLength = Regex.Match(second, lengthPattern);
                int length = int.Parse(wordLength.Groups[1].Value);
                string wordPattern = @"^" + firstLetters[i] + @"[\S]*$";
                foreach (var word in third)
                {
                    Match possibleMatch = Regex.Match(word, wordPattern);
                    string wordToCheck = possibleMatch.ToString();
                    if (wordToCheck.Length==length+1)
                    {
                        words.Add(wordToCheck);
                    }
                    
                }                  
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
             
            

        }
    }
}
