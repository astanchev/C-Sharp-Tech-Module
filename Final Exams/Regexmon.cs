using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternBojomon = @"[A-Za-z]+\-[A-Za-z]+";
            Regex rgBojomon = new Regex(patternBojomon);
            string patternDidimon = @"[^A-Za-z\-]+";
            Regex rgDidimon = new Regex(patternDidimon);

            List<string> listBojomon = new List<string>();
            List<string> listDidimon = new List<string>();

            string input = Console.ReadLine();

            while (true)
            {
                if (rgDidimon.IsMatch(input))
                {
                    string wordDidimon = rgDidimon.Matches(input).First().Value;
                    int length = wordDidimon.Length;
                    int indexDidimonEnd = input.IndexOf(wordDidimon) + length;
                    Console.WriteLine(wordDidimon);
                    input = input.Substring(indexDidimonEnd);
                }
                else
                {
                    break;
                }

                if (rgBojomon.IsMatch(input))
                {
                    string wordBojomon = rgBojomon.Matches(input).First().Value;
                    int length = wordBojomon.Length;
                    int indexBojomonEnd = input.IndexOf(wordBojomon) + length;
                    Console.WriteLine(wordBojomon);
                    input = input.Substring(indexBojomonEnd);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
