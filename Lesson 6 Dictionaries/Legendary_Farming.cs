using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>()
                {
                    ["shards"] = 0,
                    ["fragments"] = 0,
                    ["motes"] = 0
                };

            while (true)
            {
                string[] inputLine = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                bool isLegendaryFarmed = false;
                for (int i = 0; i < inputLine.Length; i+=2)
                {
                    int quantity = int.Parse(inputLine[i]);
                    string material = inputLine[i + 1].ToLower();

                    if (!items.ContainsKey(material))
                    {
                        items[material] = quantity;
                    }
                    else
                    {
                        items[material] += quantity;
                    }

                    if (items.ContainsKey("shards") && items["shards"]>=250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        items["shards"] -= 250;
                        isLegendaryFarmed = true;
                        break;
                    }
                    else if (items.ContainsKey("fragments") && items["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        items["fragments"] -= 250;
                        isLegendaryFarmed = true;
                        break;
                    }
                    else if (items.ContainsKey("motes") && items["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        items["motes"] -= 250;
                        isLegendaryFarmed = true;
                        break;
                    }
                }
                if (isLegendaryFarmed)
                {
                    break;
                }
            }
            
            var keyMaterials = items
                                .Where(kvp => kvp.Key == "shards" || kvp.Key == "fragments" || kvp.Key == "motes")
                                .OrderByDescending(kvp => kvp.Value)
                                .ThenBy(kvp => kvp.Key)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            var junk = items
                    .Where(kvp => kvp.Key != "shards" && kvp.Key != "fragments" && kvp.Key != "motes")
                    .OrderBy(kvp => kvp.Key)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
