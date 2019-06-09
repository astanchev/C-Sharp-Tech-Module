using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();
            List<int> secondList = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            int firstBorder = 0;
            int secondBorder = 0;
            if (firstList.Count > secondList.Count)
            {
                secondBorder = firstList[firstList.Count - 1];
                firstBorder = firstList[firstList.Count - 2];
                firstList.RemoveRange(firstList.Count - 2, 2);
            }
            else
            {
                secondBorder = secondList[1];
                firstBorder =secondList[0];
                secondList.RemoveRange(0, 2);
            }

            if (firstBorder > secondBorder)
            {
                int temp = firstBorder;
                firstBorder = secondBorder;
                secondBorder = temp;
            }

            List<int> result = new List<int>();
            for (int i = 0; i < firstList.Count; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[secondList.Count - 1 - i]);
            }

            List<int> resultConstrainedList = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                int element = result[i];
                if (element > firstBorder && element < secondBorder)
                {
                    resultConstrainedList.Add(element);
                }
            }

            resultConstrainedList.Sort();
            Console.WriteLine(string.Join(" ", resultConstrainedList));

        }
    }
}
