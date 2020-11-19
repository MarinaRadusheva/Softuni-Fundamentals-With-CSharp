using System;

namespace _01_InputType
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dataInput = Console.ReadLine();
            PrintData(input, dataInput);
        }

        static void PrintData(string input, string dataInput)
        {
            switch (input)
            {
                case "string":
                    Console.WriteLine($"${dataInput}$");
                    break;
                case "int":
                    int n = int.Parse(dataInput) * 2;
                    Console.WriteLine(n);
                    break;
                case "real":
                    double d = double.Parse(dataInput) * 1.5;
                    Console.WriteLine($"{d:F2}");
                    break;
                default:
                    break;
            }
        }
    }
}
