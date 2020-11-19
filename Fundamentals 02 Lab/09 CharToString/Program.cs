using System;

namespace _09_CharToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());
            string output = "" +ch1 + ch2 + ch3;
            Console.WriteLine(output);
        }
    }
}
