using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int index = input.IndexOf('>');
            int prevPower = 0;
            //abv>1>1>2>2asdasd
            while (index!=-1)
            {
                int power = input[index + 1] - 48 + prevPower;
                int countExplodedIndexes = 0;
                int endOfExplosion = -1;
                int startOfExplosion = index + 1;
                if (index + 1 + power > input.Length)
                {
                    endOfExplosion = input.Length;
                }
                else
                {
                    endOfExplosion = startOfExplosion + power;
                }
                for (int i = startOfExplosion; i < endOfExplosion; i++)
                {
                    if (input[i] == '>')
                    {
                        break;
                    }
                    else
                    {
                        countExplodedIndexes++;
                    }
                }
                prevPower = power - countExplodedIndexes;
                input = input.Remove(index + 1, countExplodedIndexes);
                index = input.IndexOf('>', index + 1);
            }

            Console.WriteLine(input);
        }
    }
}
