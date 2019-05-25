using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var namePoints = new Dictionary<string, int>();
            var nameGoals = new Dictionary<string, int>();
            string key = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }

                string[] inputLine = input.Split();
                string teamA = inputLine[0];
                string teamB = inputLine[1];
                string score = inputLine[2];

                string nameA = GetName(teamA, key);
                string nameB = GetName(teamB, key);
                int goalsA = int.Parse(score.Split(':')[0]);
                int goalsB = int.Parse(score.Split(':')[1]);

                AddGoals(nameA, goalsA, nameGoals);
                AddGoals(nameB, goalsB, nameGoals);

                AddInTable(nameA, nameB, goalsA, goalsB, namePoints);

            }

            Console.WriteLine("League standings:");
            int i = 0;
            foreach (var team in namePoints
                                .OrderByDescending(x => x.Value)
                                .ThenBy(x => x.Key))
            {
                i++;
                Console.WriteLine($"{i}. {team.Key} {team.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in nameGoals
                                    .OrderByDescending(x => x.Value)
                                    .ThenBy(x => x.Key)
                                    .Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }

        }

        private static void AddInTable(string nameA, string nameB, int goalsA, int goalsB, Dictionary<string, int> namePoints)
        {
            if (!namePoints.ContainsKey(nameA))
            {
                namePoints[nameA] = 0;
            }
            if (!namePoints.ContainsKey(nameB))
            {
                namePoints[nameB] = 0;
            }

            if (goalsA > goalsB)
            {
                namePoints[nameA] += 3;
            }
            else if (goalsA < goalsB)
            {
                namePoints[nameB] += 3;
            }
            else
            {
                namePoints[nameA] += 1;
                namePoints[nameB] += 1;
            }
        }

        private static void AddGoals(string name, int goals, Dictionary<string, int> nameGoals)
        {
            if (!nameGoals.ContainsKey(name))
            {
                nameGoals[name] = goals;
            }
            else
            {
                nameGoals[name] += goals;
            }
        }

        private static string GetName(string team, string key)
        {
            StringBuilder outputName = new StringBuilder();
            int firstIndexOfKey = team.IndexOf(key);
            int secondIndexOfKey = team.LastIndexOf(key);
            int indexStartOfWord = firstIndexOfKey + key.Length;
            int wordLength = secondIndexOfKey - indexStartOfWord;
            for (int i = secondIndexOfKey - 1; i >= indexStartOfWord; i--)
            {
                outputName.Append(team[i]);
            }
            return outputName.ToString().ToUpper();
        }
    }
}
