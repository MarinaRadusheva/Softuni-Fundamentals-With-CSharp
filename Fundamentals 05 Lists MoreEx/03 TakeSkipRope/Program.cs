using System;
using System.Collections.Generic;
using System.Text;

namespace _03_TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> digits = new List<int>();
            List<char> chars = new List<char>();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    chars.Add(input[i]);
                }
            }
            for (int i = 0; i < digits.Count; i+=2)
            {
                int take = digits[i];
                int skip = digits[i + 1];
               
                for (int j = 0; j < take; j++)
                {
                    if (chars.Count>0)
                    {
                        output.Append(chars[0]);
                        chars.RemoveAt(0);
                    }
                    
                }
                for (int p = 0; p < skip; p++)
                {
                    if (chars.Count>0)
                    {
                        chars.RemoveAt(0);
                    }
                }
                
                
            }
            Console.WriteLine(output);
        }
    }
}
