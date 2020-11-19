using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ListManipulationBasic
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
            bool changesAreMade = false;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                string action = command[0];
                if (action == "Filter")
                {
                    string condition = command[1];
                    int conditionNum = int.Parse(command[2]);
                    switch (condition)
                    {
                        case "<":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < conditionNum)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            break;
                        case ">":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > conditionNum)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            break;
                        case ">=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= conditionNum)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            break;
                        case "<=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= conditionNum)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine();
                }
                else
                {
                    if (command.Length > 1)
                    {
                        int number = int.Parse(command[1]);



                        switch (action)
                        {
                            case "Add":
                                AddToList(numbers, number);
                                changesAreMade = true;
                                break;
                            case "Remove":
                                RemoveFromList(numbers, number);
                                changesAreMade = true;
                                break;
                            case "RemoveAt":
                                RemoveAtFromList(numbers, number);
                                changesAreMade = true;
                                break;
                            case "Insert":
                                int index = int.Parse(command[2]);
                                InsertInList(numbers, number, index);
                                changesAreMade = true;
                                break;
                            case "Contains":
                                if (numbers.Contains(number))
                                { Console.WriteLine("Yes"); }
                                else
                                {
                                    Console.WriteLine("No such number");
                                }
                                break;
                        }
                    }
                    else
                    {
                        switch (action)
                        {
                            case "PrintEven":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] % 2 == 0)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "PrintOdd":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] % 2 != 0)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "GetSum":
                                int sum = 0;
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    sum += numbers[i];
                                }
                                Console.WriteLine(sum);
                                break;

                            default:
                                break;
                        }
                    }
                }


            }
            if (changesAreMade==true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }

        static void AddToList(List<int> input, int num)
        {
            input.Add(num);
        }

        static void RemoveFromList(List<int> input, int num)
        {
            input.Remove(num);
        }
        static void RemoveAtFromList(List<int> input, int num)
        {
            input.RemoveAt(num);
        }
        static void InsertInList(List<int> input, int num, int index)
        {
            input.Insert(index, num);
        }
    }
}

