using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Vapor_Winter_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> gamePrice = new Dictionary<string, double>();
            Dictionary<string, string> gameDLC = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains('-'))
                {
                    string gameName = input[i].Split('-')[0];
                    double priceGame = double.Parse(input[i].Split('-')[1]);

                    if (!gamePrice.ContainsKey(gameName))
                    {
                        gamePrice[gameName] = 0.0;
                    }

                    gamePrice[gameName] = priceGame;

                }
                else if (input[i].Contains(':'))
                {
                    string gameName = input[i].Split(':')[0];
                    string gameDLCName = input[i].Split(':')[1];

                    if (gamePrice.ContainsKey(gameName))
                    {
                        gameDLC[gameName] = gameDLCName;
                        gamePrice[gameName] *= 1.2;
                    }
                }
            }

            var gamesWithDLCPrice = new Dictionary<string, double>();
            var gamesWithoutDLCPrice = new Dictionary<string, double>();

            foreach (var game in gamePrice)
            {
                string name = game.Key;
                if (gameDLC.ContainsKey(name))
                {
                    gamesWithDLCPrice[name] = game.Value * 0.5;
                }
                else
                {
                    gamesWithoutDLCPrice[name] = game.Value * 0.8;
                }
            }

            if (gamesWithDLCPrice.Count > 0)
            {
                foreach (var game in gamesWithDLCPrice.OrderBy(g => g.Value))
                {
                    Console.WriteLine($"{game.Key} - {gameDLC[game.Key]} - {game.Value:f2}");
                }
            }
            if (gamesWithoutDLCPrice.Count > 0)
            {
                foreach (var game in gamesWithoutDLCPrice.OrderByDescending(g => g.Value))
                {
                    Console.WriteLine($"{game.Key} - {game.Value:f2}");
                }
            }
        }
    }
}
