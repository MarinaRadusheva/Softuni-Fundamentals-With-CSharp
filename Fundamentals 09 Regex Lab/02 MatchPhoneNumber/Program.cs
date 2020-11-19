using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02_MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([- ]{1})2\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();
            var matchedNumbers = Regex.Matches(input, pattern);
            var matchingNums = matchedNumbers.Cast< Match >().Select(x=>x.Value).ToArray();
            Console.WriteLine(string.Join(", ", matchingNums));
        }
    }
}
