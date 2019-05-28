using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int number = 0;
            int currentLenght = 1;
            int maxLenght = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentLenght++;
                }
                else
                {
                    currentLenght = 1;
                }

                if (currentLenght > maxLenght)
                {
                    maxLenght = currentLenght;
                    number = array[i];
                }
            }

            for (int i = 0; i < maxLenght; i++)
            {
                Console.Write($"{number} ");
            }

        }
    }
}
