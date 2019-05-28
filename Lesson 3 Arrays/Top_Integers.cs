using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool[] topInteger = new bool[array.Length];
            for (int i = 0; i < topInteger.Length; i++)
            {
                topInteger[i] = true;
            }



            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        topInteger[i] = false;
                    }
                }
            }

            for (int i = 0; i < topInteger.Length; i++)
            {
                if (topInteger[i])
                {
                    Console.Write($"{array[i]} ");
                }
            }

        }
    }
}
