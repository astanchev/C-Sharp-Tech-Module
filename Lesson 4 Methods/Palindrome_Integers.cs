using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="END")
            {
                PalindromeCheck(input);
                input = Console.ReadLine();
            }
        }

        static void PalindromeCheck(string input)
        {
            bool isPalindrome = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i]!=input[input.Length-1-i])
                {
                    isPalindrome = false;
                }
            }
            Console.WriteLine(isPalindrome.ToString().ToLower());
        }
    }
}
