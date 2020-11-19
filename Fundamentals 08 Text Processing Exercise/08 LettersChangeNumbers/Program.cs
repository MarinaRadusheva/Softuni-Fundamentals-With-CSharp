using System;

namespace _08_LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;
            foreach (var entry in input)
            {
                totalSum += ReturnSumOfEntry(entry);
            }
            Console.WriteLine($"{totalSum:F2}");

            static double ReturnSumOfEntry(string entry)
            {
                double sum = 0;
                char firstLetter = entry[0];
                char lastLetter = entry[entry.Length - 1];
                string numberInString = entry.Substring(1, entry.Length - 2);
                double number = double.Parse(numberInString);
                if (firstLetter>=65&&firstLetter<=90)
                {
                    int divider = firstLetter - 64;
                    sum=number/divider;
                }
                else if (firstLetter>=97&&firstLetter<=122)
                {
                    int multiplier = firstLetter - 96;
                    sum = number * multiplier;
                }
                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    int subtractor = lastLetter - 64;
                    sum -= subtractor;
                }
                else if (lastLetter >= 97 && lastLetter <= 122)
                {
                    int addition = lastLetter - 96;
                    sum += addition;
                }
                return sum;
            }
        } 
    }
}
