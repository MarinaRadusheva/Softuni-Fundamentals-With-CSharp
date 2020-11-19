using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_AnonymousThread
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "3:1")
            {
                string[] commandElements = command.Split();
                string action = commandElements[0];
                int firstNum = int.Parse(commandElements[1]);
                int secondNum = int.Parse(commandElements[2]);
                switch (action)
                {
                    case "merge":   //Example: {abc, def, ghi} -> merge 0 1 -> {abcdef, ghi}
                                    //Ivo Johny Tony Bony Mony
                        if (firstNum > input.Count - 1 || secondNum < firstNum || secondNum<0)
                        {
                            break;
                        }
                        else
                        {
                            if (firstNum < 0)
                            {
                                firstNum = 0;
                            }
                            if (secondNum > input.Count - 1)
                            {
                                secondNum = input.Count - 1;
                            }
                            for (int i = firstNum + 1; i <= secondNum; i++)
                            {
                                input[firstNum] += input[i];
                            }
                            input.RemoveRange(firstNum + 1, secondNum - firstNum);
                        }

                        break;
                    case "divide":
                        // input[firstNum]
                        //Example: {abcdef, ghi, jkl} -> divide 0 3 -> {ab, cd, ef, ghi, jkl}
                        //Example: {abcd, efgh, ijkl} -> divide 0 3 -> {a, b, cd, efgh, ijkl}
                        //abcd efgh ijkl mnop qrst uvwx yz
                        string word = input[firstNum]; //abcdef
                        int substringsLength = word.Length / secondNum;  //2
                        
                        List<string> dividedWord = new List<string>();
                        int index = 0;
                        for (int i = 0; i < secondNum; i++)
                        {
                            if (i+1==secondNum)
                            {
                                if (word.Length % secondNum != 0)
                                {
                                    substringsLength = substringsLength + word.Length % secondNum;
                                }
                            }

                            dividedWord.Add(word.Substring(index, substringsLength));
                            index += substringsLength;
                        }
                        input.RemoveAt(firstNum);
                        input.InsertRange(firstNum, dividedWord);

                        

                        break;
                    default:
                        break;
                }
               

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
