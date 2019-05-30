using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            PrintTriangle(inputNumber);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int endNumber)
        {
            for (int i = 1; i <= endNumber; i++)
            {
                PrintLine(1, i);
            }
            for (int i = endNumber - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
