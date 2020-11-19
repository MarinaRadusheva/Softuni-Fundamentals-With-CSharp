using System;

namespace _06_BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            bool closed = true;
            bool open = false;
            bool balanced = true;
            
            for (int i = 0; i < inputLines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    if (open == true)
                    {
                        balanced = false;
                    }
                    else
                    {
                        open = true;
                        closed = false;
                        //balanced = false;
                    }

                }
                if (input == ")")
                {
                    
                    if (closed == true)
                    {
                        balanced = false;
                    }
                    else
                    {
                        closed = true;
                        open = false;
                        
                    }
                }
                if (inputLines == 1)
                {
                    if (input!="(" && input!=")")
                    {
                        balanced = true;
                    }
                    else
                    {
                        balanced = false;
                    }
                    

                }
            }
            if (open==true&&closed==false)
            {
                balanced = false;
            }
            if (balanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
