using System;

namespace _02._Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;
            string[] rooms = Console.ReadLine().Split('|');

            for (int i = 0; i < rooms.Length; i++)
            {
                string itemOrMonster = rooms[i].Split()[0];
                int pointsOrGold = int.Parse(rooms[i].Split()[1]);
                int room = i + 1;

                if (itemOrMonster == "potion")
                {
                    int tempHealth = health;
                    health += pointsOrGold;
                    if (health > 100)
                    {
                        health = 100;
                        tempHealth = 100 - tempHealth;
                        Console.WriteLine($"You healed for {tempHealth} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {pointsOrGold} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (itemOrMonster == "chest")
                {
                    coins += pointsOrGold;
                    Console.WriteLine($"You found {pointsOrGold} coins.");
                }
                else
                {
                    health -= pointsOrGold;
                    if (health<=0)
                    {
                        Console.WriteLine($"You died! Killed by {itemOrMonster}.");
                        Console.WriteLine($"Best room: {room}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {itemOrMonster}.");
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}
