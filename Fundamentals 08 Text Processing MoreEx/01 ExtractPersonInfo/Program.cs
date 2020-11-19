using System;

namespace _01_ExtractPersonInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            //Here is a name @George | and an age #18*
            //Another name @Billy | #35* is his age
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int startIndexName = input.IndexOf('@')+1;
                int lengthName = input.IndexOf('|') - startIndexName;
                int startIndexAge = input.IndexOf('#')+1;
                int lengthAge = input.IndexOf('*')-startIndexAge;
                string name = input.Substring(startIndexName, lengthName);
                string age = input.Substring(startIndexAge, lengthAge);
                Console.WriteLine($"{name} is { age } years old.");

            }
            
        }
    }
}
