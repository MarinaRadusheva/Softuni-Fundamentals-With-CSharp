using System;

namespace _01_MidExamProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int questionsCount = firstEmployee + secondEmployee + thirdEmployee;
            int hours = 0;
            while (students>0)
            {
                students -= questionsCount;
                hours++;
                if (hours%4==0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
