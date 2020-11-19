using System;
using System.Collections.Generic;

namespace _01_Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new Dictionary<string, string>();
            string newString = Console.ReadLine();
            while (newString!="end")
            {
                string reversed = "";
                for (int i = newString.Length-1; i >=0; i--)
                {
                    reversed += newString[i];
                }
                strings.Add(newString, reversed);
                newString = Console.ReadLine();
            }
            foreach (var word in strings)
            {
                Console.WriteLine($"{word.Key} = {word.Value}");
            }
        }
    }
}
