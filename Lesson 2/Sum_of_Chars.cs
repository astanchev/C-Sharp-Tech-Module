using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCharacters = int.Parse(Console.ReadLine());
            int sumOfLetters = 0;
            for (int i = 1; i <= numberCharacters; i++)
            {
                sumOfLetters += char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum equals: {sumOfLetters}");
        }
    }
}
