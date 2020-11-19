using System;

namespace _01_IntOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondtNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            double output = (firstNum + secondtNum) / thirdNum * fourthNum;
            Console.WriteLine(output);
        }
    }
}
