using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfstrings = int.Parse(Console.ReadLine());
            string patternName = @"@([A-Za-z]+)\|";
            string patternAge = @"#([0-9]+)\*";
            string name = string.Empty;
            int age = 0;


            Regex regexName = new Regex(patternName);
            Regex regexAge = new Regex(patternAge);

            for (int i = 0; i < numberOfstrings; i++)
            {
                string input = Console.ReadLine();

                if (regexName.IsMatch(input) && regexAge.IsMatch(input))
                {
                    name = regexName.Match(input).Groups[1].Value;
                    age = int.Parse(regexAge.Match(input).Groups[1].Value);
                    Console.WriteLine($"{name} is {age} years old.");
                }
            }
        }
    }
}
