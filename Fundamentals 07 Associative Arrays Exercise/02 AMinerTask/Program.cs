using System;
using System.Collections.Generic;
using System.Numerics;

namespace _02_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var resourses = new Dictionary<string, BigInteger>();
            while (input!="stop")
            { 
                BigInteger quantity = BigInteger.Parse(Console.ReadLine());
                if (resourses.ContainsKey(input))
                {
                    resourses[input] += quantity;
                }
                else
                {
                    resourses.Add(input, quantity);
                }
                input = Console.ReadLine();
            }
            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
