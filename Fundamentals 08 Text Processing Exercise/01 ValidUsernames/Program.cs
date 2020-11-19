using System;
using System.Collections.Generic;

namespace _01_ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            List<string> validUsers = new List<string>();
            foreach (var user in usernames)
            {
                if (user.Length>=3&&user.Length<=16)
                {
                    bool isValid = true;
                    for (int i = 0; i < user.Length; i++)
                    {
                        char current = user[i];
                        if (!char.IsDigit(current)&&!char.IsLetter(current)&&current!='_'&&current!='-')
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        validUsers.Add(user);
                    }
                }
            }
            foreach (var user in validUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}
