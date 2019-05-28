using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] firstRow = new int[inputArray.Length / 2];
            int[] secondRow = new int[inputArray.Length / 2];

            for (int i = 0; i < inputArray.Length / 4; i++)
            {
                firstRow[i] = inputArray[inputArray.Length / 4 - 1 - i];
            }
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = inputArray[inputArray.Length / 4 + i];
            }
            for (int i = firstRow.Length / 2, j = 0; i < firstRow.Length; i++, j++)
            {
                firstRow[i] = inputArray[inputArray.Length - 1 - j];
            }
            
            for (int i = 0; i < firstRow.Length; i++)
            {
                Console.Write(firstRow[i]+secondRow[i]+" ");
            }
        }
    }
}
