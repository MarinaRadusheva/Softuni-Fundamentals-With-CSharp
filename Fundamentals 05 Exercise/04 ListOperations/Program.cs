using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ListOperations
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

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                string action = command[0];
                switch (action)
                {
                    case "Add":
                        int num = int.Parse(command[1]);
                        numbers.Add(num);
                        break;
                    case "Insert":
                        int number = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        if (index > numbers.Count - 1 || index<0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(index, number);
                        }

                        break;
                    case "Remove":
                        int indexAt = int.Parse(command[1]);
                        if (indexAt > numbers.Count - 1 || indexAt<0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(indexAt);
                        }
                        break;
                    case "Shift":
                        string direction = command[1];
                        int ind = int.Parse(command[2]);
                        switch (direction)
                        {
                            case "right":
                                for (int i = 0; i < ind; i++)
                                {
                                    int currentLast = numbers[numbers.Count - 1];
                                    numbers.Insert(0, currentLast);
                                    numbers.RemoveAt(numbers.Count - 1);

                                }
                                break;
                            case "left":
                                for (int i = 0; i < ind; i++)
                                {
                                    int currentFirst = numbers[0];
                                    numbers.Add(currentFirst);
                                    numbers.RemoveAt(0);

                                }
                                break;

                        }
                        break;

                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
