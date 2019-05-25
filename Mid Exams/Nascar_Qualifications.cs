using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Nascar_Qualifications
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> racers = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string command = input.Split()[0];
                if (command == "Race")
                {
                    string racer = input.Split()[1];
                    if (!racers.Contains(racer))
                    {
                        racers.Add(racer);
                    }
                }
                else if (command == "Accident")
                {
                    string racer = input.Split()[1];
                    if (racers.Contains(racer))
                    {
                        racers.Remove(racer);
                    }
                }
                else if (command == "Box")
                {
                    string racer = input.Split()[1];
                    if (racers.Contains(racer))
                    {
                        int index = racers.IndexOf(racer);
                        if (index < racers.Count - 1)
                        {
                            racers.Remove(racer);
                            racers.Insert(index + 1, racer);
                        }
                    }
                }
                else if (command == "Overtake")
                {
                    string racer = input.Split()[1];
                    int racersCount = int.Parse(input.Split()[2]);
                    if (racers.Contains(racer))
                    {
                        int index = racers.IndexOf(racer);
                        index -= racersCount;
                        if (index >= 0)
                        {
                            racers.Remove(racer);
                            racers.Insert(index, racer);
                        }
                    }

                }
            }

            Console.WriteLine(string.Join(" ~ ", racers));
        }
    }
}
