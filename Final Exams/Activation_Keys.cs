using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = Console.ReadLine().Split('&');
            List<string> outputKeys = new List<string>();
            string pattern = @"^([A-Za-z0-9]+)$";
            Regex rg = new Regex(pattern);

            for (int i = 0; i < keys.Length; i++)
            {
                string key = keys[i];
                StringBuilder currentkey = new StringBuilder();
                if (key.Length == 16 && rg.IsMatch(key))
                {
                    for (int j = 0, k = 1; j < key.Length; j++, k++)
                    {
                        char symb = key[j];
                        string newSymb = symb.ToString();
                        if (char.IsDigit(symb))
                        {
                            newSymb = (9 - (symb - 48)).ToString();
                        }
                        else if (char.IsLower(symb))
                        {
                            newSymb = Char.ToUpper(symb).ToString();
                        }

                        if (k % 4 == 0 && k < 16)
                        {
                            currentkey.Append(newSymb);
                            currentkey.Append('-');
                        }
                        else
                        {
                            currentkey.Append(newSymb);
                        }
                    }
                    outputKeys.Add(currentkey.ToString());
                }
                else if (key.Length == 25 && rg.IsMatch(key))
                {
                    for (int j = 0, k = 1; j < key.Length; j++, k++)
                    {
                        char symb = key[j];
                        string newSymb = symb.ToString();
                        if (char.IsDigit(symb))
                        {
                            newSymb = (9 - (symb - 48)).ToString();
                        }
                        else if (char.IsLower(symb))
                        {
                            newSymb = Char.ToUpper(symb).ToString();
                        }

                        if (k % 5 == 0 && k < 25)
                        {
                            currentkey.Append(newSymb);
                            currentkey.Append('-');
                        }
                        else
                        {
                            currentkey.Append(newSymb);
                        }
                    }
                    outputKeys.Add(currentkey.ToString());
                }
                else
                {
                    continue;
                }
            }

            if (outputKeys.Count>0)
            {
                Console.WriteLine(string.Join(", ", outputKeys));
            }
            

        }
    }
}
