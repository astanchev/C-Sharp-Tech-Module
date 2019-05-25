using System;
using System.Linq;

namespace _02._Kamino_Factory_04._03._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            int[] bestDNA = new int[dnaLenght];
            int longestSubOfOnesLenght = -1;
            int leftmostIndex = -1;
            int greaterSum = 0;
            int bestDNAInputOrder = 0;
            int currentDNAInputOrder = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] currentDNA = input
                                  .Split('!', StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();
                currentDNAInputOrder++;

                int tempSubOfOnes = 0;
                int maxcurrentSubOfOnesLenght = 0;
                int endIndexcurrentSubOfOnesLenght = -1;

                for (int i = 0; i < dnaLenght; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        tempSubOfOnes++;
                        if (tempSubOfOnes > maxcurrentSubOfOnesLenght)
                        {
                            maxcurrentSubOfOnesLenght = tempSubOfOnes;
                            endIndexcurrentSubOfOnesLenght = i;
                        }
                    }
                    else
                    {
                        tempSubOfOnes = 0;
                    }
                }

                int firstIndexMaxCurrentSub = endIndexcurrentSubOfOnesLenght
                                                - maxcurrentSubOfOnesLenght + 1;
                int currentDNASum = currentDNA.Sum();
                bool isCurrentDNABest = false;

                if (maxcurrentSubOfOnesLenght > longestSubOfOnesLenght)
                {
                    isCurrentDNABest = true;
                }
                else if (maxcurrentSubOfOnesLenght == longestSubOfOnesLenght)
                {
                    if (firstIndexMaxCurrentSub < leftmostIndex)
                    {
                        isCurrentDNABest = true;
                    }
                    else if (firstIndexMaxCurrentSub == leftmostIndex)
                    {
                        if (currentDNASum > greaterSum)
                        {
                            isCurrentDNABest = true;
                        }
                    }
                }

                if (isCurrentDNABest)
                {
                    longestSubOfOnesLenght = maxcurrentSubOfOnesLenght;
                    leftmostIndex = firstIndexMaxCurrentSub;
                    greaterSum = currentDNASum;
                    bestDNA = currentDNA;
                    bestDNAInputOrder = currentDNAInputOrder;
                }
            }

            Console.WriteLine($"Best DNA sample {bestDNAInputOrder} with sum: {greaterSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
