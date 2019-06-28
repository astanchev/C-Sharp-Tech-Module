using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            MatchCollection matches = regex.Matches(input);

            List<string> result = new List<string>();

            foreach (Match m in matches)
            {
                result.Add(m.Value);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
