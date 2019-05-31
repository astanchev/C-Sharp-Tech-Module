using System;
using System.Text;

namespace _07._Repeat_String_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repeatNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(inputString, repeatNumber));
        }

        static string RepeatString(string inputString, int repeatNumber)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < repeatNumber; i++)
            {
                result.Append(inputString);
            }

            return result.ToString();
        }
    }
}
