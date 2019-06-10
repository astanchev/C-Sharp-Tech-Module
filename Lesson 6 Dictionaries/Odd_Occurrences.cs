using System;
using System.Collections.Generic;

namespace _05._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (!counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase] = 0;
                }
                counts[wordInLowerCase]++;
            }
            List<string> oddWords = new List<string>();
            foreach (var kvp in counts)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddWords.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(" ", oddWords));
        }
    }
}
