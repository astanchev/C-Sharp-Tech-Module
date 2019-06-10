using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().Where(x => x != ' ').ToArray();
            Dictionary<char, int> countChars = new Dictionary<char, int>();
            foreach (var @char in text)
            {
                if (!countChars.ContainsKey(@char))
                {
                    countChars[@char] = 0;
                }
                countChars[@char]++;
            }

            foreach (var kvp in countChars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
