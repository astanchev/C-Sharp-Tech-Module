using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            var legionActivity = new Dictionary<string, int>();
            var legionTypeCount = new Dictionary<string, Dictionary<string, long>>();

            int numberInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberInputs; i++)
            {
                char[] separators = { ' ', '=', '-', '>', ':' };
                string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int lastActivity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                int soldierCount = int.Parse(input[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity[legionName] = lastActivity;
                }
                else if (legionActivity[legionName] < lastActivity)
                {
                    legionActivity[legionName] = lastActivity;
                }

                if (!legionTypeCount.ContainsKey(legionName))
                {
                    legionTypeCount[legionName] = new Dictionary<string, long>();
                }

                if (!legionTypeCount[legionName].ContainsKey(soldierType))
                {
                    legionTypeCount[legionName][soldierType] = soldierCount;
                }
                else
                {
                    legionTypeCount[legionName][soldierType] += soldierCount;
                }
            }

            string[] command = Console.ReadLine().Split('\\');
            if (command.Length > 1)
            {
                int activity = int.Parse(command[0]);
                string soldierType = command[1];
                
                foreach (var legion in legionTypeCount
                                        .Where(l => l.Value.ContainsKey(soldierType))
                                        .OrderByDescending(l => l.Value[soldierType]))
                {
                    if (legionActivity[legion.Key] < activity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legionTypeCount[legion.Key][soldierType]}");
                    }
                }
            }
            else
            {
                string soldierType = command[0];
                foreach (var legion in legionActivity
                                        .OrderByDescending(l => l.Value))
                {
                    if (legionTypeCount[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }

            }

        }
    }
}
