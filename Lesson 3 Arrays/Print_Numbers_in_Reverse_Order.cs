using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());

            int[] array = new int[inputNumbers];

            for (int i = 0; i < array.Length; i++)
            {
               array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
