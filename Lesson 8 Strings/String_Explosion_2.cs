using System;

namespace _07._String_Explosion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char symb = input[i];

                if (symb == '>')
                {
                    power += input[i+1] - 48;
                    continue;
                }
                if (power > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    power--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
