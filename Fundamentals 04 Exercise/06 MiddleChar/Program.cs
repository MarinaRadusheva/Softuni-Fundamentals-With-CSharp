using System;

namespace _06_MiddleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);
        }

        static void PrintMiddleChar(string input)
        {
            if (input.Length%2==1)
            {
                Console.WriteLine(input[input.Length / 2]);
            }
            else
            {
                Console.Write(input[input.Length / 2 - 1]);
                Console.Write(input[input.Length / 2]);
            }
        }
    }
}
