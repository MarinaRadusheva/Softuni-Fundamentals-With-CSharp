using System;

namespace _12_RefractorSpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                     
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int current = i;
                while (current > 0)
                {
                    sum += current % 10;
                    current /= 10;
                }
                bool special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, special);              
            }

        }
    }
}
