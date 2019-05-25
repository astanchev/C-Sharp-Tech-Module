using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Snowmen_05._01._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            while (snowmen.Count > 1)
            {                
                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (snowmen.Count(s => s!= -1) == 1)
                    {
                        break;
                    }
                    int attacker = i;
                    if (snowmen[attacker] == -1)
                    {
                        continue;
                    }
                    int target = snowmen[attacker];
                    if (target > snowmen.Count - 1)
                    {
                        target = target % snowmen.Count;
                    }

                    int difference = Math.Abs(attacker - target);

                    if (difference == 0)
                    {
                        snowmen[attacker] = -1;
                        Console.WriteLine($"{attacker} performed harakiri");
                    }
                    else if (difference % 2 == 0)
                    {
                        snowmen[target] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    }
                    else
                    {
                        snowmen[attacker] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    }
                }

                snowmen = snowmen.Where(s => s != -1).ToList();

            }
        }
    }
}
