using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([A-Z][a-z'\s]+):([A-Z ]+)$";
            Regex rg = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                if (!rg.IsMatch(input))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int key = input.Split(':')[0].Length;
                    StringBuilder output = new StringBuilder();

                    foreach (var symb in input)
                    {
                        if (symb == ' ')
                        {
                            output.Append(' ');
                        }
                        else if (symb == '\'')
                        {
                            output.Append('\'');
                        }
                        else if (symb == ':')
                        {
                            output.Append('@');
                        }
                        else if (char.IsUpper(symb))
                        {
                            char newSymb = (char)(symb + key);
                            if (newSymb > 'Z')
                            {
                                newSymb = (char) (64 + (newSymb - 90));
                            }
                            output.Append(newSymb);
                        }
                        else if (char.IsLower(symb))
                        {
                            char newSymb = (char)(symb + key);
                            if (newSymb > 'z')
                            {
                                newSymb = (char)(96 + (newSymb - 122));
                            }
                            output.Append(newSymb);
                        }
                    }

                    Console.WriteLine($"Successful encryption: {output}");

                }

            }

        }
    }
}
