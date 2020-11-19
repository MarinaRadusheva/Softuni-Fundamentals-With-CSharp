using System;
using System.Linq;

namespace _01_EncryptSortPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] sums = new double[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    int numToAdd = 0;
                    char currentChar = (char)(input[j]);
                    if (currentChar=='a'|| currentChar == 'A' ||currentChar == 'e' || currentChar == 'E' || currentChar == 'i' || currentChar == 'I' || currentChar == 'o' || currentChar == 'O' || currentChar == 'u' || currentChar == 'U' )
                    {
                        numToAdd = input[j] * input.Length;
                    }
                    else
                    {
                        numToAdd = input[j] / input.Length;
                    }
                    sum += numToAdd;

                    //⦁	The code of each vowel multiplied by the string length
                    //⦁	The code of each consonant divided by the string length
                }
                sums[i] = sum;
            }
            sums = sums.OrderBy(x=>x).ToArray();
            foreach (var item in sums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
