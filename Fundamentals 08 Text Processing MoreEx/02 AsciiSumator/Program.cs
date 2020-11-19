using System;
using System.Text;

namespace _02_AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (first>second)
                {
                    if (input[i]>second&&input[i]<first)
                    {
                        sum += input[i];
                    }
                }
                else
                {
                    if (input[i]>first&&input[i]<second)
                    {
                        sum += input[i];
                    }
                }
            }
            Console.WriteLine(sum);

        }
    }
}
