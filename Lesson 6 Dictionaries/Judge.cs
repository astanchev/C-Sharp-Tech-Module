using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestsUsers = new Dictionary<string, Dictionary<string, int>>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "no more time")
                {
                    break;
                }
                string[] inputline = input.Split(" -> ");
                string userName = inputline[0];
                string contest = inputline[1];
                int points = int.Parse(inputline[2]);

                if (!contestsUsers.ContainsKey(contest))
                {
                    contestsUsers.Add(contest, new Dictionary<string, int>());
                }

                if (!contestsUsers[contest].ContainsKey(userName))
                {
                    contestsUsers[contest][userName] = points;
                }
                else
                {
                    if (points > contestsUsers[contest][userName])
                    {
                        contestsUsers[contest][userName] = points;
                    }
                }
            }

            foreach (var contest in contestsUsers)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                var orderedUsers = contest.Value
                                    .OrderByDescending(u => u.Value)
                                    .ThenBy(u => u.Key)
                                    .ToDictionary(u => u.Key, u => u.Value);
                int i = 1;
                foreach (var user in orderedUsers)
                {
                    Console.WriteLine($"{i}. {user.Key} <::> {user.Value}");
                    i++;
                }
            }

            Dictionary<string, int> individualSumPoints = new Dictionary<string, int>();

            foreach (var contest in contestsUsers)
            {
                foreach (var user in contest.Value)
                {
                    string name = user.Key;
                    int points = user.Value;
                    if (!individualSumPoints.ContainsKey(name))
                    {
                        individualSumPoints[name] = points;
                    }
                    else
                    {
                        individualSumPoints[name] += points;
                    }                    
                }
            }


            Console.WriteLine("Individual standings:");
            int j = 0;
            foreach (var individual in individualSumPoints
                                        .OrderByDescending(i => i.Value)
                                        .ThenBy(i => i.Key))
            {
                j++;
                Console.WriteLine($"{j}. {individual.Key} -> {individual.Value}");
            }
            
        }
    }
}
