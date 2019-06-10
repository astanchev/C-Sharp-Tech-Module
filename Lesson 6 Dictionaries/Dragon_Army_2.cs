using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeNameStats = new Dictionary<string, Dictionary<string, int[]>>();

            int numberDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberDragons; i++)
            {
                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];
                int damage = (input[2] == "null") ? 45 : int.Parse(input[2]);
                int health = (input[3] == "null") ? 250 : int.Parse(input[3]);
                int armor = (input[4] == "null") ? 10 : int.Parse(input[4]);

                if (!typeNameStats.ContainsKey(type))
                {
                    typeNameStats[type] = new Dictionary<string, int[]>();
                }

                if (!typeNameStats[type].ContainsKey(name))
                {
                    typeNameStats[type][name] = new int[3];
                }

                typeNameStats[type][name][0] = damage;
                typeNameStats[type][name][1] = health;
                typeNameStats[type][name][2] = armor;
            }

            foreach (var type in typeNameStats)
            {
                double averageDamage = type.Value.Values.Select(x => x[0]).Average();
                double averageHealth = type.Value.Values.Select(x => x[1]).Average();
                double averageArmor = type.Value.Values.Select(x => x[2]).Average();

                Console.WriteLine($"{type.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var name in type.Value.OrderBy(n => n.Key))
                {
                    string dragonName = name.Key;
                    int dragonDamage = name.Value[0];
                    int dragonHealth = name.Value[1];
                    int dragonArmor = name.Value[2];
                    Console.WriteLine($"-{dragonName} -> damage: {dragonDamage}, health: {dragonHealth}, armor: {dragonArmor}");
                }
            }
        }
    }
}
