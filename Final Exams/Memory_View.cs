using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Visual Studio crash")
                {
                    break;
                }

                text.Append(input);
                text.Append(' ');
            }

            string output = text.ToString();
            
            string pattern = @"32656\s19759\s32763\s0\s(?<length>[0-9]+)\s0\s(?<symb>[0-9]{2,3}\s)+";
            Regex rg = new Regex(pattern);
            List<string> words = new List<string>();

            MatchCollection matches = rg.Matches(output);
            foreach (Match match in matches)
            {
                int length = int.Parse(match.Groups["length"].Value);
                var letters = new List<int>();
                string word = string.Empty;
                
                foreach (Capture capture in match.Groups["symb"].Captures)
                {
                    letters.Add(int.Parse(capture.Value));
                }

                for (int i = 0; i < length; i++)
                {
                    char newChar = (char)letters[i];
                    word += newChar;
                }
                words.Add(word);
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
