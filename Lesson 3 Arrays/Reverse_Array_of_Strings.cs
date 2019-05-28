using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ').ToArray();
            string[] reversedArray = new string[arrayOfStrings.Length];

            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[i] = arrayOfStrings[arrayOfStrings.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", reversedArray));
        }
    }
}
