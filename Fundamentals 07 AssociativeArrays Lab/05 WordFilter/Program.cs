using System;
using System.Linq;

namespace _05_WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
