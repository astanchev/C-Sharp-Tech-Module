using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)(?<word>.+)\1";
            Regex rg = new Regex(pattern);

            string textWithPlaceholders = Console.ReadLine();
            string[] placeholders = Console.ReadLine()
                                    .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> placeholderInText = new List<string>();

            MatchCollection matches = rg.Matches(textWithPlaceholders);
            foreach (Match match in matches)
            {
                string word = match.Groups["word"].Value;
                placeholderInText.Add(word);
            }

            for (int i = 0, j = 0; i < placeholderInText.Count; i++, j++)
            {
                string word = placeholderInText[i];
                string replacement = placeholders[j];
                int indexOfFirst = textWithPlaceholders.IndexOf(word);
                textWithPlaceholders = textWithPlaceholders.Remove(indexOfFirst, word.Length);
                textWithPlaceholders = textWithPlaceholders.Insert(indexOfFirst, replacement);
                if (j == placeholders.Length - 1)
                {
                   break;
                }
            }

            Console.WriteLine(textWithPlaceholders);
        }
    }
}
