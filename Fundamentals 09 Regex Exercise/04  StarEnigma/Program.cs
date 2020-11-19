using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04__StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //List<char> specialChars = new List<char> { 'S', 's', 'T', 't', 'A', 'a', 'R', 'r' };
            string pattern = @"@(?<planet>[A-Za-z]+)[^@!:>-]*:(?<population>[0-9]+)[^@!:>-]*!(?<attack>[AD])![^@!:>-]*->(?<soldiers>[0-9]+)";
            string specialChars = "SsTtAaRr";
            List<string> planetsAttacked = new List<string>();
            List<string> planetsDestroyed = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int specialCharsCount = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    
                    if (specialChars.Contains(char.Parse(input[j].ToString())))
                    {
                        specialCharsCount++;
                    }
                }
                string decryptedInput = DecryptInputData(input, specialCharsCount);
                Match newAttack = Regex.Match(decryptedInput, pattern);
                if (newAttack.Success)
                {
                    string planet = newAttack.Groups["planet"].Value;
                    string attackType = newAttack.Groups["attack"].Value;
                    if (attackType=="A")
                    {
                        planetsAttacked.Add(planet);
                    }
                    else if (attackType=="D")
                    {
                        planetsDestroyed.Add(planet);
                    }
                }
                
            }

            Console.WriteLine($"Attacked planets: {planetsAttacked.Count}");
            if (planetsAttacked.Count > 0)
            {
                planetsAttacked = planetsAttacked.OrderBy(x => x).ToList();

                foreach (var planet in planetsAttacked)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            //printattacked planets "-> {planetName}" ordered by name alphabetically.

            Console.WriteLine($"Destroyed planets: {planetsDestroyed.Count}");
            //"-> {planetName}" ordered by name alphabetically.
            if (planetsDestroyed.Count>0)
            {
                planetsDestroyed = planetsDestroyed.OrderBy(x=>x).ToList();
                foreach (var planet in planetsDestroyed)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }



            static string DecryptInputData(string input, int specialCharsCount)
            {
                string decryptedInput = string.Empty;
                for (int j = 0; j < input.Length; j++)
                {
                    char decryptedChar = (char)(input[j] - specialCharsCount);
                    decryptedInput += decryptedChar;
                }
                return decryptedInput;
            }
        }
    }
}
