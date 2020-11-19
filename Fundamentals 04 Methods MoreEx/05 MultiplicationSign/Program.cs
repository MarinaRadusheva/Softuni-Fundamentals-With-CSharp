using System;

namespace _05_MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            GetResult(n1, n2, n3);
        }
        static void GetResult(double n1, double n2, double n3)
        {
            if (n1>0&&n2>0&&n3>0)
            {
                Console.WriteLine("positive");
            }
            else if (n1==0||n2==0||n3==0)
            {
                Console.WriteLine("zero");
            }
            else if (n1<0&&n2<0&&n3<0)
            {
                Console.WriteLine("negative");
            }
            else if ((n1<0&&(n2<0||n3<0))|| (n2 < 0 && (n1 < 0 || n3 < 0))|| (n3 < 0 && (n2 < 0 || n1 < 0)))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
