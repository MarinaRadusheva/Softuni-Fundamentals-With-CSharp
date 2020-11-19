using System;

namespace _10_MultitlySums
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "" + Math.Abs(int.Parse(Console.ReadLine()));
            int[] digits = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                digits[i] = int.Parse(n[i].ToString());
            }
            Console.WriteLine(MultiplyEvenByOdd(EvenSum(digits), OddSum(digits)));

        }

        static int EvenSum(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    sum += n[i];
                }
            }
            return sum;
        }

        static int OddSum(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 1)
                {
                    sum += n[i];
                }
            }
            return sum;
        }

        static int MultiplyEvenByOdd(int a, int b)
        {
            return a * b;
        }
    }
}
