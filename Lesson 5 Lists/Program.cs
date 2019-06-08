using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();

            List<char> chars = new List<char>();
            List<int> digits = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                char element = input[i];
                if (char.IsDigit(element))
                {
                    int digit = element - 48;
                    digits.Add(digit);
                }
                else
                {
                    chars.Add(element);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < digits.Count; i++)
            {
                int digit = digits[i];
                if (i % 2 == 0)
                {
                    takeList.Add(digit);
                }
                else
                {
                    skipList.Add(digit);
                }
            }

            List<char> result = new List<char>();

            int indexTakeSkip = 0;

            while (true)
            {
                if (indexTakeSkip > takeList.Count - 1 || chars.Count < 1)
                {
                    break;
                }
                if (takeList[indexTakeSkip] > chars.Count)
                {
                    result.AddRange(chars.Take(takeList[chars.Count]));
                }
                else
                {
                    result.AddRange(chars.Take(takeList[indexTakeSkip]));
                }

                int range = takeList[indexTakeSkip] + skipList[indexTakeSkip];
                if (range < chars.Count)
                {
                    chars.RemoveRange(0, range);
                }
                else
                {
                    chars.RemoveRange(0, chars.Count);
                }
                indexTakeSkip++;

            }

            Console.WriteLine(string.Join("", result));
        }


    }
}
