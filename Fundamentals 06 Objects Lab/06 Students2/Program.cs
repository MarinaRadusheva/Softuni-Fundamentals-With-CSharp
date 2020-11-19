using System;
using System.Collections.Generic;
using System.Linq;


namespace _06_Students2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] readStudent = input.Split();
                Student nextStudent = new Student();
                ReadStudent(nextStudent, readStudent);
                if (StudentAlreadyExists(nextStudent, students, readStudent))
                {
                    Student student = GetStudent(students, readStudent);
                    student.age = int.Parse(readStudent[2]);
                    student.town = readStudent[3];
                    
                }
                else
                {
                    students.Add(nextStudent);
                }
                

            }
            string town = Console.ReadLine();
            List<Student> filtered = students.Where(s => s.town == town).ToList();
            foreach (var student in filtered)
            {
                Console.WriteLine($"{student.name} {student.surname} is {student.age} years old.");
            }

        }
        static Student GetStudent(List<Student> students, string[] readStudent)
        {
            Student existingStudent = null;
            foreach (var student in students)
            {
                
                if (student.name == readStudent[0] && student.surname == readStudent[1])
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        static bool StudentAlreadyExists(Student nextstudent, List<Student> students, string[] newstudent)
        {
            bool exists = false;
            foreach (var student in students)
            {
                
                if (student.name==newstudent[0] && student.surname==newstudent[1])
                {

                    exists = true;
                    break;

                }
               
            }
            if (exists == true)
            {
                return true;
            }
            else
            {
                return false;
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
    

