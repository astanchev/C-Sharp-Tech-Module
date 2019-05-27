using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            if (character > 64 && character < 91)
            {
                Console.WriteLine("upper-case");
            }
            else if (character > 96 && character < 123)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
