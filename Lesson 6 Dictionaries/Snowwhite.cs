using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameColorPhysics = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }
                string[] inputLine = input.Split(" <:> ");
                string name = inputLine[0];
                string color = inputLine[1];
                int physics = int.Parse(inputLine[2]);

                string colorName = name + ":" + color;

                if (!nameColorPhysics.ContainsKey(colorName))
                {
                    nameColorPhysics[colorName] = physics;
                }
                else
                {
                    if (physics > nameColorPhysics[colorName])
                    {
                        nameColorPhysics[colorName] = physics;
                    }
                }
            }

            foreach (var nameColor in nameColorPhysics
                                    .OrderByDescending(d => d.Value)
                                    .ThenByDescending(d => nameColorPhysics
                                                            .Where(c => c.Key.Split(':')[1] == d.Key.Split(':')[1])
                                                            .Count()))
            {                
                string name = nameColor.Key.Split(':')[0];
                string color = nameColor.Key.Split(':')[1];
                int physics = nameColor.Value;
                Console.WriteLine($"({color}) {name} <-> {physics}");
                
            }
        }
    }
}
