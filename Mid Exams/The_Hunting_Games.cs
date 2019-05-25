using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDayFor1 = double.Parse(Console.ReadLine());
            double foodPerDayFor1 = double.Parse(Console.ReadLine());

            double totalWater = waterPerDayFor1 * players * daysOfAdventure;
            double totalFood = foodPerDayFor1 * players * daysOfAdventure;

            if (energy > 0)
            {
                for (int i = 1; i <= daysOfAdventure; i++)
                {
                    double energyLoss = double.Parse(Console.ReadLine());
                    energy -= energyLoss;
                    if (energy <= 0)
                    {
                        break;
                    }

                    if (i%2==0)
                    {
                        energy *= 1.05;
                        totalWater *= 0.7;
                    }

                    if (i%3==0)
                    {
                        energy *= 1.1;
                        totalFood -= totalFood / players;
                    }
                }
            }

            if (energy>0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }



        }
    }
}
