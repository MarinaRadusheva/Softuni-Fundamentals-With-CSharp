using System;

namespace _03_CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            GetCharsFromTo(first, second);

        }

        static void GetCharsFromTo(char a, char b)
        {
            if (a.CompareTo(b) > 0)
            {
                for (int i = b+1; i < a; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
