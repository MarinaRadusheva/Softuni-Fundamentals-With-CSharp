using System;
using System.Linq;

namespace _06_EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < input.Length; i++)
            {
                bool isTop = true;
                for (int j = i+1; j <input.Length; j++)
                {
                    if (input[i]<=input[j])
                    {
                        isTop = false;
                        break;
                    }                   
                }
                if (isTop==true)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
