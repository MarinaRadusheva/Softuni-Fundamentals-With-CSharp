using System;

namespace _07_RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatStringNTimes(input, times));

        }

        static string RepeatStringNTimes(string input, int times)
        {
            string output = "";
            for (int i = 0; i < times; i++)
            {
                output += input;
            }
            return output;
        }
    }
}
