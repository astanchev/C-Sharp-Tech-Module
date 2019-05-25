using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Iron_Girder
{
    class Program
    {
        static void Main(string[] args)
        {
            var townTime = new Dictionary<string, int>();
            var townPassangers = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Slide rule")
                {
                    break;
                }

                string[] separators = { ":", "->" };

                string[] inputLine = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                string townName = inputLine[0];
                int passangersCount = int.Parse(inputLine[2]);

                if (inputLine[1] == "ambush")
                {
                    if (townTime.ContainsKey(townName))
                    {
                        townTime[townName] = 0;
                        townPassangers[townName] -= passangersCount;
                    }
                }
                else
                {
                    int time = int.Parse(inputLine[1]);
                    if (!townTime.ContainsKey(townName))
                    {
                        townTime[townName] = time;
                    }
                    else if (townTime[townName] > time || townTime[townName] == 0)
                    {
                        townTime[townName] = time;
                    }

                    if (!townPassangers.ContainsKey(townName))
                    {
                        townPassangers[townName] = 0;
                    }
                    townPassangers[townName] += passangersCount;
                }
            }

            foreach (var town in townTime
                                .Where(t => t.Value > 0)
                                .OrderBy(t => t.Value)
                                .ThenBy(t => t.Key))
            {
                string name = town.Key;
                if (townPassangers[name] > 0)
                {
                    int totalCountPassengers = townPassangers[name];
                    Console.WriteLine($"{town.Key} -> Time: {town.Value} -> Passengers: {totalCountPassengers}");
                }
            }
        }
    }
}
