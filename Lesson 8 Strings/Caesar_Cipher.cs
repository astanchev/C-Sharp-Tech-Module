using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (var symb in input)
            {
                char newSymb = (char)(symb + 3);
                sb.Append(newSymb);
            }

            Console.WriteLine(sb);
        }
    }
}
