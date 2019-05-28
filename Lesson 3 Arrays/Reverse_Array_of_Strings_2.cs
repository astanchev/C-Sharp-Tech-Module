using System;
using System.Linq;

namespace _04._2_Reverse_Array_of_Strings
{
    class Program
    {
        static void SwapElements(string[] arr, int i, int j)
        {
            string oldElement = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElement;
        }

        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ').ToArray();
            

            for (int i = 0; i < arrayOfStrings.Length/2; i++)
            {
                SwapElements(arrayOfStrings, i, (arrayOfStrings.Length - 1) - i);
            }

            Console.WriteLine(string.Join(" ", arrayOfStrings));
        }
    }
}
