using System;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = "";
            int length = user.Length - 1;
            for (int i = length; i >= 0; i--)
            {
                pass += user[i];
            }

            for (int i = 0; i < 4; i++)
            {
                string password = Console.ReadLine();
                if (password != pass)
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {user} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }

            }
        }
    }
}
