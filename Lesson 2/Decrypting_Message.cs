using System;

namespace _05_5._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte numberCharacters = byte.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 1; i <= numberCharacters; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                message += (char)(letter + key);
            }

            Console.WriteLine(message);
        }
    }
}
