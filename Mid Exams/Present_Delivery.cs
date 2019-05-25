using System;
using System.Linq;

namespace _03._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] housesMembers = Console.ReadLine()
                                        .Split('@')
                                        .Select(int.Parse)
                                        .ToArray();
            int currentPosition = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Merry Xmas!")
                {
                    break;
                }

                int length = int.Parse(input.Split()[1]);
                currentPosition += length;
                if (currentPosition > housesMembers.Length - 1)
                {
                    currentPosition = currentPosition % housesMembers.Length;
                }
                if (housesMembers[currentPosition] == 0)
                {
                    Console.WriteLine($"House {currentPosition} will have a Merry Christmas.");
                }
                else
                {
                    housesMembers[currentPosition] -= 2;
                }
            }

            Console.WriteLine($"Santa's last position was {currentPosition}.");

            int countEmptyHouse = 0;
            foreach (var house in housesMembers)
            {
                if (house == 0)
                {
                    countEmptyHouse++;
                }
            }

            if (countEmptyHouse == housesMembers.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {housesMembers.Length - countEmptyHouse} houses.");
            }

        }
    }
}
