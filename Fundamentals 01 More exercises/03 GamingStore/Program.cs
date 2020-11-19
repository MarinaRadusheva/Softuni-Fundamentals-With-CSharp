using System;

namespace _03_GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double price = 0;
            double totalCost = 0;
            while (game!= "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        game = Console.ReadLine();
                        continue;
                }
                if (budget>=price)
                {
                    budget -= price;
                    totalCost += price;
                    Console.WriteLine($"Bought {game}");
                }
                if (budget==0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                else if (budget<price)
                {
                    Console.WriteLine("Too Expensive");
                    
                }
                game = Console.ReadLine();
            }
            if (game=="Game Time")
            {
                Console.WriteLine($"Total spent: ${totalCost:f2}. Remaining: ${budget:f2}");
            }
        }
    }
}
