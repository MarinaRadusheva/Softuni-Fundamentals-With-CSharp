using System;

namespace _07_VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double moneyInserted = 0;
            while (input!="Start")
            {
                double coins = double.Parse(input);
                switch (coins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        moneyInserted += coins;
                    break;

                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input!="End")
            {
                double price = 0;
                switch (input)
                {                
                    case "Nuts":
                        price = 2;                            
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        input = Console.ReadLine();
                        continue;
                        
                }
                if (moneyInserted >= price)
                {
                    moneyInserted -= price;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else if (moneyInserted < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {moneyInserted:f2}");
        }
    }
}
