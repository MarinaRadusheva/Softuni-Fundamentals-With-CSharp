using System;
using System.Collections.Generic;

namespace _05_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();
            string comment = Console.ReadLine();
            List<string> comments = new List<string>();
            while (comment!= "end of comments")
            {
                comments.Add(comment);
                comment = Console.ReadLine();
            }
            Console.WriteLine($"<h1>\n\t{title}\n</h1>");
            Console.WriteLine($"<article>\n\t{article}\n</article>");
            for (int i = 0; i < comments.Count; i++)
            {
                string commentToDisplay = comments[i];
                Console.WriteLine("<div>");
                Console.WriteLine($"\t{commentToDisplay}");
                Console.WriteLine("</div>");
            }
          
        }
    }
}
