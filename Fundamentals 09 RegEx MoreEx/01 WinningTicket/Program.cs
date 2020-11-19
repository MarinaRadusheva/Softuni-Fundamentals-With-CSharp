using System;
using System.Text.RegularExpressions;

namespace _01_WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tickets.Length; i++)
            {
                string currentTicket = tickets[i];
                if (currentTicket.Length!=20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string firstHalf = currentTicket.Substring(0, 10);
                    string secondHalf = currentTicket.Substring(10);
                    string jackpotPattern = @"\${20}|@{20}|\^{20}|#{20}";
                    string matchPattern = @"(\${6,9}|@{6,9}|\^{6,9}|#{6,9})";
                    Match jackpot = Regex.Match(currentTicket, jackpotPattern);
                    if (jackpot.Success)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - {10}{currentTicket[0]} Jackpot!");
                    }
                    else
                    {
                        Match sixOrMore = Regex.Match(firstHalf, matchPattern);
                        if (sixOrMore.Success)
                        {
                            
                            string matchedBit1 = sixOrMore.Value;
                            Match secondSixOrMore = Regex.Match(secondHalf, matchPattern);
                            if (secondSixOrMore.Success)
                            {
                                string matchedBit2 = secondSixOrMore.Value;
                                if (matchedBit1[0] == matchedBit2[0])
                                {
                                    string matchedBit = "";
                                    if (matchedBit1.Length <= matchedBit2.Length)
                                    {
                                        matchedBit += matchedBit1;
                                    }
                                    else
                                    {
                                        matchedBit += matchedBit2;
                                    }

                                    Console.WriteLine($"ticket \"{currentTicket}\" - {matchedBit.Length}{matchedBit[0]}");
                                }
                                else
                                {
                                    Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                        }                                                
                    }
                }
            }
        }
    }
}
