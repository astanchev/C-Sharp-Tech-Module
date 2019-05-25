using System;

namespace _02._Baking_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayEvents = Console.ReadLine().Split('|');
            int energy = 100;
            int coins = 100;

            for (int i = 0; i < dayEvents.Length; i++)
            {
                string[] singleEvent = dayEvents[i].Split('-');
                string eventOrIngradient = singleEvent[0];
                int number = int.Parse(singleEvent[1]);

                if (eventOrIngradient == "rest")
                {
                    energy = Rest(energy, number);
                }
                else if (eventOrIngradient == "order")
                {
                    if (energy - 30 >= 0)
                    {
                        coins += number;
                        energy -= 30;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine($"You had to rest!");
                    }
                }
                else
                {
                    coins -= number;
                    if (coins <= 0)
                    {
                        Console.WriteLine($"Closed! Cannot afford {eventOrIngradient}.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You bought {eventOrIngradient}.");
                    }
                }
            }
            PrintResult(energy, coins);
        }

        private static void Order(int energy, int coins, int number)
        {
            throw new NotImplementedException();
        }

        private static int Rest(int energy, int number)
        {
            int newEnergy = energy + number;
            if (newEnergy > 100)
            {
                newEnergy = 100;
            }
            Console.WriteLine($"You gained {newEnergy - energy} energy.");
            Console.WriteLine($"Current energy: {newEnergy}.");
            return newEnergy;
        }

        private static void PrintResult(int energy, int coins)
        {
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
