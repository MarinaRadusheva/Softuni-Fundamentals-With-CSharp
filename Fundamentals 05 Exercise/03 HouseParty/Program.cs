using System;
using System.Collections.Generic;

namespace _03_HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            List<string> guestsList = new List<string>();
            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split();
                string guestName = command[0];
                if (command.Length==3)
                {
                    if (guestsList.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        guestsList.Add(guestName);
                    }
                }
                else
                {
                    if (guestsList.Contains(guestName))
                    {
                        guestsList.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guestsList.Count; i++)
            {
                Console.WriteLine(guestsList[i]);
            }
        }
    }
}
