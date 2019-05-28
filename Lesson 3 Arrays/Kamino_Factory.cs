using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] bestDNA = new int[length];
            int bestLenghtOfOnes = -1;
            int bestFirstIndex = -1;
            int bestSumDNA = 0;
            int bestSampleIndex = 0;
            int currentSampleIndex = 0;

            while (true)
            {
                string dnaSample = Console.ReadLine();
                if (dnaSample == "Clone them!")
                {
                    break;
                }

                int[] dnaLine = dnaSample.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                //Тази форма на Split се използва защото '!' могат да бъдат повече от един
                int maxCurrentLenghtOfOnes = 0;
                int currentEndIndex = 0;                
                int currentLenghtOfOnes = 0;

                for (int i = 0; i < dnaLine.Length; i++)
                {
                    if (dnaLine[i] == 1)
                    {
                        currentLenghtOfOnes++;
                        if (currentLenghtOfOnes > maxCurrentLenghtOfOnes)
                        {
                            currentEndIndex = i;
                            maxCurrentLenghtOfOnes = currentLenghtOfOnes;                            
                        }
                    }
                    else
                    {
                        currentLenghtOfOnes = 0;
                    }
                }

                int currentStartIndex = currentEndIndex - maxCurrentLenghtOfOnes + 1;

                bool isCurrentDnaBetter = false;
                int currentSumDNA = dnaLine.Sum();
                
                if (maxCurrentLenghtOfOnes > bestLenghtOfOnes)
                {
                    isCurrentDnaBetter = true;
                }
                else if (maxCurrentLenghtOfOnes == bestLenghtOfOnes)
                {
                    if (currentStartIndex < bestFirstIndex)
                    {
                        isCurrentDnaBetter = true;
                    }
                    else if (currentStartIndex == bestFirstIndex)
                    {
                        if (currentSumDNA > bestSumDNA)
                        {
                            isCurrentDnaBetter = true;
                        }
                    }
                }
                
                currentSampleIndex++;

                if (isCurrentDnaBetter)
                {
                    bestDNA = dnaLine;
                    bestLenghtOfOnes = maxCurrentLenghtOfOnes;
                    bestFirstIndex = currentStartIndex;
                    bestSumDNA = currentSumDNA;
                    bestSampleIndex = currentSampleIndex;
                }                
            }
            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestSumDNA}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
