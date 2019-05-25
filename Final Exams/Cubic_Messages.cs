using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[0-9]+(?<message>[A-Za-z]+)[^A-Za-z]*$";
            Regex rg = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }

                int length = int.Parse(Console.ReadLine());
                if (rg.IsMatch(input))
                {
                    string message = rg.Match(input).Groups["message"].Value;
                    if (message.Length == length)
                    {
                        List<int> indexes = new List<int>();
                        foreach (var symb in input)
                        {
                            int index = 0;
                            if (char.IsDigit(symb))
                            {
                                index = symb - 48;
                                indexes.Add(index);
                            }
                        }

                        StringBuilder outputMessage = new StringBuilder();
                        for (int i = 0; i < indexes.Count; i++)
                        {
                            int index = indexes[i];
                            if (index > message.Length - 1)
                            {
                                outputMessage.Append(' ');
                            }
                            else
                            {
                                outputMessage.Append(message[index]);
                            }
                        }

                        Console.WriteLine($"{message} == {outputMessage}");
                    }
                }
            }
        }
    }
}
