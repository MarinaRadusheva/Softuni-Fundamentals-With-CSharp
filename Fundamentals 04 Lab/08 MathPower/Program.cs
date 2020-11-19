using System;

namespace _08_MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberRaisedToPower(number,power));

        }

        static double NumberRaisedToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
