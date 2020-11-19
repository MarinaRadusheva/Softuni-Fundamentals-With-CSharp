using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //"
            string input = string.Empty;
            List<Student> students = new List<Student>();
            while ((input=Console.ReadLine())!="end")
            {
                string[] readStudent = input.Split();
                Student nextStudent = new Student();
                ReadStudent(nextStudent, readStudent);
                students.Add(nextStudent);
                
            }
            string town = Console.ReadLine();
            List<Student> filtered = students.Where(s => s.town == town).ToList();
            foreach (var student in filtered)
            {
                Console.WriteLine($"{student.name} {student.surname} is {student.age} years old.");
            }

        }
        static void ReadStudent(Student nextStudent, string[] input)
        {
            
            nextStudent.name = input[0];
            nextStudent.surname = input[1];
            nextStudent.age = int.Parse(input[2]);
            nextStudent.town = input[3];
        }
    }
    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string town { get; set; }

        
    }
}