using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_CardGames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (firstHand.Count>0&&secondHand.Count>0)
            {
                int result = firstHand[0].CompareTo(secondHand[0]);
                switch (result)
                {
                    case 1:
                        firstHand.Add(firstHand[0]);
                        firstHand.Add(secondHand[0]);
                        firstHand.RemoveAt(0);
                        secondHand.RemoveAt(0);
                        break;
                    case -1:
                        secondHand.Add(secondHand[0]);
                        secondHand.Add(firstHand[0]);
                        secondHand.RemoveAt(0);
                        firstHand.RemoveAt(0);
                        break;
                    case 0:
                        firstHand.RemoveAt(0);
                        secondHand.RemoveAt(0);
                        break;
                    default:
                        break;
                }
            }
            if (firstHand.Count==0)
            {
                int sum = secondHand.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                int sum = firstHand.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            
            
        }
    }
}
