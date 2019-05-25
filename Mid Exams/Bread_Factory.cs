using System;

namespace _02._Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;
            string[] events = Console.ReadLine().Split('|');

            for (int i = 0; i < events.Length; i++)
            {
                string @event = events[i];
                string commandOrIngredient = @event.Split('-')[0];
                int pointsOrCoins = int.Parse(@event.Split('-')[1]);

                if (commandOrIngredient == "rest")
                {
                    int newEnergy = energy + pointsOrCoins;
                    if (newEnergy > 100)
                    {
                        newEnergy = 100;
                    }

                    Console.WriteLine($"You gained {newEnergy - energy} energy.");
                    energy = newEnergy;
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (commandOrIngredient == "order")
                {
                    int newEnergy = energy - 30;
                    if (newEnergy >= 0)
                    {
                        energy = newEnergy;
                        coins += pointsOrCoins;
                        Console.WriteLine($"You earned {pointsOrCoins} coins.");
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    coins -= pointsOrCoins;
                    if (coins > 0)
                    {
                        Console.WriteLine($"You bought {commandOrIngredient}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {commandOrIngredient}.");
                        return;
                    }
                }

            }

            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
