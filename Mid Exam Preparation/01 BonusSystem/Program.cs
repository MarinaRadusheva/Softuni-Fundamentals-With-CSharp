using System;

namespace _01_BonusSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double bestBonus = 0;
            int maxAttendance = 0;
           // { total bonus} = { student attendances} / { course lectures}*(5 + { additional bonus})
            for (int i = 0; i < studentsCount; i++)
            {
                int attendancies = int.Parse(Console.ReadLine());
                double totalBonus = (1.0*attendancies / lecturesCount )* (5 + additionalBonus);
                if (totalBonus>bestBonus)
                {
                    bestBonus = totalBonus;
                    maxAttendance = attendancies;

                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");

            // "Max Bonus: {maxBonusPoints}."
            //"The student has attended {studentAttendances} lectures."

        }
    }
}
