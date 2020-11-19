using System;
using System.Collections.Generic;

namespace _05_SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var checkedIn = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string name = input[1];
                
                switch (command)
                {
                    case "register":
                        string number = input[2];
                        if (!checkedIn.ContainsKey(name))
                        {
                            checkedIn.Add(name, number);
                            Console.WriteLine($"{name} registered {number} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {number}");
                        }
                        break;
                    case "unregister":
                        if (checkedIn.ContainsKey(name))
                        {
                            checkedIn.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var user in checkedIn)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
