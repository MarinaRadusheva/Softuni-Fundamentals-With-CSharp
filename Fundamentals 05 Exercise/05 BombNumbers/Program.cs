using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombStrength = bomb[1];
            int bombIndex = numbers.IndexOf(bomb[0]);


            while (bombIndex != -1)
            {
                int leftBorder = bombIndex - bombStrength;
                int rightBorder = bombIndex + bombStrength;
                int range = rightBorder - leftBorder + 1;

                if (leftBorder >= 0 && rightBorder < numbers.Count)
                {
                    numbers.RemoveRange(leftBorder, range);
                }
                else if (leftBorder < 0 && rightBorder >= numbers.Count)
                {
                    numbers = new List<int> { 0 };
                }
                else if (leftBorder < 0 && rightBorder < numbers.Count)
                {
                    numbers.RemoveRange(0, rightBorder+1);
                }
                else if (leftBorder >= 0 && rightBorder >= numbers.Count)
                {
                    numbers.RemoveRange(leftBorder, numbers.Count - leftBorder);
                }
                bombIndex = numbers.IndexOf(bomb[0]);
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);

        }
    }
}

