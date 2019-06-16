using System;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine()
                                        .Split()
                                        .ToArray();

            for (int i = 0; i < inputWords.Length; i++)
            {
                int elementIndex = i;
                int randomPosition = rnd.Next(0, inputWords.Length);
                Swap(elementIndex, randomPosition, inputWords);
            }

            foreach (var word in inputWords)
            {
                Console.WriteLine(word);
            }

        }

        private static void Swap(int index1, int index2, string[] inputWords)
        {
            string oldWord = inputWords[index1];
            inputWords[index1] = inputWords[index2];
            inputWords[index2] = oldWord;
        }
    }
}
