using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> message = Console.ReadLine().Split().ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }

                string command = input.Split()[0];
                switch (command)
                {
                    case "Delete":
                        {
                            int index = int.Parse(input.Split()[1]);
                            if (index + 1 >= 0 && index + 1 <= message.Count - 1)
                            {
                                message.RemoveAt(index + 1);
                            }
                        }
                        break;
                    case "Swap":
                        {
                            string word1 = input.Split()[1];
                            string word2 = input.Split()[2];
                            if (message.Contains(word1) && message.Contains(word2))
                            {
                                int index1 = message.IndexOf(word1);
                                int index2 = message.IndexOf(word2);
                                message[index1] = word2;
                                message[index2] = word1;
                            }
                        }
                        break;
                    case "Put":
                        {
                            string word = input.Split()[1];
                            int index = int.Parse(input.Split()[2]);
                            if (index - 1 >= 0 && index - 1 <= message.Count)
                            {
                                message.Insert(index - 1, word);
                            }
                        }
                        break;
                    case "Sort":
                        {
                            message.Sort();
                            message.Reverse();
                        }
                        break;
                    case "Replace":
                        {
                            string word1 = input.Split()[1];
                            string word2 = input.Split()[2];
                            if (message.Contains(word2))
                            {
                                int index = message.IndexOf(word2);
                                message[index] = word1;
                            }
                        }
                        break;
                    default: break;
                }


            }

            Console.WriteLine(string.Join(" ", message));
        }
    }
}
