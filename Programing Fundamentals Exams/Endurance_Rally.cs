using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Endurance_Rally_6._01._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            double[] trackLayouts = Console.ReadLine()
                                .Split()
                                .Select(double.Parse)
                                .ToArray();
            int[] checkpoints = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            double[] leftFuel = new double[names.Length];
            int[] reachedZoneIndex = new int[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                double fuel = names[i][0];
                for (int j = 0; j < trackLayouts.Length; j++)
                {
                    if (IsCheckpoint(j, checkpoints))
                    {
                        fuel += trackLayouts[j];                        
                    }
                    else
                    {
                        fuel -= trackLayouts[j];
                        if (fuel <= 0)
                        {
                            leftFuel[i] = fuel;
                            reachedZoneIndex[i] = j;
                            break;
                        }                        
                    }
                    leftFuel[i] = fuel;
                    reachedZoneIndex[i] = j;
                }
            }
                        

            for (int i = 0; i < names.Length; i++)
            {
                if (leftFuel[i] > 0)
                {
                    Console.WriteLine($"{names[i]} - fuel left {leftFuel[i]:f2}");
                }
                else
                {
                    Console.WriteLine($"{names[i]} - reached {reachedZoneIndex[i]}");
                }
            }



        }


        private static bool IsCheckpoint(int j, int[] checkpoints)
        {
            foreach (var item in checkpoints)
            {
                if (item == j)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
