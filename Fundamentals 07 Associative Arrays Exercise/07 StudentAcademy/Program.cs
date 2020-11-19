using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students.Add(studentName, new List<double> { studentGrade });
                }
            }
            var smartStudents = new Dictionary<string, double>();
            foreach (var student in students)
            {
                if (student.Value.Average()>=4.50)
                {
                    smartStudents.Add(student.Key, student.Value.Average());
                }
            }
            smartStudents = smartStudents.OrderByDescending(x => x.Value).ToDictionary(a=>a.Key, b=>b.Value);
            foreach (var student in smartStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
