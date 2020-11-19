using System;

namespace _01_DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day<1||day>7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfTheWeek[day - 1]);
            }
            
        }
    }
}
