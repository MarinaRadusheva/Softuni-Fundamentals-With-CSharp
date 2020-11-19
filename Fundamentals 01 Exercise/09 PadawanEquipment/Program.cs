using System;

namespace _09_PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lasersabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double laserCount = Math.Ceiling(1.1*students);
            int beltsCount = students - (students / 6);
            double totalSum = laserCount * lasersabersPrice + beltsCount * beltsPrice + robesPrice * students;
            if (totalSum<=budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalSum-budget:f2}lv more.");
            }
        }
    }
}
