using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //string input = Console.ReadLine();
            StringBuilder input = new StringBuilder(Console.ReadLine());
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < nums.Count; i++)
            {
                int n = nums[i];
                int sum = 0;
                while (n>0)
                {
                    sum += n % 10;
                    n = n / 10;
                }
                while (sum>=input.Length)
                {
                    sum -= input.Length;
                }
                output.Append(input[sum]);
                input.Remove(sum, 1);
                    }
            Console.WriteLine(output);

        }
    }
}
