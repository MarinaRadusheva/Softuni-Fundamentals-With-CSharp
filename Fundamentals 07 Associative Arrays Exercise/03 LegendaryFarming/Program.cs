using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shadowmourne - requires 250 Shards;
            //Valanyr - requires 250 Fragments;
            //Dragonwrath - requires 250 Motes
            var valuableMaterials = new Dictionary<string, int>();
            valuableMaterials.Add("shards", 0);
            valuableMaterials.Add("fragments", 0);
            valuableMaterials.Add("motes", 0);
            var junkMaterials = new Dictionary<string, int>();
            bool notEnough = true;
            string legendaryItem = "";
            while (notEnough)
            {
                //3 Motes 5 stones 5 Shards
                //6 leathers 255 fragments 7 Shards
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i+=2)
                {
                    string material = input[i + 1].ToLower();
                    int quantity = int.Parse(input[i]);
                    if (valuableMaterials.ContainsKey(material))
                    {
                        valuableMaterials[material] += quantity;
                        if (valuableMaterials[material]>=250)
                        {
                            notEnough = false;
                            valuableMaterials[material] -= 250;
                            if (material=="shards")
                            {
                                legendaryItem = "Shadowmourne";
                            }
                            else if (material=="fragments")
                            {
                                legendaryItem = "Valanyr";
                            }
                            else if (material=="motes")
                            {
                                legendaryItem = "Dragonwrath";
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material]+=quantity;
                        }
                        else
                        {
                            junkMaterials.Add(material, quantity);
                        }
                    }
                    
                }
            }
            valuableMaterials = valuableMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a=>a.Key,b=>b.Value);
            junkMaterials = junkMaterials.OrderBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"{legendaryItem} obtained!");
            foreach (var item in valuableMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
