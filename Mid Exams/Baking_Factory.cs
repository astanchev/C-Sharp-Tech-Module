using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Baking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bestBatch = new List<int>();
            int bestTotalQuality = int.MinValue;
            double greaterAverageQuality = double.MinValue;
            int smallestLenght = int.MaxValue;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Bake It!")
                {
                    break;
                }
                List<int> breadsQuality = input
                                           .Split("#",StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToList();

                int currentTotalQuality = breadsQuality.Sum();
                double currentAverageQuality = breadsQuality.Average();
                int currentLenght = breadsQuality.Count;
                bool isCurrentBigger = false;

                if (currentTotalQuality > bestTotalQuality)
                {
                    isCurrentBigger = true;
                }
                else if (currentTotalQuality == bestTotalQuality)
                {
                    if (currentAverageQuality > greaterAverageQuality)
                    {
                        isCurrentBigger = true;
                    }
                    else if (currentAverageQuality == greaterAverageQuality)
                    {
                        if (currentLenght < smallestLenght)
                        {
                            isCurrentBigger = true;
                        }
                    }
                }

                if (isCurrentBigger)
                {
                    bestBatch = breadsQuality;
                    bestTotalQuality = currentTotalQuality;
                    greaterAverageQuality = currentAverageQuality;
                    smallestLenght = currentLenght;
                }
            }
            Console.WriteLine($"Best Batch quality: {bestTotalQuality}");
            Console.WriteLine(string.Join(" ", bestBatch));
        }
    }
}
