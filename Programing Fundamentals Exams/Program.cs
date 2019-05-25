using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tseam_Account_25._04._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Play!")
                {
                    break;
                }
                string[] inputLine = input.Split();
                string command = inputLine[0];
                string game = inputLine[1];

                switch (command)
                {
                    case "Install":
                        Install(game, games);
                        break;
                    case "Uninstall":
                        Uninstal(game, games);
                        break;
                    case "Update":
                        Update(game, games);
                        break;
                    case "Expansion":
                        string[] gameExpansion = game.Split('-');
                        string gameName = gameExpansion[0];
                        string expansion = gameExpansion[1];
                        Expansion(gameName, expansion, games);
                        break;

                    default: break;
                }
            }

            Console.WriteLine(string.Join(" ", games));
        }

        private static void Expansion(string gameName, string expansion, List<string> games)
        {
            if (games.Contains(gameName))
            {
                int index = games.IndexOf(gameName);
                string newExpansion = gameName + ":" + expansion;
                games.Insert(index+1, newExpansion);
            }
        }

        private static void Update(string game, List<string> games)
        {
            if (games.Contains(game))
            {
                games.Remove(game);
                games.Add(game);
            }
        }

        private static void Uninstal(string game, List<string> games)
        {
            if (games.Contains(game))
            {
                games.Remove(game);
            }
        }

        private static void Install(string game, List<string> games)
        {
            if (!games.Contains(game))
            {
                games.Add(game);
            }
        }
    }
}
