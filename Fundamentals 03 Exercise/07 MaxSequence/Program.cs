using System;
using System.Linq;

namespace _07_MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxSequence = 0;
            int number = 0;
            for (int i = 0; i < inputArr.Length-1; i++)
            {
                int sameIntegerCount = 1;
                while (inputArr[i]==inputArr[i+1]&&i<inputArr.Length)
                {
                    sameIntegerCount++;
                    i++;
                    if (maxSequence<sameIntegerCount)
                    {
                        maxSequence = sameIntegerCount;
                        number = inputArr[i];
                    }
                    if (i==inputArr.Length-1)
                    {
                        break;
                    }
                }                
            }
            int[] output = new int[maxSequence];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = number;
            }
            Console.WriteLine(string.Join(' ',output));
        }
    }
}
