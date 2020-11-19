using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            //contest}:{password for contest}
            string newEntry = Console.ReadLine();
            Dictionary<string, string> contests = new Dictionary<string, string>();
            while (newEntry!="end of contests")
            {
                string[] nextContest = newEntry.Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (!contests.ContainsKey(nextContest[0]))
                {
                    contests.Add(nextContest[0], nextContest[1]);
                }
                newEntry = Console.ReadLine();
            }
            //contest}=>{password}=>{username}=>{points}” 
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> students = new Dictionary<string, Dictionary<string, double>>();
            while (input!="end of submissions")
            {
                string[] newResult = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string subject = newResult[0];
                string pass = newResult[1];
                if (contests.ContainsKey(subject)&&contests[subject]==pass)
                {
                    string userName = newResult[2];
                    double points = double.Parse(newResult[3]);
                    if (!students.ContainsKey(userName))
                    {
                        students.Add(userName,new Dictionary<string, double>());
                        students[userName].Add(subject, points);
                    }
                    else
                    {
                        if (students[userName].ContainsKey(subject))
                        {
                            if (students[userName][subject]<points)
                            {
                                students[userName][subject] = points;
                            }
                        }
                        else
                        {
                            students[userName].Add(subject, points);
                        }
                    }
                }

                input = Console.ReadLine();
            }
            double maxpoints = 0;
            string name = "";
            foreach (var student in students)
            {
                double totalPoints = 0;
                foreach (var subject in student.Value)
                {
                    totalPoints += subject.Value;
                }
                if (totalPoints>maxpoints)
                {
                    maxpoints = totalPoints;
                    name = student.Key;
                }
                
            }
            Console.WriteLine($"Best candidate is {name} with total { maxpoints} points.");
            Console.WriteLine("Ranking:");
            students = students.OrderBy(x=>x.Key).ToDictionary(a=>a.Key, b=>b.Value);
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                Dictionary<string, double> orderedSubjects = student.Value.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);
                foreach (var subj in orderedSubjects)
                {
                    Console.WriteLine($"#  {subj.Key} -> {subj.Value}");
                }
            }
        }
    }
}
