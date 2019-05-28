using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCharacters = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < numberCharacters; i++)
            {
                for (int j = 0; j < numberCharacters; j++)
                {
                    for (int k = 0; k < numberCharacters; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
