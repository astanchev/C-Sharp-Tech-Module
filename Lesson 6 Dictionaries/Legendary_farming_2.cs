using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_farming_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["fragments"] = 0,
                ["motes"] = 0
            };
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            bool isLegendaryFarmed = false;

            while (true)
            {
                string[] inputLine = Console.ReadLine().Split();
                for (int i = 0; i < inputLine.Length; i += 2)
                {
                    int quantity = int.Parse(inputLine[i]);
                    string material = inputLine[i + 1].ToLower();

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }
                        junkMaterials[material] += quantity;
                    }

                    if (keyMaterials["shards"] >= 250)
                    {
                        keyMaterials["shards"] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        isLegendaryFarmed = true;
                        break;
                    }

                    if (keyMaterials["fragments"] >= 250)
                    {
                        keyMaterials["fragments"] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        isLegendaryFarmed = true;
                        break;
                    }

                    if (keyMaterials["motes"] >= 250)
                    {
                        keyMaterials["motes"] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        isLegendaryFarmed = true;
                        break;
                    }
                }
                if (isLegendaryFarmed)
                {
                    break;
                }
            }
            foreach (var kvp in keyMaterials
                                .OrderByDescending(kvp => kvp.Value)
                                .ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterials
                                .OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }

    }
}
