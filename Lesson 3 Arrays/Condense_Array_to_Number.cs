using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (array.Length == 1)
            {
                Console.WriteLine($"{array[0]}");
                return;
            }


            while (array.Length != 1)
            {
                int[] temp = new int[array.Length - 1];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = array[i] + array[i + 1];
                }
                array = temp;
                
            }

            Console.WriteLine(array[0]);
        }
    }
}
