using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] numberSequences = new int[numberOfStrings];
            

            char[] vowels = { 'a', 'A', 'o', 'O', 'e', 'E',
                              'i', 'I', 'u', 'U'/*, 'y', 'Y'*/};

            for (int i = 0; i < numberOfStrings; i++)
            {
                string input = Console.ReadLine();
                char[] inputChars = input.ToCharArray();
                int sumSequence = 0;
                for (int j = 0; j < inputChars.Length; j++)
                {
                    if (vowels.Contains(inputChars[j]))
                    {
                        sumSequence += inputChars[j] * input.Length;
                    }
                    else
                    {
                        sumSequence += inputChars[j] / input.Length;
                    }
                }
                numberSequences[i] = sumSequence;
            }
            Array.Sort(numberSequences);
            for (int i = 0; i < numberSequences.Length; i++)
            {
                Console.WriteLine(numberSequences[i]);
            }
        }
    }
}
