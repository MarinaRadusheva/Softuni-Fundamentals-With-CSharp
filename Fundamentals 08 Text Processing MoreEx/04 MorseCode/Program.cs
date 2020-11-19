using System;
using System.Text;

namespace _04_MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] singleLetters = Console.ReadLine().Split();
            StringBuilder decryptedCode = new StringBuilder();
            for (int i = 0; i < singleLetters.Length; i++)
            {
                string currentLetter = singleLetters[i];
                switch (currentLetter)
                {
                    case "|":
                        decryptedCode.Append(" ");
                        break;
                    case ".-":
                        decryptedCode.Append("A");
                        break;
                    case "-...":
                        decryptedCode.Append("B");
                        break;
                    case "-.-.":
                        decryptedCode.Append("C");
                        break;
                    case "-..":
                        decryptedCode.Append("D");
                        break;
                    case ".":
                        decryptedCode.Append("E");
                        break;
                    case "..-.":
                        decryptedCode.Append("F");
                        break;
                    case "--.":
                        decryptedCode.Append("G");
                        break;
                    case "....":
                        decryptedCode.Append("H");
                        break;
                    case "..":
                        decryptedCode.Append("I");
                        break;
                    case ".---":
                        decryptedCode.Append("J");
                        break;
                    case "-.-":
                        decryptedCode.Append("K");
                        break;
                    case ".-..":
                        decryptedCode.Append("L");
                        break;
                    case "--":
                        decryptedCode.Append("M");
                        break;
                    case "-.":
                        decryptedCode.Append("N");
                        break;
                    case "---":
                        decryptedCode.Append("O");
                        break;
                    case ".--.":
                        decryptedCode.Append("P");
                        break;
                    case "--.-":
                        decryptedCode.Append("Q");
                        break;
                    case ".-.":
                        decryptedCode.Append("R");
                        break;
                    case "...":
                        decryptedCode.Append("S");
                        break;
                    case "-":
                        decryptedCode.Append("T");
                        break;
                    case "..-":
                        decryptedCode.Append("U");
                        break;
                    case "...-":
                        decryptedCode.Append("V");
                        break;
                    case ".--":
                        decryptedCode.Append("W");
                        break;
                    case "-..-":
                        decryptedCode.Append("X");
                        break;
                    case "-.--":
                        decryptedCode.Append("Y");
                        break;
                    case "--..":
                        decryptedCode.Append("Z");
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(decryptedCode);
        }
    }
}
