using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    int newWagon = int.Parse(command[1]);
                    train.Add(newWagon);
                }
                else
                {
                    int morePassengers = int.Parse(command[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (capacity - train[i] >= morePassengers)
                        {
                            train[i] += morePassengers;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
            }
            Console.WriteLine(string.Join(" ", train));
        }
    }
}
