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
                string[] commandLine = input.Split(" - ");
                string command = commandLine[0];
                string quest = commandLine[1];
                switch (command)
                {
                    case "Start":
                        Start(quest, quests);
                        break;
                    case "Complete":
                        Complete(quest, quests);
                        break;
                    case "Side Quest":
                        SideQuest(quest, quests);
                        break;
                    case "Renew":
                        Renew(quest, quests);
                        break;
                    default: break;
                }
            }

            Console.WriteLine(string.Join(", ", quests));
        }

        private static void SideQuest(string quest, List<string> quests)
        {
            string[] sideQuestLine = quest.Split(':');
            string sideQuestParent = sideQuestLine[0];
            string sideQuestChild = sideQuestLine[1];
            if (IsQuestExist(sideQuestParent, quests) && !IsQuestExist(sideQuestChild, quests))
            {
                int indexOfParent = quests.IndexOf(sideQuestParent);
                quests.Insert(indexOfParent + 1, sideQuestChild);
            }
            else
            {
                return;
            }
        }

        private static void Renew(string quest, List<string> quests)
        {
            if (IsQuestExist(quest, quests))
            {
                quests.Remove(quest);
                quests.Add(quest);
            }
            else
            {
                return;
            }
        }

        private static void Complete(string quest, List<string> quests)
        {
            if (IsQuestExist(quest, quests))
            {
                quests.Remove(quest);
            }
            else
            {
                return;
            }
        }

        private static void Start(string quest, List<string> quests)
        {
            if (IsQuestExist(quest, quests))
            {
                return;
            }
            else
            {
                quests.Add(quest);
            }
        }

        private static bool IsQuestExist(string quest, List<string> quests)
        {
            bool isQuestExist = false;
            foreach (var item in quests)
            {
                if (item == quest)
                {
                    isQuestExist = true;
                }
            }
            return isQuestExist;
        }
    }
}
