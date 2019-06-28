using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToUpper().ToCharArray();

            string tempString = string.Empty;
            int repetition = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {                
                if (!char.IsDigit(input[i]))
                {
                    tempString += input[i];
                }
                else if (char.IsDigit(input[i]))
                {
                    
                    if (i < input.Length - 1 && char.IsDigit(input[i + 1]))
                    {
                        repetition += (input[i] - 48)*10 + (input[i + 1]-48);
                    }
                    else
                    {
                        repetition += input[i] - 48;
                    }

                    if (repetition == 0)
                    {
                        tempString = string.Empty;                                               
                    }
                    else
                    {
                        for (int j = 0; j < repetition; j++)
                        {
                            result.Append(tempString);
                        }
                        tempString = string.Empty;
                        repetition = 0;
                    }                    
                }
            }

            string resultString = result.ToString();
            int uniqueSymbolsCounter = resultString.Distinct().Count();            
            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCounter}");
            Console.WriteLine(resultString);

        }
    }
}
