using System;
using System.Collections.Generic;

namespace _03_WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var synonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (synonyms.ContainsKey(word))
                {
                    synonyms[word].Add(synonym);
                }
                else
                {
                    List<string> newWord = new List<string>();
                    newWord.Add(synonym);
                    synonyms.Add(word, newWord);
                }
            }
            foreach (var word in synonyms)
            {
                Console.WriteLine($"{ word.Key} - {string.Join(", ", word.Value)}");
            }

        } 
    }
}
