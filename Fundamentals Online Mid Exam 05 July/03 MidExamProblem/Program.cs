using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MidExamProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double averageValue = 1.0*numbers.Sum() / numbers.Count;
            List<int> output = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]>averageValue) //5 2 3 4 -10 30 40 50 20 50 60 60 51
                {
                    output.Add(numbers[i]);
                }
            }
            if (output.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                output.Sort();
                output.Reverse();
                if (output.Count>5)
                {
                    output.RemoveRange(5,output.Count-5);
                }
                Console.WriteLine(string.Join(" ",output));
            }
        }
    }
}
