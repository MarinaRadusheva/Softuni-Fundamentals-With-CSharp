using System;
using System.Collections.Generic;
using System.Linq;

namespace ForumProblemWithFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>
            {
                'a','A',
                'e','E',
                'i','I',
                'o','O',
                'u','U'
            };

            List<char> consonants = new List<char>
            {
             'B','b','C','c','d','D','F','f','G','g','H','h','J','j','K','k','L','l','M','m','N','n','P','p',
             'Q','q','R','r','S','s','T','t','V','v','W','w','X','x','Y','y','z','Z'
            };

            int linesNumbers = int.Parse(Console.ReadLine());
            double[] sumOfAll = new double[linesNumbers];
            for (int i = 0; i < linesNumbers; i++)
            {
                string word = Console.ReadLine();
                int sum = 0;

                for (int k = 0; k < word.Length; k++)
                {
                    if (vowels.Contains(word[k]))
                    {
                        sum = sum + (word[k] * word.Length);

                    }
                    else 
                    {
                        sum = sum + (word[k] / word.Length);
                    }

                }
                sumOfAll[i] = sum;
            }


            var listOfSum = sumOfAll.ToList();
            var newListWithoutZero = listOfSum.Where(x => x != 0);
            var newOrderList = newListWithoutZero.OrderBy(x => x);
            foreach (var item in newOrderList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
