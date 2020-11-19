using System;

namespace _05_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int characters = int.Parse(Console.ReadLine());
            string s2 = "abc";
            string s3 = "def";
            string s4 = "ghi";
            string s5 = "jkl";
            string s6 = "mno";
            string s7 = "pqrs";
            string s8 = "tuv";
            string s9 = "wxyz";
            string message = "";
            for (int i = 0; i < characters; i++)
            {
                string input = Console.ReadLine();
                char curr = input[0];
                switch (curr)
                {
                    case '2':
                        message += s2[input.Length - 1];
                        break;
                    case '3':
                        message += s3[input.Length - 1];
                        break;
                    case '4':
                        message += s4[input.Length - 1];
                        break;
                    case '5':
                        message += s5[input.Length - 1];
                        break;
                    case '6':
                        message += s6[input.Length - 1];
                        break; ;
                    case '7':
                        message += s7[input.Length - 1];
                        break;
                    case '8':
                        message += s8[input.Length - 1];
                        break;
                    case '9':
                        message += s9[input.Length - 1];
                        break;
                    case '0':
                        message += " ";
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(message);
        }
    }
}
