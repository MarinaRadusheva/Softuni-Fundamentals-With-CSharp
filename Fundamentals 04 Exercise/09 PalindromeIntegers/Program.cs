using System;

namespace _09_PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                Console.WriteLine(CHeckIfPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();

            }
        }

        static bool CHeckIfPalindrome(string n)
        {
            bool isPalindrome = true;
            if (n.Length%2==0)
            {
                for (int i = 0; i < n.Length/2; i++)
                {
                    if (n[i]==n[n.Length-1-i])
                    {
                        continue;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i <= n.Length / 2; i++)
                {
                    if (n[i] == n[n.Length-1 - i])
                    {
                        continue;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }
            if (isPalindrome)
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
