using System;
using System.Linq;

namespace _02_MidExamProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] command = input.Split();
                string action = command[0];
                switch (action)
                {
                    case "swap":
                        int fromIndex = int.Parse(command[1]);
                        int toIndex = int.Parse(command[2]);
                        int temp = array[fromIndex];
                        array[fromIndex] = array[toIndex];
                        array[toIndex] = temp;
                        break;
                    case "multiply":
                        int index1 = int.Parse(command[1]);
                        int index2 = int.Parse(command[2]);
                        array[index1] *= array[index2];
                        break;
                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] -= 1;
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
