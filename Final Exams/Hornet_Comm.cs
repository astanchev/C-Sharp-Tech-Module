using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternMessage = @"^(\d+) \<\-\> ([0-9]+|[0-9A-Za-z]+)$";
            string patternBroadcast = @"^(\D+) \<\-\> ([A-Za-z]+|[A-Za-z0-9]+)$";
            Regex rgMessage = new Regex(patternMessage);
            Regex rgBroadcast = new Regex(patternBroadcast);
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }

                if (rgMessage.IsMatch(input))
                {
                    string recepient = rgMessage.Match(input).Groups[1].Value;
                    string message = rgMessage.Match(input).Groups[2].Value;
                    StringBuilder output = new StringBuilder();
                    for (int i = recepient.Length - 1; i >= 0; i--)
                    {
                        output.Append(recepient[i]);
                    }

                    string newRecepient = output.ToString();

                    string readyMessage = newRecepient + " -> " + message;
                    messages.Add(readyMessage);
                }
                else if (rgBroadcast.IsMatch(input))
                {
                    string message = rgBroadcast.Match(input).Groups[1].Value;
                    string frequency = rgBroadcast.Match(input).Groups[2].Value;
                    StringBuilder output = new StringBuilder();
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        char symb = frequency[i];
                        char newSymb = ' ';
                        if (char.IsLower(symb))
                        {
                            //newSymb = symb.ToString().ToUpper().ToCharArray()[0];
                            newSymb = char.ToUpper(symb);
                        }
                        else if (char.IsUpper(symb))
                        {
                            //newSymb = symb.ToString().ToLower().ToCharArray()[0];
                            newSymb = char.ToLower(symb);
                        }
                        else
                        {
                            newSymb = symb;
                        }
                        output.Append(newSymb);
                    }

                    string newFrequancy = output.ToString();

                    string readyBroadcast = newFrequancy + " -> " + message;
                    broadcasts.Add(readyBroadcast);
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine(broadcast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
