﻿using System;

namespace _08_TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int sqm = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {town} has population of {population} and area {sqm} square km.");
        }
    }
}
