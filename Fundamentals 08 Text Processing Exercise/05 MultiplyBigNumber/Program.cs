using System;

namespace _05_MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a =5;
            //int b = 10;
            //Console.WriteLine(a/b);
            //Console.WriteLine(a%10);
            string bigNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (bigNum[0]=='0')
            {
                bigNum = bigNum.Substring(1);
            }

            string result = "";
            int addition = 0;
            int numToAdd = 0;
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int s = int.Parse(bigNum[i].ToString());
                
                numToAdd = ((s * num) + addition);
                addition = 0;
                if (numToAdd > 9)
                {
                    addition = numToAdd / 10;
                    numToAdd = numToAdd % 10;

                }

                result += numToAdd;
                if (i == 0 && addition!=0)
                {
                    result += addition;
                }


            }

            string reversedResult = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                reversedResult += result[i];
            }
            Console.WriteLine(reversedResult);
        }
    }
}
