using System;
using System.Linq;

namespace _04_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] summedFirst = new int[numbers.Length / 4];
            int[] summedSecond = new int[numbers.Length / 4];
            int middle = (numbers.Length/2)-1;
            int quarter = (numbers.Length/4);
            for (int i = 0; i < quarter; i++)
            {
                summedFirst[i] = numbers[i] + numbers[middle - i];
            }
            summedFirst = summedFirst.Reverse().ToArray();
            int p = 0;
            for (int i = middle+1; i <= middle+quarter; i++)
            {

                summedSecond[p] = numbers[i] + numbers[numbers.Length-1-p];
                p++;
            }
            Console.WriteLine($"{string.Join(" ",summedFirst)} {string.Join(" ",summedSecond)}");
            
        }
    }
}
