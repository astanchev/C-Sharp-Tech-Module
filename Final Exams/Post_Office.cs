using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputParts = Console.ReadLine().Split('|');
            string firstPart = inputParts[0];
            string secondPart = inputParts[1];
            string[] thirdPartWords = inputParts[2]
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string patternFirst = @"([#\$%\*&])(?<upperCase>[A-Z]+)\1";
            Regex first = new Regex(patternFirst);
            string patternSecond = @"(?<ascii>\d{2}):(?<length>\d{2})";
            Regex second = new Regex(patternSecond);

            string upperCaseMatches = first.Match(firstPart)
                                      .Groups["upperCase"]
                                      .Value;
            char[] upperCasses = upperCaseMatches.ToCharArray();

            Dictionary<char, int> asciiLength = new Dictionary<char, int>();
            MatchCollection matches = second.Matches(secondPart);
            foreach (Match match in matches)
            {
                char ascii = (char)int.Parse(match.Groups["ascii"].Value);
                int length = int.Parse(match.Groups["length"].Value);
                if (ascii > 64 && ascii < 91 && !asciiLength.ContainsKey(ascii))
                {
                    asciiLength[ascii] = length;
                }
            }

            for (int i = 0; i < upperCasses.Length; i++)
            {
                char upperCaseLetter = upperCasses[i];
                int length = asciiLength[upperCaseLetter]+1;
                foreach (var word in thirdPartWords)
                {
                    if (word.StartsWith(upperCaseLetter) && word.Length == length)
                    {
                        Console.WriteLine(word);
                        break;
                    }
                }
            }

        }
    }
}
