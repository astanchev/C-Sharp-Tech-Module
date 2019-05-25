using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> childAmount = new Dictionary<string, int>();
            Dictionary<string, int> presentAmount = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] inputLine = input.Split("->");

                if (inputLine.Length == 3)
                {
                    string childName = inputLine[0];
                    string typeOfPresent = inputLine[1];
                    int amount = int.Parse(inputLine[2]);

                    if (!childAmount.ContainsKey(childName))
                    {
                        childAmount[childName] = amount;
                    }
                    else
                    {
                        childAmount[childName] += amount;
                    }

                    if (!presentAmount.ContainsKey(typeOfPresent))
                    {
                        presentAmount[typeOfPresent] = amount;
                    }
                    else
                    {
                        presentAmount[typeOfPresent] += amount;
                    }

                }
                else
                {
                    string childName = inputLine[1];

                    if (childAmount.ContainsKey(childName))
                    {
                        childAmount.Remove(childName);
                    }
                }
            }

            Console.WriteLine("Children:");
            foreach (var child in childAmount
                                    .OrderByDescending(c=>c.Value)
                                    .ThenBy(c=>c.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }

            Console.WriteLine("Presents:");
            foreach (var present in presentAmount)
            {
                Console.WriteLine($"{present.Key} -> {present.Value}");
            }


        }
    }
}
