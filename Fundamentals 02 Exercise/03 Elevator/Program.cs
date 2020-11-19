using System;

namespace _03_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int rounds =(int)(Math.Ceiling((double)peopleCount / capacity));
            Console.WriteLine(rounds);
        }
    }
}
