using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            while (input.Count>0)
            {
                int index = int.Parse(Console.ReadLine());
                int currentDistance = 0;
                if (index<input.Count && index>-1)
                {
                    currentDistance = input[index];
                    input.RemoveAt(index);
                   
                }
                else if (index<0)
                {
                    currentDistance = input[0];
                    input[0] = input[input.Count-1];
                    
                }
                else if (index>=input.Count)
                {
                    currentDistance = input[input.Count - 1];
                    input[input.Count - 1]= input[0];
                    
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= currentDistance)
                    {
                        input[i] += currentDistance;
                    }
                    else
                    {
                        input[i] -= currentDistance;
                    }

                }
                sum += currentDistance;
            }
            Console.WriteLine(sum);

        }
    }
}
