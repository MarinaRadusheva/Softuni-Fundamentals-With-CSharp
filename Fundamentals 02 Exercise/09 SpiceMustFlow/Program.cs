using System;

namespace _09_SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoint = int.Parse(Console.ReadLine());
            int collectedAmount = 0;
            int daysCounter = 0;
            while (startingPoint >= 100)
            {
                collectedAmount += startingPoint;
                if (collectedAmount >= 26)
                {
                    collectedAmount -= 26;
                }
                daysCounter++;
                startingPoint -= 10;
            }
            if (collectedAmount >= 26)
            {
                collectedAmount -= 26;
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(collectedAmount);
        }
    }
}
