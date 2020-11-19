using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)                

            {
                string input = Console.ReadLine();
                string decrypted = "";
                string patternItem = @"&(\w+)&";
                string item = "";
                string coordinates = "";
                string patternCoordinates = @"(\w+)>";
                if (input=="find")
                {
                    break;
                }
                //1 2 1 3
                //ikegfp'jpne)bv=41P83X@
                //ujfufKt)Tkmyft'duEprsfjqbvfv=53V55XA
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    char charToAdd = (char)(input[i] - keys[count]);
                    decrypted += charToAdd;
                    count++;
                    if (count==keys.Length)
                    {
                        count = 0;
                    }
                }
                Match matchItem = Regex.Match(decrypted, patternItem);
                if (matchItem.Success)
                {
                    item = matchItem.Groups[1].Value;
                }
                Match matchCoordinates = Regex.Match(decrypted, patternCoordinates);
                if (matchCoordinates.Success)
                {
                    coordinates = matchCoordinates.Groups[1].Value;
                }
                Console.WriteLine($"Found { item} at { coordinates}");
            }
            
        }
    }
}
