using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hornet_Assault_23._02._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine()
                                    .Split()
                                    .Select(long.Parse)
                                    .ToList();
            List<long> hornets = Console.ReadLine()
                                    .Split()
                                    .Select(long.Parse)
                                    .ToList();

            long hornetPower = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                if (beehives[i] >= hornetPower)
                {
                    beehives[i] -= hornetPower;
                    hornets.RemoveAt(0);
                    hornetPower = hornets.Sum();
                    if (beehives[i] == 0)
                    {
                        beehives.RemoveAt(i);
                        i--;
                    }
                }
                else
                {
                    beehives.RemoveAt(i);
                    i--;
                }
            }

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
