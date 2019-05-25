using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string[] firstLine = Console.ReadLine().Split(" | ");
            for (int i = 0; i < firstLine.Length; i++)
            {
                string[] wordAndDefinition = firstLine[i].Split(": ");
                string word = wordAndDefinition[0];
                string definition = wordAndDefinition[1];

                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = new List<string>();
                }

                if (!dictionary[word].Contains(definition))
                {
                    dictionary[word].Add(definition);
                }
            }

            string[] secondLine = Console.ReadLine().Split(" | ");
            for (int i = 0; i < secondLine.Length; i++)
            {
                string word = secondLine[i];

                if (dictionary.ContainsKey(word))
                {
                    Console.WriteLine(word);
                    foreach (var definition in dictionary[word]
                                                .OrderByDescending(d => d.Length))
                    {
                        Console.WriteLine($" -{definition}");
                    }
                }
            }

            string thirdLine = Console.ReadLine();
            if (thirdLine == "End")
            {
                return;
            }
            else if (thirdLine == "List")
            {
                List<string> orderedWords = dictionary.Keys.OrderBy(x => x).ToList();
                
                Console.WriteLine(string.Join(" ", orderedWords));
            }
        }
    }
}
