using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();
            int index = 0;
            while (true)
            {
                if (firstPlayer.Count == 0 || secondPlayer.Count == 0)
                {
                    if (firstPlayer.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
                        return;
                    }
                    else if (secondPlayer.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
                        return;
                    }
                }

                if (firstPlayer[index] > secondPlayer[index])
                {
                    firstPlayer.Add(firstPlayer[index]);
                    firstPlayer.Remove(firstPlayer[index]);
                    firstPlayer.Add(secondPlayer[index]);
                    secondPlayer.Remove(secondPlayer[index]);
                    index = 0;
                }
                else if (firstPlayer[index] < secondPlayer[index])
                {
                    secondPlayer.Add(secondPlayer[index]);
                    secondPlayer.Add(firstPlayer[index]);
                    secondPlayer.Remove(secondPlayer[index]);
                    firstPlayer.Remove(firstPlayer[index]);
                    index = 0;
                }
                else
                {
                    firstPlayer.Remove(firstPlayer[index]);
                    secondPlayer.Remove(secondPlayer[index]);
                    index = 0;
                }
            }
        }
    }
}
