using System;
using System.Text.RegularExpressions;

namespace _06_ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s)[A-Za-z0-9]+([_.-][A-Za-z0-9]+)*@[A-Za-z]+([-][A-Za-z]+)*([.][A-Za-z]+([-][A-Za-z])*)+";
            var matchedEmails = Regex.Matches(input, pattern);
            foreach (Match match in matchedEmails)
            {
                Console.WriteLine(match);
            }
        }
    }
}
