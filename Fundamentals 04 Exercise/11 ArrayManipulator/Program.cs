using System;
using System.Linq;

namespace _11_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="end")
            {
                string[] command = input.Split();
                if (command[0]=="exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index<0||index>arr.Length-1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    ExchangeByIndex(arr, index);
                }
                else if (command[0]=="max")
                {
                    if (command[1]=="even")
                    {
                        PrintMaxEvenIndex(arr);
                    }
                    else
                    {
                        PrintMaxOddIndex(arr);
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        PrintMinEvenIndex(arr);
                    }
                    else
                    {
                        PrintMinOddIndex(arr);
                    }
                }
                else if (command[0]=="first")
                {
                    int counter = int.Parse(command[1]);
                    if (counter>arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (command[2]=="even")
                    {
                        FirstNEven(arr, counter);
                    }
                    else
                    {
                        FirstNOdd(arr, counter);
                    }

                }
                else if (command[0]=="last")
                {
                    int counter = int.Parse(command[1]);
                    if (counter > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (command[2] == "even")
                    {
                        LastNEven(arr, counter);
                    }
                    else
                    {
                        LastNOdd(arr, counter);
                    }
                }                                 
            }
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }


        static void ExchangeByIndex(int[] arr, int index)
        {  
            //array 1 3 5 7 9
            //exchange 1
            //first 5 7 9
            //second 1 3
            int[] first = new int[arr.Length-1-index];
            int[] second = new int[index+1];
            int firstIndex = 0;
            for (int i = index+1; i < arr.Length; i++)
            {
                first[firstIndex] = arr[i];
                firstIndex++;
            }
            
            for (int i = 0; i <= index; i++)
            {
                second[i] = arr[i];                
            }
            for (int i = 0; i <first.Length; i++)
            {
                arr[i] = first[i];
            }
            for (int i = 0; i < second.Length; i++)
            {
                arr[first.Length + i] = second[i];
            }

        }

        static void PrintMaxEvenIndex(int[] arr)
        {
            int maxNum = int.MinValue;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0 && arr[i]>=maxNum)
                {
                    index = i;
                    maxNum = arr[i];
                }
            }
            if (index==0 && maxNum==int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
            
        }

        static void PrintMaxOddIndex(int[] arr)
        {
            int maxNum = int.MinValue;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1 && arr[i] >= maxNum)
                {
                    index = i;
                    maxNum = arr[i];
                }
            }
            if (index == 0 && maxNum == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }

        static void PrintMinEvenIndex(int[] arr)
        {
            int minNum = int.MaxValue;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] <= minNum)
                {
                    index = i;
                    minNum = arr[i];
                }
            }
            if (index == 0 && minNum == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }

        static void PrintMinOddIndex(int[] arr)
        {
            int minNum = int.MaxValue;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1 && arr[i] <= minNum)
                {
                    index = i;
                    minNum = arr[i];
                }
            }
            if (index == 0 && minNum == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }

        static void FirstNEven(int[] arr, int count)
        {
            int stringElements = 0;
            string output = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    output += arr[i] + " ";
                    stringElements++;
                }
                if (stringElements==count)
                {
                    break;
                }
            }
            if (stringElements==0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                var result = output.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("["+string.Join(", ",result)+"]");
            }
            
        }

        static void FirstNOdd(int[] arr, int count)
        {
            int stringElements = 0;
            string output = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    output += arr[i] + " ";
                    stringElements++;
                }
                if (stringElements == count)
                {
                    break;
                }
            }
            if (stringElements == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                var result = output.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }

        }

        static void LastNEven(int[] arr, int count)
        {
            int stringElements = 0;
            string output = string.Empty;
            for (int i = arr.Length-1; i >=0; i--)
            {
                if (arr[i]%2==0)
                {
                    output += arr[i] + " ";
                    stringElements++;
                }
                if (stringElements==count)
                {
                    break;
                }
            }
            if (stringElements == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                var result = output.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        static void LastNOdd(int[] arr, int count)
        {
            int stringElements = 0;
            string output = string.Empty;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 1)
                {
                    output += arr[i] + " ";
                    stringElements++;
                }
                if (stringElements == count)
                {
                    break;
                }
            }
            if (stringElements == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                var result = output.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }
    }
}
