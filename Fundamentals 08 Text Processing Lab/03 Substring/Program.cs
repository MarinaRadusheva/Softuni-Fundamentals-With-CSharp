using System;

namespace _03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();
            int ind = input.IndexOf(substring);
            while (ind!=-1)
            {
                input = input.Remove(ind, substring.Length);
                ind = input.IndexOf(substring);
            }
            Console.WriteLine(input);
        }
    }
}
