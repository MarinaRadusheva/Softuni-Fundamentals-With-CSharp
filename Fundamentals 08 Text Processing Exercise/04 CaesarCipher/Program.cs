using System;

namespace _04_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string ciphered = "";
            for (int i = 0; i < input.Length; i++)
            {
                ciphered += (char)(input[i] + 3);
            }
            Console.WriteLine(ciphered);
        }

        private static char CharEnumerator(object p)
        {
            throw new NotImplementedException();
        }
    }
}
