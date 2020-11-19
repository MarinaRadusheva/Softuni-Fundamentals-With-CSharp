using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> result = new List<string>();
            for (int i = arr.Length-1; i >=0; i--)
            {
                string[] eachElement = arr[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < eachElement.Length; j++)
                {
                    result.Add(eachElement[j]);
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
