using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;

            if (first > second)
            {
                char temp = first;
                first = second;
                second = temp;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char symb = input[i];
                if (symb > first && symb < second)
                {
                    sum += symb;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
