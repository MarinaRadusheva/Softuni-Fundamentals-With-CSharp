using System;
using System.Linq;

namespace _02_CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();
            string result = "";
                for (int i = 0; i < secondArr.Length; i++)
                {
                    for (int j = 0; j < firstArr.Length; j++)
                    {
                        if (secondArr[i].Equals(firstArr[j]))
                        {
                            result += secondArr[i] + " ";
                        }
                    }
                }
            
            Console.WriteLine(result);
        }
    }
}
