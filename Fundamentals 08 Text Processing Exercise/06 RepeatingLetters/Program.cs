using System;

using System.Linq;
using System.Collections.Generic;

namespace _06_RepeatingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> inputArr = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {

                inputArr.Add(input[i]);
            }
            for (int i = 0; i < inputArr.Count-1; i++)
            {
                if (inputArr[i]==inputArr[i+1])
                {
                    inputArr.RemoveAt(i+1);
                    i--;
                }
            }
            Console.WriteLine(string.Join("",inputArr));
        }
    }
}
