using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var allUsers = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input== "Lumpawaroo")
                {
                    break;
                }
                else
                {
                    string side = "";
                    string user = "";
                    if (input.Contains("|"))
                    {
                        string[] command = input.Split(" | ");                                                                    
                        bool containsUser = false;
                        side = command[0];
                        user = command[1];
                        foreach (var pair in allUsers)
                        {
                            if (pair.Value.Contains(user))
                            {
                                containsUser = true;
                                break;
                            }
                        }
                        if (!containsUser && allUsers.ContainsKey(side))
                        {
                            allUsers[side].Add(user);
                        }
                        else if (!containsUser && !allUsers.ContainsKey(side))
                        {
                            allUsers.Add(side, new List<string> { user });
                        }
                    }
                    else if (input.Contains("->"))
                    {
                        string[] command = input.Split(" -> ");
                        bool containsUser = false;
                        user = command[0];
                        side = command[1];
                        foreach (var pair in allUsers)
                        {
                            if (pair.Value.Contains(user))
                            {
                                containsUser = true;
                                pair.Value.Remove(user);
                                break;
                            }
                        }
                        if (!containsUser && allUsers.ContainsKey(side))
                        {
                            allUsers[side].Add(user);
                        }
                        else if(!containsUser && !allUsers.ContainsKey(side))
                        {
                            allUsers.Add(side, new List<string> { user });
                        }
                        else if (containsUser && allUsers.ContainsKey(side))
                        {
                            allUsers[side].Add(user);
                        }
                        else if (containsUser && !allUsers.ContainsKey(side))
                        {
                            allUsers.Add(side, new List<string> { user });
                        }
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }
            allUsers = allUsers.OrderByDescending(pair => pair.Value.Count).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var side in allUsers)
            {
                if (side.Value.Count>0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    List<string> sortedUsers = side.Value.OrderBy(a => a).ToList();
                    foreach (var user in sortedUsers)
                    {
                        Console.WriteLine($"! { user}");
                    }
                }
                

            }
        }
    }
}
