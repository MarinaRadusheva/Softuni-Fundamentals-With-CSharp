using System;

namespace _02_CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];
            Console.WriteLine(MultiplyCharCodes(first, second));
        }

        static int MultiplyCharCodes(string first, string second)
        {
            int sum = 0;
            if (first.Length==second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    int multiplication = first[i] * second[i];
                    sum += multiplication;
                }
            }
            else if (first.Length<second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    int multiplication = first[i] * second[i];
                    sum += multiplication;
                }
                for (int i = first.Length; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }
            else
            {
                for (int i = 0; i < second.Length; i++)
                {
                    int multiplication = first[i] * second[i];
                    sum += multiplication;
                }
                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            return sum;
        }
    }
}
