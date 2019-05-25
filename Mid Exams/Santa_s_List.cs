using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> noisyKids = Console.ReadLine()
                                     .Split('&').ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finished!")
                {
                    break;
                }
                string[] commandLine = input.Split();
                string command = commandLine[0];
                string kidName = commandLine[1];

                switch (command)
                {
                    case "Bad":
                        Bad(kidName, noisyKids);
                        break;
                    case "Good":
                        Good(kidName, noisyKids);
                        break;
                    case "Rename":
                        string newKidName = commandLine[2];
                        Rename(kidName, newKidName, noisyKids);
                        break;
                    case "Rearrange":
                        Rearrange(kidName, noisyKids);
                        break;
                    default: break;
                }
            }
            Console.WriteLine(string.Join(", ", noisyKids));
        }

        private static void Rename(string kidName, string newKidName, List<string> noisyKids)
        {
            if (IsKidExist(kidName, noisyKids))
            {
                int indexKidName = noisyKids.IndexOf(kidName);
                noisyKids[indexKidName] = newKidName;
            }
        }

        private static void Rearrange(string kidName, List<string> noisyKids)
        {
            if (IsKidExist(kidName, noisyKids))
            {
                noisyKids.Remove(kidName);
                noisyKids.Add(kidName);
            }
        }

        private static void Good(string kidName, List<string> noisyKids)
        {
            if (IsKidExist(kidName, noisyKids))
            {
                noisyKids.Remove(kidName);
            }
        }

        private static void Bad(string kidName, List<string> noisyKids)
        {
            if (!IsKidExist(kidName, noisyKids))
            {
                noisyKids.Insert(0, kidName);
            }
        }

        private static bool IsKidExist(string kidName, List<string> noisyKids)
        {
            bool isKidExist = false;
            foreach (var kid in noisyKids)
            {
                if (kid == kidName)
                {
                    isKidExist = true;
                }
            }
            return isKidExist;
        }
    }
}
