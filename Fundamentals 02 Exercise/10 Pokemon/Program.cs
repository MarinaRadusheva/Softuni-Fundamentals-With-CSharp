using System;

namespace _10_Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustion = byte.Parse(Console.ReadLine());
            int initialPower = power;
            int target = 0;
            while (power>=distance)
            {
                power -= distance;
                if ((double)power / initialPower * 100 == 50 && exhaustion!=0)
                {
                    power /= exhaustion;
                }
                target++;
            }
            Console.WriteLine(power);
            Console.WriteLine(target);
        }
    }
}
