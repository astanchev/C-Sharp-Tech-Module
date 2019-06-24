using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string first = input[0];
            string second = input[1];
            int totalSum = 0;
            int count = 0;

            if (first.Length>second.Length)
            {
                count = second.Length;
                for (int i = second.Length; i < first.Length; i++)
                {
                    totalSum += first[i];
                }
            }
            else if (first.Length < second.Length)
            {
                count = first.Length;
                for (int i = first.Length; i < second.Length; i++)
                {
                    totalSum += second[i];
                }
            }
            else
            {
                count = first.Length;
            }

            for (int i = 0; i < count; i++)
            {
                int res = first[i] * second[i];
                totalSum += res;
            }

            Console.WriteLine(totalSum);
        }
    }
}
