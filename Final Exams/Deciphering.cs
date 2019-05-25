using System;
using System.Text;

namespace _02._Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encriptedString = Console.ReadLine();
            string[] keys = Console.ReadLine().Split();
            string oldSubString = keys[0];
            string newSubString = keys[1];
            
            if (!IsStringValid(encriptedString))
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            StringBuilder decodedString = new StringBuilder();
            foreach (var symb in encriptedString)
            {
                char newSymb = (char)(symb - 3);
                decodedString.Append(newSymb);
            }

            string result = decodedString.ToString();

            int index = result.IndexOf(oldSubString);
            
            while (index != -1)
            {
                result = result.Replace(oldSubString, newSubString);
                index = result.IndexOf(oldSubString);
            }

            Console.WriteLine(result);
        }

        private static bool IsStringValid(string encriptedString)
        {
            for (int i = 0; i < encriptedString.Length; i++)
            {
                char symb = encriptedString[i];
                if (symb < 'd' && symb != '#')
                {
                    return false;
                }
                else if (symb > '}')
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            return true;
        }
    }
}
