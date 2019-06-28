using System;

namespace _11._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                            .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string puzzle = input[i];
                char firstChar = puzzle[0];
                char lastChar = puzzle[puzzle.Length - 1];
                string numberString = puzzle.Substring(1, puzzle.Length - 2);
                long number = long.Parse(numberString);
                int positionFirst = 0;
                int positionSecond = 0;
                decimal tempResult = 0;

                if (char.IsUpper(firstChar))
                {
                    positionFirst = firstChar - 64;
                    tempResult = number * 1.0M / positionFirst;
                }
                else if (char.IsLower(firstChar))
                {
                    positionFirst = firstChar - 96;
                    tempResult = number * 1.0M * positionFirst;
                }

                if (char.IsUpper(lastChar))
                {
                    positionSecond = lastChar - 64;
                    tempResult -= positionSecond;
                }
                else if (char.IsLower(lastChar))
                {
                    positionSecond = lastChar - 96;
                    tempResult += positionSecond;
                }

                totalSum += tempResult;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
