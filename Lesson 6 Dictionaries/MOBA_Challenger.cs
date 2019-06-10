using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerPositionSkill =
                new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }

                if (input.Contains(" -> "))
                {
                    string[] inputLine = input.Split(" -> ");
                    string player = inputLine[0];
                    string position = inputLine[1];
                    int skill = int.Parse(inputLine[2]);

                    if (!playerPositionSkill.ContainsKey(player))
                    {
                        playerPositionSkill[player] = new Dictionary<string, int>();
                    }
                    if (!playerPositionSkill[player].ContainsKey(position))
                    {
                        playerPositionSkill[player][position] = skill;
                    }
                    else
                    {
                        if (skill > playerPositionSkill[player][position])
                        {
                            playerPositionSkill[player][position] = skill;
                        }
                    }
                }
                else if (input.Contains(" vs "))
                {
                    string[] inputLine = input.Split(" vs ");
                    string player1 = inputLine[0];
                    string player2 = inputLine[1];

                    if (playerPositionSkill.ContainsKey(player1)
                        && playerPositionSkill.ContainsKey(player2))
                    {
                        bool isCommonPosition = false;
                        foreach (var position in playerPositionSkill[player1])
                        {
                            foreach (var pos in playerPositionSkill[player2])
                            {
                                if (position.Key == pos.Key)
                                {
                                    isCommonPosition = true;
                                }
                            }
                        }

                        int sumSkill1 = playerPositionSkill[player1].Values.Sum();
                        int sumSkill2 = playerPositionSkill[player2].Values.Sum();

                        if (isCommonPosition)
                        {
                            if (sumSkill1 > sumSkill2)
                            {
                                playerPositionSkill.Remove(player2);
                            }
                            else if (sumSkill1 < sumSkill2)
                            {
                                playerPositionSkill.Remove(player1);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }

            foreach (var player in playerPositionSkill
                                    .OrderByDescending(p => p.Value.Values.Sum())
                                    .ThenBy(p => p.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var position in player.Value
                                         .OrderByDescending(pos => pos.Value)
                                         .ThenBy(pos => pos.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }

        }
    }
}
