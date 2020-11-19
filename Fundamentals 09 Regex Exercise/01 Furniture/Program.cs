using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>[A-Za-z]+<<[0-9.]+!\d+";
            Regex rgx = new Regex(pattern);
            string input = Console.ReadLine();
            double totalSum = 0;
            List<string> items = new List<string>();
            while (input != "Purchase")
            {
                if (rgx.IsMatch(input))
                {


                    string[] separators = new string[] { ">>", "<<", "!" };
                    string[] inputArr = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    string item = inputArr[0];
                    items.Add(item);
                    double cost = double.Parse(inputArr[1]) * int.Parse(inputArr[2]);
                    totalSum += cost;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (items.Count>0)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            
            Console.WriteLine($"Total money spend: {totalSum:F2}");

        }
    }
}
