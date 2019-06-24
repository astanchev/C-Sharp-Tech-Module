using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split();
            for (int i = 0; i < inputLine.Length; i++)
            {
                string result = string.Empty;
                for (int j = 0; j < inputLine[i].Length; j++)
                {
                    result += inputLine[i];
                }
                inputLine[i] = result;
            }
            Console.WriteLine(string.Join("", inputLine));
        }
    }
}
