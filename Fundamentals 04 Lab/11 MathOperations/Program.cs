using System;

namespace _11_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(GetCalculationResult(a,operation,b));

        }

        static double GetCalculationResult(int a, char r, int b)
        {
            double result = 0;
            switch (r)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
