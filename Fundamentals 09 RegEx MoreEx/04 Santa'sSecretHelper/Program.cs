using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04_Santa_sSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string pattern = @"[^-@!:>]*?@(?<name>[A-Za-z]+)[^-@!:>]*?!(?<status>[NG]{1})![^-@!:>]*$";
                //@"@(?<name>[A-Za-z]+).*!(?<status>[NG]{1})!";
            List<string> goodKids = new List<string>();
            while (input != "end")
            {
                StringBuilder modifiedInput = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    char nextChar = (char)(input[i] - n);
                    modifiedInput.Append(nextChar);
                }
                string decodedInput = modifiedInput.ToString();
                
                //@Kate^jfdvbkrjgb!G!
                Match match = Regex.Match(decodedInput, pattern);
                if (match.Success && match.Groups["status"].Value=="G")
                {
                    goodKids.Add(match.Groups["name"].Value);
                }


                input = Console.ReadLine();
            }
            foreach (var name in goodKids)
            {
                Console.WriteLine(name);
            }


        }
    }
}
