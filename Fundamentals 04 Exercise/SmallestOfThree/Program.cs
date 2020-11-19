using System;

namespace SmallestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            PrintSmallestNumber(a, b, c);
        }

        static void PrintSmallestNumber(int a, int b, int c)
        {
            int smallest =a.CompareTo(b);
            if (smallest>0)
            {
                smallest = b.CompareTo(c);

                if (smallest>0)
                {
                    smallest = c;
                }
                else
                { smallest = b; }
               
            }
            else
            {
                smallest = a.CompareTo(c);
                if (smallest>0)
                {
                    smallest = c;
                }
                else
                {
                    smallest = a;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
