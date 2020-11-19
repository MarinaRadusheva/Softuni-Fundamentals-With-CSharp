using System;
using System.Text.RegularExpressions;

namespace _01_MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var names = Regex.Matches(input, pattern);
            foreach (Match name in names)
            {
                Console.Write(name.Value+" ");
            }
        }
    }
}
