using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else
                {
                    string[] newEntry = input.Split(" : ");
                    string courseName = newEntry[0];
                    string student = newEntry[1];
                    if (!courses.ContainsKey(courseName))
                    {
                        courses.Add(courseName, new List<string>{student});
                    }
                    else
                    {
                        courses[courseName].Add(student);
                    }
                }
            }
            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(a => a.Key, b => b.Value);
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                List<string> sorted = course.Value.ToList();
                sorted = sorted.OrderBy(x=>x).ToList();
                foreach (var student in sorted)
                {
                    Console.WriteLine($"-- {student}");
                    
                }
            }
        }
    }
}
