using System;
using System.Collections.Generic;

namespace _02._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatMessages = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] inputLine = input.Split();
                string command = inputLine[0];
                string message = inputLine[1];

                switch (command)
                {
                    case "Chat":
                        chatMessages.Add(message);
                        break;
                    case "Delete":
                        chatMessages.Remove(message);
                        break;
                    case "Edit":
                        string editedMessage = inputLine[2];
                        int index = chatMessages.IndexOf(message);
                        chatMessages[index] = editedMessage;
                        break;
                    case "Pin":
                        chatMessages.Remove(message);
                        chatMessages.Add(message);
                        break;
                    case "Spam":
                        for (int i = 1; i < inputLine.Length; i++)
                        {
                            chatMessages.Add(inputLine[i]);
                        }                                                    
                        break;
                    default: break;
                }
            }
            foreach (var chatMessage in chatMessages)
            {
                Console.WriteLine(chatMessage);
            }
        }
    }
}
