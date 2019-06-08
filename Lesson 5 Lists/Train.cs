using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                List<string> inputCommand = input.Split().ToList();
                if (inputCommand.Count > 1)
                {
                    int passengersInNewWagon = int.Parse(inputCommand[1]);
                    wagons.Add(passengersInNewWagon);
                }
                else
                {
                    int passengersToAdd = int.Parse(inputCommand[0]);

                    for (int wagon = 0; wagon < wagons.Count; wagon++)
                    {
                        int availableSeats = maxCapacity - wagons[wagon];
                        if (passengersToAdd <= availableSeats)
                        {
                            wagons[wagon] += passengersToAdd;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
