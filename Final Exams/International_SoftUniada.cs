using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._International_SoftUniada
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryContestantPoints = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] inputLine = input.Split(" -> ");
                string countryName = inputLine[0];
                string contestantName = inputLine[1];
                int contestantPoints = int.Parse(inputLine[2]);

                bool isContestantValid = true;
                foreach (var kvp in countryContestantPoints)
                {
                    if (kvp.Key == contestantName)
                    {
                        isContestantValid = false;
                    }
                }

                if (!countryContestantPoints.ContainsKey(countryName) && isContestantValid)
                {
                    countryContestantPoints[countryName] = new Dictionary<string, int>();
                }

                if (!countryContestantPoints[countryName].ContainsKey(contestantName))
                {
                    countryContestantPoints[countryName][contestantName] = contestantPoints;
                }
                else
                {
                    countryContestantPoints[countryName][contestantName] += contestantPoints;
                }
            }

            foreach (var country in countryContestantPoints
                                    .OrderByDescending(c=>c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key}: {country.Value.Values.Sum()}");
                foreach (var contestant in country.Value)
                {
                    Console.WriteLine($"-- {contestant.Key} -> {contestant.Value}");
                }
            }
        }
    }
}
