using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            List<string> kidNames = new List<string>();
            string pattern = @"@(?<name>[A-Za-z]*)[^@\-!:\>]*!(?<behaviour>[GN])!";
            Regex rg = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                StringBuilder output = new StringBuilder();
                foreach (var symb in input)
                {
                 char newSymb = (char)(symb-key);
                 output.Append(newSymb);
                }

                string outputMessage = output.ToString();
                string name = String.Empty;
                string behaviour = String.Empty;
                if (rg.IsMatch(outputMessage))
                {
                    name = rg.Match(outputMessage).Groups["name"].Value;
                    behaviour = rg.Match(outputMessage).Groups["behaviour"].Value;

                    if (behaviour == "G")
                    {
                        kidNames.Add(name);
                    }
                }
            }

            foreach (var kid in kidNames)
            {
                Console.WriteLine(kid);
            }
        }
    }
}
