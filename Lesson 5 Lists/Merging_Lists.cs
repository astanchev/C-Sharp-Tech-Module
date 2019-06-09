using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine()
                                .Split(' ')
                                .Select(double.Parse)
                                .ToList();

            List<double> secondList = Console.ReadLine()
                                .Split(' ')
                                .Select(double.Parse)
                                .ToList();

            List<double> resultList = new List<double>();
                       
            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                resultList.AddRange(GetExtraElements(firstList, secondList));
            }
            else
            {
                resultList.AddRange(GetExtraElements(secondList, firstList));
            }

            Console.WriteLine(string.Join(" ", resultList));
        }

        private static List<double> GetExtraElements(List<double> longerList, List<double> shorterList)
        {
            List<double> extraList = new List<double>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                extraList.Add(longerList[i]);
            }
            return extraList;
        }
    }
}
