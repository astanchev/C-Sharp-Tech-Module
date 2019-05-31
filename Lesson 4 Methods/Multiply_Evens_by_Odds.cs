using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = Math.Abs(int.Parse(Console.ReadLine()));

            int multiple = GetMultipleOfEvenAndOdds(inputNumber);

            Console.WriteLine(multiple);
        }

        static int GetMultipleOfEvenAndOdds(int inputNumber)
        {
            int result = 0;
            int evenSum = 0;
            int oddSum = 0;
            while (inputNumber != 0)
            {
                int digit = inputNumber % 10;
                if (digit%2==0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
                inputNumber /= 10;
            }
            result = evenSum * oddSum;
            return result;
        }
    }
}
