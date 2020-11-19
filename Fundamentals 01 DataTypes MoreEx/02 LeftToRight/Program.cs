using System;
using System.Numerics;

namespace _02_LeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                string a = "";
                string b = "";
                string input = Console.ReadLine();
                bool secondNum = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j]==' ')
                    {
                        secondNum = true;
                        continue;
                    }
                    if (!secondNum)
                    {
                        a += input[j];
                    }
                    else
                    {
                        b += input[j];
                    }
                }
                long sum = 0;
                long numA = long.Parse(a);
                long numB = long.Parse(b);
                long biggernum = Math.Abs(Math.Max(numA, numB));
                string s = biggernum.ToString();
                    for (int p = 0; p < s.Length; p++)
                    {
                        sum += int.Parse(s[p].ToString());
                    }
                    Console.WriteLine(sum);
                
                
            }
        }
    }
}
