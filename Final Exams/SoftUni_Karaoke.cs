using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] performers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> nameSongAwards = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "dawn")
                {
                    break;
                }

                string[] inputLine = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string participant = inputLine[0];
                string song = inputLine[1];
                string award = inputLine[2];

                if (performers.Contains(participant) && songs.Contains(song))
                {
                    if (!nameSongAwards.ContainsKey(participant))
                    {
                        nameSongAwards[participant] = new List<string>();
                    }

                    if (!nameSongAwards[participant].Contains(award))
                    {
                        nameSongAwards[participant].Add(award);
                    }
                }
            }

            if (nameSongAwards.Count > 0)
            {
                foreach (var performer in nameSongAwards
                    .OrderByDescending(p => p.Value.Count)
                    .ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{performer.Key}: {performer.Value.Count} awards");
                    foreach (var award in performer.Value.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
