using System;

namespace _05_Decrypting
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string output = "";
            for (int i = 0; i < lines; i++)
            {
                char rawChar = char.Parse(Console.ReadLine());
                char charToAdd = (char)(rawChar + key);
                output += charToAdd;
            }
            Console.WriteLine(output);
        }
    }
}
