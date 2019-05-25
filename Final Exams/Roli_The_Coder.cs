using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var idName = new Dictionary<int, string>();
            var nameParticipants = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }

                string[] inputLine = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!inputLine[1].Contains('#'))
                {
                    continue;
                }

                int id = int.Parse(inputLine[0]);
                string eventName = inputLine[1].Remove(0, 1);
                if (!idName.ContainsKey(id))
                {
                    idName[id] = eventName;
                    nameParticipants[eventName] = new List<string>();
                }

                if (idName.ContainsKey(id) && idName[id] == eventName)
                {
                    for (int i = 2; i < inputLine.Length; i++)
                    {
                        string participant = inputLine[i].Remove(0, 1);
                        if (!nameParticipants[eventName].Contains(participant))
                        {
                            nameParticipants[eventName].Add(participant);
                        }
                    }
                }
            }

            foreach (var @event in nameParticipants
                .OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
            {
                Console.WriteLine($"{@event.Key} - {@event.Value.Count}");
                foreach (var participant in @event.Value.OrderBy(p => p))
                {
                    Console.WriteLine($"@{participant}");
                }
            }
        }
    }
}
