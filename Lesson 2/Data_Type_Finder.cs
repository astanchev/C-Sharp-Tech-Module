using System;

namespace _01_1._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                bool isInteger = int.TryParse(input, out int integer);
                bool isDouble = double.TryParse(input, out double doubleNumber);
                bool isChar = char.TryParse(input, out char character);
                bool isBoolean = bool.TryParse(input, out bool boolean);
                if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isDouble)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isBoolean)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
