using System;

namespace _02_ConcatenateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string concatenated = "";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    concatenated += words[i];
                }
            }
            Console.WriteLine(concatenated);
        }
    }
}
