using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char symb = text[i];
                if (char.IsLetter(symb))
                {
                    letters.Append(symb);
                }
                else if (char.IsDigit(symb))
                {
                    digits.Append(symb);
                }
                else
                {
                    others.Append(symb);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
