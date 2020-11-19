using System;

namespace _04_BackIn30
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int newMinutes = minutes+30;
            if (minutes>=30)
            {
                hours++;
                newMinutes -= 60;
            }
            if (hours==24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{newMinutes:d2}");
        }
    }
}
