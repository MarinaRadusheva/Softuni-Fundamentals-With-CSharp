using System;

namespace _04_Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (CheckPassLength(password) && (CheckChars(password)) && CheckForTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!CheckPassLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!CheckChars(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!CheckForTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

            }



        }

        static bool CheckPassLength(string password)
        {
            if (password.Length > 5 && password.Length < 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckChars(string password)
        {
            bool isAllowed = true;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 48 && password[i] <= 57) || (password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122))
                {
                    continue;
                }
                else
                {
                    isAllowed = false;
                    break;
                }
            }
            if (isAllowed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckForTwoDigits(string password)
        {
            int digitsCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitsCounter++;
                }
            }
            if (digitsCounter < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
