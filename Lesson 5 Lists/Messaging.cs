using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<char> text = Console.ReadLine().ToList();
            string result = string.Empty;
            List<int> sumNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                sumNumbers.Add(sum);
            }

            for (int i = 0; i < sumNumbers.Count; i++)
            {
                int elmentIndex = sumNumbers[i];
                for (int j = 0; j < text.Count; j++)
                {                    
                    if (elmentIndex >= text.Count)
                    {
                        elmentIndex = elmentIndex - text.Count;
                    }
                    if (j == elmentIndex)
                    {
                        string letter = text[j].ToString();
                        result += letter;
                        text.RemoveAt(j);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
