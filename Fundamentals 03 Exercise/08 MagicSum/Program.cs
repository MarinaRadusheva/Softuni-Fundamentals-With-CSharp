using System;
using System.Linq;

namespace _08_MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int k = i+1; k < inputArr.Length; k++)
                {
                    
                   
                        int tempSum = inputArr[i]+inputArr[k];
                        if(tempSum==sum)
                        {
                            Console.WriteLine(inputArr[i]+" "+inputArr[k]);
                        }
                    
                    
                }
            }
        }
    }
}
