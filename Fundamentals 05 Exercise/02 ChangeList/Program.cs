using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                int element = int.Parse(command[1]);
                switch (command[0])
                {
                    case "Delete":
                        numbers.RemoveAll(i => i == element);
                        break;
                    case "Insert":
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
