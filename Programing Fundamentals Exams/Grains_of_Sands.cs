using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Grains_of_Sands_27._08._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sandGrains = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Mort")
                {
                    break;
                }
                string[] inputLine = input.Split();
                string command = inputLine[0];
                int value = int.Parse(inputLine[1]);

                switch (command)
                {
                    case "Add":
                        sandGrains.Add(value);
                        break;
                    case "Remove":
                        Remove(value, sandGrains);
                        break;
                    case "Replace":
                        int replacement = int.Parse(inputLine[2]);
                        Replace(value, replacement, sandGrains);
                        break;
                    case "Increase":
                        Increase(value, sandGrains);
                        break;
                    case "Collapse":
                        Collapse(value, sandGrains);
                        break;

                    default: break;
                }
            }
            Console.WriteLine(string.Join(" ", sandGrains));
        }

        private static void Collapse(int value, List<int> sandGrains)
        {
            for (int i = 0; i < sandGrains.Count; i++)
            {
                if (sandGrains[i] < value)
                {
                    sandGrains.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void Increase(int value, List<int> sandGrains)
        {
            bool isElementExist = false;
            int index = -1;
            int increaseValue = 0;

            foreach (var watch in sandGrains)
            {
                if (watch >= value)
                {
                    isElementExist = true;
                    index = sandGrains.IndexOf(watch);
                    break;
                }
            }

            if (isElementExist)
            {
                increaseValue = sandGrains[index];
            }
            else
            {
                increaseValue = sandGrains[sandGrains.Count - 1];
            }

            for (int i = 0; i < sandGrains.Count; i++)
            {
                sandGrains[i] += increaseValue;
            }

        }

        private static void Replace(int value, int replacement, List<int> sandGrains)
        {
            if (sandGrains.Contains(value))
            {
                int index = sandGrains.IndexOf(value);
                sandGrains[index] = replacement;
            }
            else
            {
                return;
            }
        }

        private static void Remove(int value, List<int> sandGrains)
        {
            if (sandGrains.Contains(value))
            {
                sandGrains.Remove(value);
            }
            else if (value > 0 && value < sandGrains.Count)
            {
                sandGrains.RemoveAt(value);
            }
            else
            {
                return;
            }
        }
    }
}
