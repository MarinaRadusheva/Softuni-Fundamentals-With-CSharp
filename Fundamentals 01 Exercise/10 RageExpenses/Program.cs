using System;

namespace _10_RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardtPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            for (int i = 1; i <= gamesCount; i++)
            {
                if (i%2==0)
                {
                    headsetCount++;
                }
                if (i%3==0)
                {
                    mouseCount++;
                }
                if (i%6==0)
                {
                    keyboardCount++;
                }
                if (i%12==0)
                {
                    displayCount++;
                }
            }
            double totalCost = headsetCount*headsetPrice+mouseCount*mousePrice+keyboardCount*keyboardtPrice+displayCount*displayPrice;
            Console.WriteLine($"Rage expenses: {totalCost:f2} lv.");
        }
    }
}
