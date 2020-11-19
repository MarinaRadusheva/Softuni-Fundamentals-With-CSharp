using System;

namespace _02_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrinGrades(grade);
        }

        static void PrinGrades(double n)
        {
            if (n>=2&&n<3)
            {
                Console.WriteLine("Fail");
            }
            else if (n>=3&&n<3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (n >= 3.50 && n < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (n >= 4.50 && n < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (n >= 5.50 && n <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
   
    }
}
