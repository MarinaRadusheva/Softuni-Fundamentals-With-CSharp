using System;
using System.Linq;

namespace _04_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int curr = input[0];
                int[] temp = new int[input.Length];
                for (int j = 1; j < input.Length; j++)
                {
                    temp[j-1] = input[j];
                }
                temp[temp.Length - 1] = curr;
                input = temp;
            }
            Console.WriteLine(string.Join((' '),input));
        }
    }
}
