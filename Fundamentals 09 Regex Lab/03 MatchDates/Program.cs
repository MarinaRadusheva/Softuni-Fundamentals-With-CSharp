using System;
using System.Text.RegularExpressions;

namespace _03_MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>[0-9]{2})([-.\/])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>[0-9]{4})\b";
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
