using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfData = Console.ReadLine();
            switch (typeOfData)
            {
                case "int": PrintResult(int.Parse(Console.ReadLine())); break;
                case "real": PrintResult(double.Parse(Console.ReadLine())); break;
                case "string": PrintResult(Console.ReadLine()); break;
                default: break;
            }
        }

        static void PrintResult(int number)
        {
            Console.WriteLine(number*2);
        }

        static void PrintResult(double number)
        {
            Console.WriteLine($"{number*1.5:f2}");
        }

        static void PrintResult(string word)
        {
            Console.WriteLine($"${word}$");
        }
    }
}
