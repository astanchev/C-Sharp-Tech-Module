using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains("|"))
                {
                    string[] inputLine = input.Split(" | ");
                    string forceSide = inputLine[0];
                    string forceUser = inputLine[1];
                    if (!forces.ContainsKey(forceSide))
                    {
                        if (forces.Values.Any(u => u.Contains(forceUser)))
                        {
                            continue;
                        }
                        forces[forceSide] = new List<string>();
                    }
                    if (!forces[forceSide].Contains(forceUser))
                    {
                        forces[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] inputLine = input.Split(" -> ");
                    string forceSide = inputLine[1];
                    string forceUser = inputLine[0];

                    bool isUserExist = false;
                    string currentSide = string.Empty;
                    foreach (var kvp in forces)
                    {
                        foreach (var user in kvp.Value)
                        {
                            if (user == forceUser)
                            {
                                isUserExist = true;
                                currentSide = kvp.Key;
                            }
                        }
                    }

                    if (!isUserExist)
                    {
                        if (!forces.ContainsKey(forceSide))
                        {
                            forces[forceSide] = new List<string>();
                        }
                        forces[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        if (!forces.ContainsKey(forceSide))
                        {
                            forces[forceSide] = new List<string>();
                        }
                        forces[currentSide].Remove(forceUser);
                        forces[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
            }

            foreach (var kvp in forces
                                .Where(kvp => kvp.Value.Count > 0)
                                .OrderByDescending(kvp => kvp.Value.Count)
                                .ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                foreach (var member in kvp.Value.OrderBy(m => m))
                {
                    Console.WriteLine($"! {member}");
                }
            }

        }
    }
}
