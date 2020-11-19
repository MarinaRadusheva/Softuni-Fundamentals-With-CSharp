using System;

namespace _02_MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");           
            int health = 100;
            int initialBitcoins = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] tokens = rooms[i].Split();
                string command = tokens[0];
                int value = int.Parse(tokens[1]);
                if (command=="potion")
                {
                    if (value+health<=100)
                    {
                        health += value;
                    }
                    else
                    {
                        value = 100-health;
                        health = 100;
                    }
                    Console.WriteLine($"You healed for {Math.Abs(value)} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command=="chest")
                {
                    initialBitcoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    health -= value;
                    if (health>0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i+1}");
                        break;
                    }
                }
            }
            if (health>0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
