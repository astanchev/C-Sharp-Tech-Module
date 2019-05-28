using System;

namespace _06_6._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            bool openBracket = false;
            bool closeBracket = false;
            bool balancedBrackets = true;
            for (int i = 0; i < numberLines; i++)
            {
                string input = Console.ReadLine();
                if (input=="(")
                {
                    if (openBracket)
                    {
                        balancedBrackets = false;

                    }
                    else
                    {
                        openBracket = true;
                    }
                }
                else if (input == ")")
                {
                    if (!openBracket)
                    {
                        balancedBrackets = false;
                    }
                    if (closeBracket)
                    {
                        balancedBrackets = false;
                    }
                    else
                    {
                        closeBracket = true;
                    }
                }
                if (openBracket&&closeBracket&&balancedBrackets)
                {
                    openBracket = false;
                    closeBracket = false;
                }
            }
            if (balancedBrackets && !openBracket && !closeBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
