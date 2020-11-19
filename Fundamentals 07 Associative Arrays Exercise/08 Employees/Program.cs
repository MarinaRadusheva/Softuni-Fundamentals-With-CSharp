using System;
using System.Collections.Generic;

namespace _08_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new SortedDictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                else
                {
                    string[] employee = input.Split(" -> ");
                    string company = employee[0];
                    string id = employee[1];
                    if (employees.ContainsKey(company))
                    {
                        if (!employees[company].Contains(id))
                        {
                            employees[company].Add(id);
                        }
                    }
                    else
                    {
                        employees.Add(company, new List<string> { id });
                    }
                }
            }
            foreach (var company in employees)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine("-- "+employee);
                }
            }
        }
    }
}
