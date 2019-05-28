using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[numberLines];
            int[] secondArray = new int[numberLines];

            for (int i = 1; i <= numberLines; i++)
            {
                int[] temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 != 0)
                {
                    firstArray[i - 1] = temp[0];
                    secondArray[i - 1] = temp[1];
                }
                else
                {
                    firstArray[i - 1] = temp[1];
                    secondArray[i - 1] = temp[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
