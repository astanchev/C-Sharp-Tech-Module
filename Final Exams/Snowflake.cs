using System;
using System.Text.RegularExpressions;

namespace Problem_3___Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternFirst = @"([^A-Za-z0-9]+)";
            string patternSecond = @"([0-9_]+)";
            string patternThird = @"([^A-Za-z0-9]+)([0-9_]+)(?<core>[A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)";
            string patternFourth = @"([0-9_]+)";
            string patternFifth = @"([^A-Za-z0-9]+)";

            Regex rgFirst = new Regex(patternFirst);
            Regex rgSecond = new Regex(patternSecond);
            Regex rgThird  = new Regex(patternThird);
            Regex rgFourth = new Regex(patternFourth);
            Regex rgFifth = new Regex(patternFifth);

            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string thirdString = Console.ReadLine();
            string fourthString = Console.ReadLine();
            string fifthString = Console.ReadLine();

            if (rgFirst.IsMatch(firstString) 
                && rgSecond.IsMatch(secondString)
                && rgThird.IsMatch(thirdString)
                && rgFourth.IsMatch(fourthString)
                && rgFifth.IsMatch(fifthString))
            {
                Console.WriteLine("Valid");
                int length = rgThird
                                .Match(thirdString)
                                .Groups["core"]
                                .Value
                                .Length;
                Console.WriteLine(length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
