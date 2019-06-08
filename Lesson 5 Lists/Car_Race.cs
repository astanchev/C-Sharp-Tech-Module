using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> timesArray = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            double sumFirstTimes = 0;
            double sumSecondTimes = 0;

            for (int i = 0; i < timesArray.Count / 2; i++)
            {
                int time1 = timesArray[i];
                int time2 = timesArray[timesArray.Count - 1 - i];
                if (time1 == 0)
                {
                    sumFirstTimes *= 0.8;
                }
                else
                {
                    sumFirstTimes += time1;
                }
                if (time2 == 0)
                {
                    sumSecondTimes *= 0.8;
                }
                else
                {
                    sumSecondTimes += time2;
                }
            }

            if (sumFirstTimes <= sumSecondTimes)
            {
                Console.WriteLine($"The winner is left with total time: {sumFirstTimes}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumSecondTimes}");
            }
        }
    }
}
