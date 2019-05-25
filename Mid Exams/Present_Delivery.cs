using System;
using System.Linq;

namespace _03._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                                .Split('@')
                                .Select(int.Parse)
                                .ToArray();

            int indexSanta = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Merry Xmas!")
                {
                    break;
                }
                string[] command = input.Split();
                int jumpLenght = int.Parse(command[1]);

                indexSanta = Jump(jumpLenght, indexSanta, houses);
            }

            PrintResult(indexSanta, houses);
        }

        private static int Jump(int jumpLenght, int indexSanta, int[] houses)
        {
            indexSanta = (indexSanta + jumpLenght) % houses.Length;

            if (houses[indexSanta]>=2)
            {
                houses[indexSanta] -= 2;
            }
            else
            {
                Console.WriteLine($"House {indexSanta} will have a Merry Christmas.");
            }
            return indexSanta;
        }

        private static void PrintResult(int indexSanta, int[] houses)
        {
            Console.WriteLine($"Santa's last position was {indexSanta}.");
            if (IsMissionSuccess(houses))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int failedHouses = GetFailedHouses(houses);
                Console.WriteLine($"Santa has failed {failedHouses} houses.");
            }
        }

        private static bool IsMissionSuccess(int[] houses)
        {
            bool isMissionSuccess = true;
            foreach (var house in houses)
            {
                if (house > 0)
                {
                    return false;
                }
            }
            return isMissionSuccess;
        }

        private static int GetFailedHouses(int[] houses)
        {
            int numberFailedHouses = 0;
            foreach (var house in houses)
            {
                if (house > 0)
                {
                    numberFailedHouses++;
                }
            }
            return numberFailedHouses;
        }
    }
}
