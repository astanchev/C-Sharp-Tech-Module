using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kidsList = Console.ReadLine().Split('&').ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finished!")
                {
                    break;
                }

                string command = input.Split()[0];
                if (command == "Bad")
                {
                    string kidName = input.Split()[1];
                    if (!kidsList.Contains(kidName))
                    {
                        kidsList.Insert(0, kidName);
                    }
                }
                else if (command == "Good")
                {
                    string kidName = input.Split()[1];
                    if (kidsList.Contains(kidName))
                    {
                        kidsList.Remove(kidName);
                    }
                }
                else if (command == "Rename")
                {
                    string oldName = input.Split()[1];
                    string newName = input.Split()[2];
                    if (kidsList.Contains(oldName))
                    {
                        int index = kidsList.IndexOf(oldName);
                        kidsList.Remove(oldName);
                        kidsList.Insert(index, newName);
                    }
                }
                else if (command == "Rearrange")
                {
                    string kidName = input.Split()[1];
                    if (kidsList.Contains(kidName))
                    {
                        kidsList.Remove(kidName);
                        kidsList.Add(kidName);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", kidsList));
        }
    }
}
