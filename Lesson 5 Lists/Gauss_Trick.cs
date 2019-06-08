using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                                .Split(' ')
                                .Select(double.Parse)
                                .ToList();

            List<double> result = new List<double>();

            for (int i = 0; i < input.Count/2; i++)
            {
                double element = input[i] + input[(input.Count - 1) - i];
                result.Add(element);
            }
            if (input.Count % 2 != 0)
            {
                result.Add(input[input.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
