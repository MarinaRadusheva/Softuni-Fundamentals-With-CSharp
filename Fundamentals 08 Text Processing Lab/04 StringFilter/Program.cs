using System;

namespace _04_StringFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    string replacement = new string('*', word.Length);
                    text = text.Replace(word, replacement);
                }
                
            }
            Console.WriteLine(text);
        }
    }
}
