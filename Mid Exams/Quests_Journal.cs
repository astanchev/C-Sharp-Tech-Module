using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Retire!")
                {
                    break;
                }

                string command = input.Split(" - ")[0];
                if (command == "Start")
                {
                    string quest = input.Split(" - ")[1];
                    if (!quests.Contains(quest))
                    {
                        quests.Add(quest);
                    }
                }
                else if (command == "Complete")
                {
                    string quest = input.Split(" - ")[1];
                    if (quests.Contains(quest))
                    {
                        quests.Remove(quest);
                    }
                }
                else if (command == "Side Quest")
                {
                    string quest = input.Split(" - ")[1].Split(':')[0];
                    string sideQuest = input.Split(" - ")[1].Split(':')[1];
                    if (quests.Contains(quest) && !quests.Contains(sideQuest))
                    {
                        int index = quests.IndexOf(quest);
                        quests.Insert(index + 1, sideQuest);
                    }
                }
                else if (command == "Renew")
                {
                    string quest = input.Split(" - ")[1];
                    if (quests.Contains(quest))
                    {
                        quests.Remove(quest);
                        quests.Add(quest);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", quests));
        }
    }
}
