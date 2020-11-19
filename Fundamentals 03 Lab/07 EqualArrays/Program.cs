using System;
using System.Linq;

namespace _07_EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool equal = true;
            var sum = 0;
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i]!=secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    equal = false;
                    break;
                }
                else
                {
                    sum += firstArr[i];
                }
            }
            if (equal)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
