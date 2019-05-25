using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "start of concert")
                {
                    break;
                }

                string[] inputLine = input.Split("; ");
                string command = inputLine[0];
                string bandName = inputLine[1];

                if (command == "Add")
                {
                    string[] members = inputLine[2].Split(", ");

                    if (!bandMembers.ContainsKey(bandName))
                    {
                        bandMembers[bandName] = new List<string>();
                    }

                    foreach (var member in members)
                    {
                        if (!bandMembers[bandName].Contains(member))
                        {
                            bandMembers[bandName].Add(member);
                        }
                    }
                }
                else if (command == "Play")
                {
                    int time = int.Parse(inputLine[2]);

                    if (!bandTime.ContainsKey(bandName))
                    {
                        bandTime[bandName] = time;
                    }
                    else
                    {
                        bandTime[bandName] += time;
                    }
                }
            }

            int totalTime = bandTime.Values.Sum();
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var band in bandTime
                                    .OrderByDescending(b => b.Value)
                                    .ThenBy(b => b.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }


            string bandToPrint = Console.ReadLine();

            Console.WriteLine(bandToPrint);
            foreach (var member in bandMembers[bandToPrint])
            {
                Console.WriteLine($"=> {member}");
            }

        }
    }
}
