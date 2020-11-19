using System;
using System.Linq;

namespace _09_KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestDna = new int[n];
            int bestLength = 0;
            int bestStartingPoint = 0;
            int greatestSum = 0;
            int dnaCount = 0;
            int dnaIndex = 0;
            var input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int[] dna = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int sum = 0;
                int length = 1;
                int bestCurrLength = 1;
                int currStartingPoint = 0;
                dnaCount++;
                for (int k = 0; k < dna.Length; k++)
                {
                    if (dna[k] == 1)
                    {
                        sum++;
                    }
                }
                for (int i = 0; i < dna.Length - 1; i++)
                {


                    if (dna[i] == 1 && dna[i] == dna[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }
                    if (bestCurrLength < length)
                    {
                        bestCurrLength = length;
                        currStartingPoint = i;
                    }
                }

                if (bestLength < bestCurrLength)
                {
                    bestLength = bestCurrLength;
                    bestStartingPoint = currStartingPoint;
                    greatestSum = sum;
                    dnaIndex = dnaCount;
                    bestDna = dna.ToArray();
                }
                else if (bestLength == bestCurrLength)
                {
                    if (currStartingPoint < bestStartingPoint)
                    {
                        bestLength = bestCurrLength;
                        bestStartingPoint = currStartingPoint;
                        greatestSum = sum;
                        dnaIndex = dnaCount;
                        bestDna = dna.ToArray();
                    }
                    else if (bestStartingPoint == currStartingPoint)
                    {
                        if (greatestSum < sum)
                        {
                            bestLength = bestCurrLength;
                            bestStartingPoint = currStartingPoint;
                            greatestSum = sum;
                            dnaIndex = dnaCount;
                            bestDna = dna.ToArray();
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {dnaIndex} with sum: {greatestSum}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }
    }
}
