using System;
using System.Linq;

namespace _02_CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            //29 13 9 0 13 0 21 0 14 82 12
            double[] levels = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double firstRacerTime = 0;
            double secondRacerTime = 0;
            int half = levels.Length / 2;
            for (int i = 0; i < half; i++)
            {
                if (levels[i]==0)
                {
                    firstRacerTime *= 0.8;
                }
                else
                {
                    firstRacerTime += levels[i];
                }
                if (levels[levels.Length-1-i]==0)
                {
                    secondRacerTime *= 0.8;
                }
                else
                {
                    secondRacerTime += levels[levels.Length - 1 - i];
                }
                
            }
            if (firstRacerTime<secondRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondRacerTime}");
            }
        }
    }
}
