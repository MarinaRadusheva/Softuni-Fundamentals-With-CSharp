using System;

namespace _03_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathLine = Console.ReadLine();
            string[] separatedPath = pathLine.Split('\\');
            string[] lastTwo = separatedPath[separatedPath.Length-1].Split(".");
            Console.WriteLine($"File name: {lastTwo[0]}");
            Console.WriteLine($"File extension: {lastTwo[1]}");
        }
    }
}
