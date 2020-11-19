using System;

namespace _05_PrintAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoint = int.Parse(Console.ReadLine());
            int endingPoint = int.Parse(Console.ReadLine());
            for (int i = startingPoint; i <= endingPoint; i++)
            {
                char ch =Convert.ToChar(i);
                Console.Write(ch+" ");
            }
        }
    }
}
