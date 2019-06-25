using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ' ' };
            string[] bannedWords = Console.ReadLine()
                                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string bannedWord = bannedWords[i];
                string replacement = new string('*', bannedWord.Length);
                if (text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, replacement);
                }                
            }

            Console.WriteLine(text);
        }
    }
}
