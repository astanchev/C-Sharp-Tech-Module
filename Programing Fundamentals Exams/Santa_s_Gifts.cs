using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<int> houseNumbers = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                                    .ToList();
            int currentPosition = 0;

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] inputCommandLine = Console.ReadLine().Split();
                string command = inputCommandLine[0];
                switch (command)
                {
                    case "Forward":
                        int numberOfStepsF = int.Parse(inputCommandLine[1]);
                        currentPosition = Forward(numberOfStepsF, currentPosition, houseNumbers);
                        break;
                    case "Back":
                        int numberOfStepsB = int.Parse(inputCommandLine[1]);
                        currentPosition = Back(numberOfStepsB, currentPosition, houseNumbers);
                        break;
                    case "Gift":
                        int index = int.Parse(inputCommandLine[1]);
                        int houseNumber = int.Parse(inputCommandLine[2]);
                        currentPosition = Gift(index, houseNumber, currentPosition, houseNumbers);
                        break;
                    case "Swap":
                        int numberOfFirstHouse = int.Parse(inputCommandLine[1]);
                        int numberOfSecondHouse = int.Parse(inputCommandLine[2]);
                        Swap(numberOfFirstHouse, numberOfSecondHouse, houseNumbers);
                        break;

                    default: break;
                }
            }
            Console.WriteLine($"Position: {currentPosition}");
            Console.WriteLine(string.Join(", ", houseNumbers));
        }

        private static void Swap(int numberOfFirstHouse, int numberOfSecondHouse, List<int> houseNumbers)
        {
            int indexOfFirst = houseNumbers.IndexOf(numberOfFirstHouse);
            int indexOfSecond = houseNumbers.IndexOf(numberOfSecondHouse);

            if (indexOfFirst >= 0 && indexOfSecond >= 0)
            {
                int temp = houseNumbers[indexOfFirst];
                houseNumbers[indexOfFirst] = houseNumbers[indexOfSecond];
                houseNumbers[indexOfSecond] = temp;
            }
        }

        private static int Gift(int index, int houseNumber, int currentPosition, List<int> houseNumbers)
        {
            if (PositionExist(index, houseNumbers))
            {
                houseNumbers.Insert(index, houseNumber);
                currentPosition = index;
            }
            return currentPosition;
        }

        private static int Back(int numberOfStepsB, int currentPosition, List<int> houseNumbers)
        {
            int endposition = currentPosition - numberOfStepsB;
            if (PositionExist(endposition, houseNumbers))
            {                
                    houseNumbers.RemoveAt(endposition);
                    currentPosition = endposition;
                
            }
            return currentPosition;
        }

        private static int Forward(int numberOfStepsF, int currentPosition, List<int> houseNumbers)
        {
            int endposition = currentPosition + numberOfStepsF;
            if (PositionExist(endposition, houseNumbers))
            {
                    houseNumbers.RemoveAt(endposition);
                    currentPosition = endposition;              

            }
            return currentPosition;
        }

        private static bool PositionExist(int index, List<int> houseNumbers)
        {
            bool isPositionExist = true;
            if (index < 0 || index > houseNumbers.Count - 1)
            {
                isPositionExist = false;
            }
            
            return isPositionExist;
        }
    }
}
