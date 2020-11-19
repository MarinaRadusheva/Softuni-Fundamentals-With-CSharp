using System;

namespace _05_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int current = i;
                int sum = 0;
                string number =""+ i;
                for (int j = 0; j < number.Length; j++)
                {
                    
                    sum += current % 10;
                    current /= 10;
                }
                bool special = (sum == 5 || sum == 7 || sum == 11);                         
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
