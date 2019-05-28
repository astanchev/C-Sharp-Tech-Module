using System;
using System.Numerics;

namespace _02_2._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                string input = Console.ReadLine();
                string leftString = input.Substring(0, input.IndexOf(' '));
                string rightString = input.Substring(input.IndexOf(' ') + 1);
                long leftNumber = long.Parse(leftString);
                long rightNumber = long.Parse(rightString);
                if (leftNumber > rightNumber)
                {
                    long sumDigitsLeft = 0;
                    leftNumber = Math.Abs(leftNumber);
                    while (leftNumber > 0)
                    {
                        sumDigitsLeft += leftNumber % 10;
                        leftNumber = leftNumber / 10;
                    }
                    Console.WriteLine(sumDigitsLeft);
                }
                else
                {
                    long sumDigitsRight = 0;
                    rightNumber = Math.Abs(rightNumber);
                    while (rightNumber > 0)
                    {
                        sumDigitsRight += rightNumber % 10;
                        rightNumber = rightNumber / 10;
                    }
                    Console.WriteLine(Math.Abs(sumDigitsRight));
                }
            }
        }
    }
}
