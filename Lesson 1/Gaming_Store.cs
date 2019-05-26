using System;

namespace _3._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double startingBalance = currentBalance;
            double price = 0.0;

            while (true)
            {
                string game = Console.ReadLine();
                if (game == "Game Time")
                {
                    break;
                }
                switch (game)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if (price > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= price;
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${startingBalance - currentBalance:f2}. Remaining: ${currentBalance:f2}");



        }
    }
}
