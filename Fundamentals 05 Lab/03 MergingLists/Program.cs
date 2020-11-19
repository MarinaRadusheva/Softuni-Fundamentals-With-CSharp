using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> first = Console.ReadLine().Split().ToList(); //1 2 3 4 5 6
            List<string> second = Console.ReadLine().Split().ToList(); // 7 8 9
            List<string> result = new List<string>();
            for (int i = 0; i < first.Count+second.Count; i++)
            {
                if (i<first.Count)
                {
                    result.Add(first[i]);
                }
                if (i<second.Count)
                {
                    result.Add(second[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
