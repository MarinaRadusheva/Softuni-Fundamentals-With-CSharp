using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_ExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var languages = new Dictionary<string, int>();
            var participants = new Dictionary<string, int>();
            while (input!="exam finished")
            {
                string[] newSubmission = input.Split("-");
                if (newSubmission.Length==3)
                {
                    string studentName = newSubmission[0];
                    string languageName = newSubmission[1];
                    int points = int.Parse(newSubmission[2]);
                    if (!participants.ContainsKey(studentName))
                    {
                        participants.Add(studentName, points);
                    }
                    else
                    {
                        if (participants[studentName]<points)
                        {
                            participants[studentName] = points;
                        }
                        
                    }
                    if (!languages.ContainsKey(languageName))
                    {
                        languages.Add(languageName, 1);
                    }
                    else
                    {
                        languages[languageName]++;
                    }
                }
                else if (newSubmission.Length==2)
                {
                    string studentName = newSubmission[0];
                    participants.Remove(studentName);
                }
                

                input = Console.ReadLine();
            }
            participants = participants.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Results:");
            foreach (var student in participants)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            languages = languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Submissions:");
            foreach (var language in languages)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }   
}
