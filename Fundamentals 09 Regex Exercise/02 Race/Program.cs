using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");           
            Dictionary<string, int> results = new Dictionary<string, int>();            
            foreach (var item in names)
            {
                results.Add(item,0);
            }
            string newEntry = Console.ReadLine();
            while (newEntry!= "end of race")
            {
                string name = "";
                int distance = 0;
                for (int i = 0; i < newEntry.Length; i++)
                {
                    if (char.IsLetter(newEntry[i]))
                    {
                        name += newEntry[i];
                    }
                    else if (char.IsDigit(newEntry[i]))
                    {
                        distance += int.Parse(newEntry[i].ToString());
                    }
                }
                if (results.ContainsKey(name))
                {
                    results[name] += distance;
                }
                

                newEntry = Console.ReadLine();
            }
            var finalOrder = results.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();
            //results = results.OrderByDescending(x => x.Value).Take(3).ToDictionary(a=>a.Key, b=>b.Value);
            //List<string> finalOrder = new List<string>();
            //foreach (var item in results)
            //{
            //    finalOrder.Add(item.Key);
            //}
            Console.WriteLine($"1st place: {finalOrder[0]}");
            Console.WriteLine($"2nd place: {finalOrder[1]}");
            Console.WriteLine($"3rd place: {finalOrder[2]}");
        }
    }
}
