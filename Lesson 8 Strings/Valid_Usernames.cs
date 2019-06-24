using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            foreach (var name in input)
            {
                if (hasLenght(name) && isCorrect(name))
                {
                    Console.WriteLine(name);
                }
            }

        }

        private static bool isCorrect(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsLetterOrDigit(name[i]) 
                    || name[i] == '-' 
                    || name[i] == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static bool hasLenght(string name)
        {
            if (name.Length >= 3 && name.Length <= 16)
            {
                return true;
            }
            return false;
        }
    }
}
