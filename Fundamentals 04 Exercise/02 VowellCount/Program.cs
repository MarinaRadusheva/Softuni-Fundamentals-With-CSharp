using System;

namespace _02_VowellCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowellsCount(input);
        }

        static void VowellsCount(string input)
        {
            input = input.ToLower();
            int vowellsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o'||input[i]=='u')
                {
                    vowellsCount++;
                }
            }
            Console.WriteLine(vowellsCount);
        }
    }
}
