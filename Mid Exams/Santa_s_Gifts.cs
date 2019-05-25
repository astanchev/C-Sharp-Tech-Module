using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCommands = int.Parse(Console.ReadLine());
            List<int> numberHouses = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();
            int currentPosition = 0;

            for (int i = 0; i < numberCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "Forward")
                {
                    int numberOfSteps = int.Parse(input[1]);
                    if (currentPosition + numberOfSteps < numberHouses.Count && currentPosition + numberOfSteps >= 0)
                    {
                        currentPosition += numberOfSteps;
                        numberHouses.RemoveAt(currentPosition);
                    }
                }
                else if (command == "Back")
                {
                    int numberOfSteps = int.Parse(input[1]);
                    if (currentPosition - numberOfSteps < numberHouses.Count && currentPosition - numberOfSteps >= 0)
                    {
                        currentPosition -= numberOfSteps;
                        numberHouses.RemoveAt(currentPosition);
                    }

                }
                else if (command == "Gift")
                {
                    int index = int.Parse(input[1]);
                    int houseNumber = int.Parse(input[2]);
                    if (index >= 0 && index < numberHouses.Count)
                    {
                        numberHouses.Insert(index, houseNumber);
                        currentPosition = index;
                    }
                }
                else if (command == "Swap")
                {
                    int firstHouse = int.Parse(input[1]);
                    int secondHouse = int.Parse(input[2]);

                    if (numberHouses.Contains(firstHouse) && numberHouses.Contains(secondHouse))
                    {
                        int indexOfFirst = numberHouses.IndexOf(firstHouse);
                        int indexOfSecond = numberHouses.IndexOf(secondHouse);
                        numberHouses[indexOfFirst] = secondHouse;
                        numberHouses[indexOfSecond] = firstHouse;
                    }
                }
            }

            Console.WriteLine($"Position: {currentPosition}");
            Console.WriteLine(string.Join(", ", numberHouses));

        }
    }
}
