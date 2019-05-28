using System;
using System.Linq;

namespace _05._2_Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < array.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger == true)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
