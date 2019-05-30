using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {


        static void Main(string[] args)
        {
            int sequenceLenght = int.Parse(Console.ReadLine());

            PrintTribonacci(sequenceLenght);
        }


        static void PrintTribonacci(int number)
        {
            long[] tribonacciArray = new long[number];


            for (int i = 0; i < number; i++)
            {
                if (i < 2)
                {
                    tribonacciArray[i] = 1;

                }
                else if (i == 2)
                {
                    tribonacciArray[i] = 2;
                }
                else
                {
                    tribonacciArray[i] = tribonacciArray[i - 1]
                                    + tribonacciArray[i - 2]
                                    + tribonacciArray[i - 3];
                }
            }

            Console.WriteLine(string.Join(" ",tribonacciArray));
        }
    }
}
