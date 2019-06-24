using System;
using System.Text;

namespace _02._Repeat_Strings_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            foreach (var word in inputLine)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result);
        }
    }
}
