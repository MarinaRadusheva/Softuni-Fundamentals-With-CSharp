using System;

namespace _06_TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 97; i < 97+n; i++)
            {
                for (int j = 97; j < 97+n; j++)
                {
                    for (int k = 97; k < 97+n; k++)
                    {
                        char ch1 = Convert.ToChar(i);
                        char ch2 = Convert.ToChar(j);
                        char ch3 = Convert.ToChar(k);
                        string output = ""+ch1 + ch2 + ch3;
                        Console.WriteLine(output);

                    }
                }
            }

        }
    }
}
