using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();            

            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+");

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
