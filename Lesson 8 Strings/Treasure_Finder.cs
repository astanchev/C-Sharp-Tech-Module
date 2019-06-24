using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                            .Split(new char[] { ' ', ',', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            string patternType = @"&([A-Za-z]+)&";
            string patternCoordinates = @"<(\w+)>";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "find")
                {
                    break;
                }
                StringBuilder output = new StringBuilder();
                for (int i = 0, j = 0; i < input.Length; i++, j++)
                {
                    char symb = input[i];
                    int keyValue = key[j];
                    char newSymb = (char)(symb - keyValue);
                    output.Append(newSymb);

                    if (j == key.Length - 1)
                    {
                        j = -1;
                    }
                }

                string result = output.ToString();
                Regex regexType = new Regex(patternType);
                Regex regexCoordinates = new Regex(patternCoordinates);
                if (regexType.IsMatch(result) && regexCoordinates.IsMatch(result))
                {
                    string type = regexType.Match(result).Groups[1].Value;
                    string coordinates = regexCoordinates.Match(result).Groups[1].Value;
                    Console.WriteLine($"Found {type} at {coordinates}");
                }
            }
            //1 2 1 3
            //ikegfp'jpne)bv=41P83X@ 
            //ujfufKt)Tkmyft'duEprsfjqbvfv=53V55XA 
            //find

        }
    }
}
