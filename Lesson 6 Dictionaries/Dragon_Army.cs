using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int[]>> colorNameDragon =
                new Dictionary<string, Dictionary<string, int[]>>();

            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                string[] inputLine = Console.ReadLine().Split();

                string type = inputLine[0];
                string name = inputLine[1];
                int damage = (inputLine[2] == "null" ? 45 : int.Parse(inputLine[2]));
                int health = (inputLine[3] == "null" ? 250 : int.Parse(inputLine[3]));
                int armor = (inputLine[4] == "null" ? 10 : int.Parse(inputLine[4]));

                if (!colorNameDragon.ContainsKey(type))
                {
                    colorNameDragon[type] = new Dictionary<string, int[]>();
                }
                if (!colorNameDragon[type].ContainsKey(name))
                {
                    colorNameDragon[type][name] = new int[3];
                }

                colorNameDragon[type][name][0] = damage;
                colorNameDragon[type][name][1] = health;
                colorNameDragon[type][name][2] = armor;                               
            }

            foreach (var type in colorNameDragon)
            {
                int totalSumDamage = type.Value.Values.Select(n => n[0]).Sum();
                int totalSumHealth = type.Value.Values.Select(n => n[1]).Sum();
                int totalSumArmor = type.Value.Values.Select(n => n[2]).Sum();
                int totalDragonsOfType = colorNameDragon[type.Key].Count();

                double averageDamage = (double)totalSumDamage / totalDragonsOfType;
                double averageHealth = (double)totalSumHealth / totalDragonsOfType;
                double averageArmor = (double)totalSumArmor / totalDragonsOfType;

                Console.WriteLine($"{type.Key}::" +
                    $"({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var name in type.Value.OrderBy(n => n.Key))
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }

            }
        }
    }
}
