using System;
using System.Collections.Generic;
using System.Linq;

namespace SaveTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static public void ReadIntArray()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }


        static public void ReadStringArray()
        {
            string[] array = Console.ReadLine().Split().ToArray();
        }

        static public void ReadIntList()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        static public void ReadStringList()
        {
            List<string> input = Console.ReadLine().Split().ToList();
        }
    }
}
