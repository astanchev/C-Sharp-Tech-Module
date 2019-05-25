using System;
using System.Text.RegularExpressions;

namespace _03._Chore_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternDishes = @"<(?<dishes>[a-z0-9]+)>";
            string patternCleaning = @"\[(?<cleaning>[A-Z0-9]+)\]";
            string patternLaundry = @"{(?<laundry>.+)}";

            Regex rgDishes = new Regex(patternDishes);
            Regex rgCleaning = new Regex(patternCleaning);
            Regex rgLaundry = new Regex(patternLaundry);

            int timeDishes = 0;
            int timeCleaning = 0;
            int timeLaundry = 0;
            int totalMinutes = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "wife is happy")
                {
                    break;
                }

                if (rgDishes.IsMatch(input))
                {
                    string doingTheDishes = rgDishes
                                                .Match(input)
                                                .Groups["dishes"]
                                                .Value;
                    
                    foreach (var symb in doingTheDishes)
                    {
                        if (char.IsDigit(symb))
                        {
                            timeDishes += symb - 48;
                        }
                    }
                }
                else if (rgCleaning.IsMatch(input))
                {
                    string cleaningTheHouse = rgCleaning
                                                .Match(input)
                                                .Groups["cleaning"]
                                                .Value;
                    
                    foreach (var symb in cleaningTheHouse)
                    {
                        if (char.IsDigit(symb))
                        {
                            timeCleaning += symb - 48;
                        }
                    }
                }
                else if (rgLaundry.IsMatch(input))
                {
                    string doingTheLaundry = rgLaundry
                                                .Match(input)
                                                .Groups["laundry"]
                                                .Value;
                    
                    foreach (var symb in doingTheLaundry)
                    {
                        if (char.IsDigit(symb))
                        {
                            timeLaundry += symb - 48;
                        }
                    }
                }
            }

            totalMinutes = timeDishes + timeCleaning + timeLaundry;

            Console.WriteLine($"Doing the dishes - {timeDishes} min.");
            Console.WriteLine($"Cleaning the house - {timeCleaning} min.");
            Console.WriteLine($"Doing the laundry - {timeLaundry} min.");
            Console.WriteLine($"Total - {totalMinutes} min.");
        }
    }
}
