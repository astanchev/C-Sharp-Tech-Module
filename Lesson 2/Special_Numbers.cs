﻿using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{num} -> True");
                }
                else
                {
                    Console.WriteLine($"{num} -> False");
                }
            }

        }
    }
}
