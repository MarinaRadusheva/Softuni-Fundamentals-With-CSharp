using System;
using System.Linq;

namespace _06_EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool noSuchNumber = true;
            for (int i = 0; i < inputArr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    if (i > 0)
                    {
                        leftSum += inputArr[j];
                    }
                }
                for (int k = inputArr.Length - 1; k > i; k--)
                {
                    if (i<inputArr.Length-1)
                    {
                        rightSum += inputArr[k];
                    }
                }
                if (rightSum==leftSum)
                {
                    noSuchNumber = false;
                    Console.WriteLine(i);
                }
            }
            if (noSuchNumber)
            {
                Console.WriteLine("no");
            }
        }
    }
}
