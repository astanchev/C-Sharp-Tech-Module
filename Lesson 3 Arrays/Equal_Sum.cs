using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
                for (int i = 0; i < array.Length; i++)
                {
                    int leftSum = 0;
                    int rightSum = 0;
                    for (int leftIndex = 0; leftIndex < i; leftIndex++)
                    {
                        leftSum += array[leftIndex];
                    }
                    for (int rightIndex = i + 1; rightIndex < array.Length; rightIndex++)
                    {
                        rightSum += array[rightIndex];
                    }
                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(i);
                        return;                        
                    }
                }
                Console.WriteLine("no");
            

        }
    }
}
