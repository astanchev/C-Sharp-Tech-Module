using System;
using System.Collections.Generic;
using System.Text;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            List<string> comments = new List<string>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "end of comments")
                {
                    break;
                }
                comments.Add(inputLine);
            }
            Console.WriteLine("<h1>");
            Console.WriteLine($"\t{title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"\t{content}");
            Console.WriteLine("</article>");
            foreach (var line in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"\t{line}");
                Console.WriteLine("</div>");
            }
        }
    }
}
