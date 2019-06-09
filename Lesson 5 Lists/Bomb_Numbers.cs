using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            int[] bombAndPower = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    if (i - power < 0 && i + power > numbers.Count - 1)
                    {
                        numbers.RemoveRange(0, numbers.Count);
                    }
                    else if (i - power < 0)
                    {
                        int rangeToRemove = i + 1 + power;
                        numbers.RemoveRange(0, rangeToRemove);
                        i = -1;
                    }
                    else if (i + power > numbers.Count - 1)
                    {
                        int rangeToRemove = numbers.Count - i + power;
                        numbers.RemoveRange(i - power, rangeToRemove);
                        i = -1;
                    }
                    else
                    {  
                        numbers.RemoveRange(i - power, 2 * power + 1);
                        i = -1;
                    }
                    
                }
            }
            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
