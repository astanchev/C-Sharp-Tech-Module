using System;
using System.Text.RegularExpressions;

namespace _07._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

            MatchCollection matches = regex.Matches(input);

            foreach (Match m in matches)
            {
                string day = m.Groups["day"].Value;
                string month = m.Groups["month"].Value;
                string year = m.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
            
        }
    }
}
