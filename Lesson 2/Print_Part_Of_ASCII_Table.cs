using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startCharacter = int.Parse(Console.ReadLine());
            int endCharacter = int.Parse(Console.ReadLine());
            
            for (int i = startCharacter; i <= endCharacter; i++)
            {
                Console.Write($"{(char)i} ");
            }



        }
    }
}
