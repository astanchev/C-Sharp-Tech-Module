using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSetPowers = Console.ReadLine()
                                          .Split()
                                          .Select(int.Parse)
                                          .ToList();
            List<int> initialDrumSetPowers = new List<int>();
            for (int i = 0; i < drumSetPowers.Count; i++)
            {
                initialDrumSetPowers.Add(drumSetPowers[i]);
            }
            
            while (true)
            {
                string inputMassage = Console.ReadLine();
                if (inputMassage == "Hit it again, Gabsy!")
                {
                    break;
                }
                int decreasepower = int.Parse(inputMassage);
                for (int i = 0; i < drumSetPowers.Count; i++)
                {
                    int drumPower = drumSetPowers[i];
                    if (decreasepower >= drumPower)
                    {
                        int priceForRepair = initialDrumSetPowers[i] * 3;
                        if (priceForRepair <= savings)
                        {
                            drumSetPowers[i] = initialDrumSetPowers[i];
                            savings -= priceForRepair;
                        }
                        else
                        {
                            drumSetPowers.RemoveAt(i);
                            initialDrumSetPowers.RemoveAt(i);
                            i--;
                        }
                    }
                    else
                    {
                        drumSetPowers[i] -= decreasepower;
                    }
                }



            }

            Console.WriteLine(string.Join(" ", drumSetPowers));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
