using System;
using System.Text;

namespace _01_PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialPassword = Console.ReadLine();
            StringBuilder sb = new StringBuilder(initialPassword);
            string command = Console.ReadLine();
            while (command!="Done")
            {
                string[] commandArr = command.Split();
                switch (commandArr[0])
                    
                {
                    case "TakeOdd":
                        string oddChars = "";
                        for (int i = 1; i < sb.Length; i++)
                        {
                            if (i%2==1)
                            {
                                oddChars += sb[i];
                            }
                        }
                        sb.Clear();
                        sb.Append(oddChars);
                        Console.WriteLine(sb);
                        break;
                    case "Cut":
                        int index = int.Parse(commandArr[1]);
                        int length = int.Parse(commandArr[2]);
                        sb.Remove(index, length);
                        Console.WriteLine(sb);
                        break;
                    case "Substitute":
                        string substr = commandArr[1];
                        string substitute = commandArr[2];
                        if (sb.ToString().Contains(substr))
                        {
                            sb.Replace(substr, substitute);
                            Console.WriteLine(sb);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {sb}");

        }
    }
}
