using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string result = string.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    result += input[input.Length - 1 - i];
                }
                Console.WriteLine($"{input} = {result}");
            }
        }
    }
}
