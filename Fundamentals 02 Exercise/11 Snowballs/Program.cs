using System;
using System.Numerics;
namespace _11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = byte.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            for (int i = 0; i < snowballsCount; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                if (BigInteger.Pow((snow / time), quality)> snowballValue)
                {
                    snowballValue = BigInteger.Pow((snow / time), quality);
                    snowballSnow = snow;
                    snowballTime = time;
                    snowballQuality = quality;
                }
            }
            
            
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");

        }
    }
}
