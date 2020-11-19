using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input!="Craft!")
            {
                string[] command = input.Split(" - ");
                string action = command[0];
                string item = command[1];
                switch (action)
                {
                    case "Collect":
                        if (!journal.Contains(item))
                        {
                            journal.Add(item);
                        }
                        break;
                    case "Drop":
                        if (journal.Contains(item))
                        {
                            journal.Remove(item);
                        }
                        break;
                    case "Combine Items":
                        string[] itemsToCombine = command[1].Split(":").ToArray();
                        string firstItem = itemsToCombine[0];
                        if (journal.Contains(firstItem))
                        {
                            int index = journal.IndexOf(firstItem) + 1;
                            journal.Insert(index, itemsToCombine[1]);
                        }
                        break;
                    case "Renew":
                        if (journal.Contains(item))
                        {
                            journal.Add(item);
                            journal.Remove(item);
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
