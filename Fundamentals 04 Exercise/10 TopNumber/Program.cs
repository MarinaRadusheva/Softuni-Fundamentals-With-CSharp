using System;

namespace _10_TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int n = int.Parse(input);
            for (int i = 0; i <= n; i++)
            {
                if (CheckForOddDigit(i.ToString()) && CheckIfSumIsDivisibleEight(i.ToString()))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckForOddDigit(string n)
        {
            bool containsOdd = false;
            for (int i = 0; i < n.Length; i++)
            {                
                int currentDigit = int.Parse(n[i].ToString());
                if (currentDigit%2==1)
                {
                    containsOdd = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (containsOdd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckIfSumIsDivisibleEight(string n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += int.Parse(n[i].ToString());
            }
            if (sum%8==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
