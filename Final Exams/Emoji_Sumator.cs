using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Emoji_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternEmoji = @"\s:(?<emoji>[a-z]{4,}):(?=\s|[,.!?])";
            Regex rgEmoji = new Regex(patternEmoji);
            List<string> emojies = new List<string>();
            int totalEmojiPower = 0;

            string text = Console.ReadLine();
            int[] givenASCII = Console.ReadLine()
                                        .Split(':')
                                        .Select(int.Parse)
                                        .ToArray();
            string givenEmoji = String.Empty;
            for (int i = 0; i < givenASCII.Length; i++)
            {
                givenEmoji += (char)givenASCII[i];
            }

            MatchCollection matches = rgEmoji.Matches(text);
            foreach (Match match in matches)
            {
                string emoji = match.Groups["emoji"].Value;
                emojies.Add(emoji);
            }

            foreach (var emojy in emojies)
            {
                for (int i = 0; i < emojy.Length; i++)
                {
                    totalEmojiPower += emojy[i];
                }
            }

            string searchedEmoji = givenEmoji;
            if (emojies.Contains(searchedEmoji))
            {
                totalEmojiPower *= 2;
            }

            if (emojies.Count > 0)
            {
                List<string> emojiForPrint = new List<string>();
                foreach (var emojy in emojies)
                {
                    emojiForPrint.Add(":" + emojy + ":");
                }
                Console.WriteLine($"Emojis found: {string.Join(", ", emojiForPrint)}");
            }
            Console.WriteLine($"Total Emoji Power: {totalEmojiPower}");
        }
    }
}
