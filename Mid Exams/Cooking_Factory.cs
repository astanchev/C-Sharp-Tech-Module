using System;
using System.Linq;

namespace _03._Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bestBatch = new int[1];
            int highestTotalQuality = int.MinValue;
            double greaterAverage = Double.MinValue;
            int fewestElements = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Bake It!")
                {
                    break;
                }

                int[] currentBatch = input
                                         .Split('#')
                                         .Select(int.Parse)
                                         .ToArray();
                int currentTotalQuality = currentBatch.Sum();
                double currentAverage = currentBatch.Average();
                int currentElements = currentBatch.Length;
                bool isCurrentBatchBest = false;

                if (currentTotalQuality > highestTotalQuality)
                {
                    isCurrentBatchBest = true;
                }
                else if (currentTotalQuality == highestTotalQuality)
                {
                    if (currentAverage > greaterAverage)
                    {
                        isCurrentBatchBest = true;
                    }
                    else if (currentAverage == greaterAverage)
                    {
                        if (currentElements < fewestElements)
                        {
                            isCurrentBatchBest = true;
                        }
                    }
                }

                if (isCurrentBatchBest)
                {
                    highestTotalQuality = currentTotalQuality;
                    greaterAverage = currentAverage;
                    fewestElements = currentElements;
                    bestBatch = currentBatch;
                }
            }

            Console.WriteLine($"Best Batch quality: {bestBatch.Sum()}");
            Console.WriteLine(string.Join(" ", bestBatch));
        }
    }
}
