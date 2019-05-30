using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int result = CountVowels(inputString);
            Console.WriteLine(result);
        }

        static int CountVowels(string inputString)
        {
            int sumVowels = 0;
            char[] vowels = { 'a', 'o', 'e', 'u', 'i',
                              'A', 'O', 'E', 'U', 'I'};
            for (int i = 0; i < inputString.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (inputString[i]==vowels[j])
                    {
                        sumVowels++;
                    }
                }
            }

            return sumVowels;
        }
    }
}
