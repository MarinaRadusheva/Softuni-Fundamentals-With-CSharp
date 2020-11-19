using System;

namespace _06_StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = input;
            string number = ""+num;
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = num % 10;
                int factorial = 1;
                for (int j = 1; j <= currentDigit; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
                num = (num - currentDigit) / 10;
                
            }
            if (sum==input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
