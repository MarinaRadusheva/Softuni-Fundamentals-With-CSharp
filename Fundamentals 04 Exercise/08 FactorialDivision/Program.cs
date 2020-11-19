using System;

namespace _08_FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            decimal result = (GetFactorial(firstNum) / GetFactorial(secondNum));
            Console.WriteLine($"{result:f2}");
        }

        static decimal GetFactorial(int n)
        {
           
            
                decimal fact = 1;
                for (int i = 2; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            
        }
    }
}
