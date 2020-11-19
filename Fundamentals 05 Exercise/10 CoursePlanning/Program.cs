using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_CoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            //Data Types, Objects, Lists
            string input = Console.ReadLine();
            while (input!="course start")
            {
                string[] command = input.Split(':');
                string action = command[0];
                if (action=="Add")
                {
                    string lesson = command[1];
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                    }
                }
                else if (action == "Insert")
                {
                    string lesson = command[1];
                    int index = int.Parse(command[2]);
                    if (index>-1 && index<schedule.Count)
                    {
                        if (!schedule.Contains(lesson))
                        {
                            schedule.Insert(index, lesson);
                        }
                    }
                    
                }
                else if (action == "Remove")
                {
                    string lesson = command[1];
                    if (schedule.Contains(lesson))
                    {
                        string lessonEx = lesson + "-" + "Exercise";
                        if (schedule.Contains(lessonEx))
                        {
                            schedule.Remove(lessonEx);
                        }
                        schedule.Remove(lesson);
                    }
                }
                else if (action == "Swap")
                {
                    string lesson1 = command[1];
                    string lesson2 = command[2];
                    string lessonEx1 = lesson1 + "-" + "Exercise";
                    string lessonEx2 = lesson2 + "-" + "Exercise";
                    if (schedule.Contains(lesson1) && schedule.Contains(lesson2))
                    {
                        int ind1 = schedule.IndexOf(lesson1); //2
                        int ind2 = schedule.IndexOf(lesson2); //4
                        if (schedule.Contains(lessonEx1) && schedule.Contains(lessonEx2))
                        {
                            var temp = schedule[ind1];
                            schedule[ind1] = schedule[ind2];
                            schedule[ind2] = temp;
                            var tempEx = schedule[ind1 + 1];
                            schedule[ind1+1] = schedule[ind2 + 1];
                            schedule[ind2+1] = tempEx;
                        }
                        else if (schedule.Contains(lessonEx1) && !schedule.Contains(lessonEx2))
                        {
                            //Data Types, Objects, Methods, Methods-Exercise, Lists, Arrays
                            schedule[ind1] = lesson2;
                            schedule[ind2] = lesson1;
                            //Data Types, Objects, Lists, Methods-Exercise, Methods, Arrays
                            schedule.Remove(lessonEx1);
                            //Data Types, Objects, Lists, Methods, Arrays
                            int newIndex = schedule.IndexOf(lesson1); //3
                            if (newIndex+1<schedule.Count)
                            {
                                schedule.Insert(newIndex + 1, lessonEx1);
                                //Data Types, Objects, Lists, Methods, Methods-Exercise, Arrays
                            }
                            else
                            {
                                schedule.Add(lessonEx1);
                            }

                        }
                        else if (!schedule.Contains(lessonEx1) && schedule.Contains(lessonEx2))
                        {
                            schedule[ind1] = lesson2;
                            schedule[ind2] = lesson1;
                            schedule.Remove(lessonEx2);
                            int newIndex = schedule.IndexOf(lesson2);
                            if (newIndex+1<schedule.Count)
                            {
                                schedule.Insert(newIndex + 1, lessonEx2);
                            }
                            else
                            {
                                schedule.Add(lessonEx2);
                            }
                            
                        }
                        else
                        {
                            schedule[ind1] = lesson2;
                            schedule[ind2] = lesson1;
                        }                       
                    }
                }
                else if (action == "Exercise")
                {
                    string lesson = command[1];
                    string lessonEx = lesson + "-" + "Exercise";
                    if (schedule.Contains(lesson) && !schedule.Contains(lessonEx))
                    {
                        int lessonInd = schedule.IndexOf(lesson);
                        schedule.Insert(lessonInd+1, lessonEx);
                    }
                    else if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                        schedule.Add(lessonEx);
                    }
                }

                input = Console.ReadLine();
            }
            if (schedule.Count>0)
            {
                for (int i = 0; i < schedule.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{schedule[i]}");
                }
            }
            
            
        }
    }
}
