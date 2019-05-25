using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine()
                                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                                .ToList();

            int health = 100;
            int coins = 0;
            for (int i = 0; i < rooms.Count; i++)
            {
                string[] room = rooms[i].Split();
                string itemOrMonster = room[0];
                int value = int.Parse(room[1]);
                if (itemOrMonster == "potion")
                {
                    health = DrinkPotion(value, health);
                }
                else if (itemOrMonster == "chest")
                {
                    coins = ColectMoney(value, coins);
                }
                else
                {
                    health = SlayMonster(value, itemOrMonster, health);
                    if (health <= 0)
                    {                        
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }

            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }

        private static int SlayMonster(int value, string itemOrMonster, int health)
        {
            health -= value;
            if (health > 0)
            {
                Console.WriteLine($"You slayed {itemOrMonster}.");
                return health;
            }
            else
            {
                Console.WriteLine($"You died! Killed by {itemOrMonster}.");
                return health;
            }            
        }

        private static int ColectMoney(int value, int coins)
        {
            coins += value;
            Console.WriteLine($"You found {value} coins.");
            return coins;
        }

        private static int DrinkPotion(int value, int health)
        {
            int newHealth = health;
            newHealth += value;
            if (newHealth > 100)
            {
                newHealth = 100;
            }
            Console.WriteLine($"You healed for {newHealth - health} hp.");
            Console.WriteLine($"Current health: {newHealth} hp.");

            return newHealth;
        }
    }
}
