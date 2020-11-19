using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> first = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> second = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> longer = new List<double>();
            List<double> shorter = new List<double>();
            List<double> merged = new List<double>();
            double to = 0;
            double from = 0;
            if (first.Count > second.Count)
            {
                longer = first;
                shorter = second;
                to = Math.Max(longer[longer.Count - 1], longer[longer.Count - 2]);
                from = Math.Min(longer[longer.Count - 1], longer[longer.Count - 2]);
            }
            else
            {
                longer = second;
                shorter = first;
                to = Math.Max(longer[0], longer[1]);
                from = Math.Min(longer[0], longer[1]);
            }
            for (int i = 0; i < shorter.Count; i++)
            {
                merged.Add(first[i]);
                merged.Add(second[second.Count-1-i]);
            }
            
            List<double> result = merged.Where(x => x > from && x < to).OrderBy(x=>x).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
