﻿using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            result.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i-1])
                {
                    continue;
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
