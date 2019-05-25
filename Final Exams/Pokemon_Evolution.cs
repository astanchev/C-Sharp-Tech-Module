using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonEvolution = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                string[] inputLine = input.Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);

                if (inputLine.Length == 1)
                {
                    string pokemonName = inputLine[0];
                    if (pokemonEvolution.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var evolution in pokemonEvolution[pokemonName])
                        {
                            Console.WriteLine(evolution);
                        }
                    }
                }
                else
                {
                    string pokemonName = inputLine[0];
                    string evolutionType = inputLine[1];
                    string evolutionIndex = inputLine[2];
                    string evolution = evolutionType + " <-> " + evolutionIndex;
                    
                    if (!pokemonEvolution.ContainsKey(pokemonName))
                    {
                        pokemonEvolution[pokemonName] = new List<string>();
                    }
                    pokemonEvolution[pokemonName].Add(evolution);
                    
                }
            }

            foreach (var pokemon in pokemonEvolution)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var typeIndex in pokemon
                                            .Value
                                            .OrderByDescending(x => int.Parse(x.Split(" <-> ")[1])))
                {
                    Console.WriteLine(typeIndex);
                }

            }

        }
    }
}
