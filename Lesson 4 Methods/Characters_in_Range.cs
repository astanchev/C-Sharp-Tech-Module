using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char smallChar = SmallCharacter(firstChar, secondChar);
            char bigChar = BigCharacter(firstChar, secondChar);
            PrintAllCharctersBetween(smallChar, bigChar);

        }

        static char SmallCharacter(char firstChar, char secondChar)
        {
            if (firstChar<secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static char BigCharacter(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static void PrintAllCharctersBetween(char smallChar, char bigChar)
        {
            for (int i = smallChar + 1; i < bigChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
