using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            PrintTopNumbers(limit);
        }

        static void PrintTopNumbers(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                if (DivisibalByEight(i)&&CheckOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool DivisibalByEight(int n)
        {
            bool isDivisibalByEight = false;
            int sum = 0;
            while (n != 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }
            if (sum % 8 == 0)
            {
                isDivisibalByEight = true;
            }
            return isDivisibalByEight;
        }

        static bool CheckOneOddDigit(int n)
        {
            bool isOneOddDigit = false;
            while (n != 0)
            {
                int digit = n % 10;
                if (digit%2!=0)
                {
                    isOneOddDigit = true;
                    break;
                }
                n /= 10;
            }
            return isOneOddDigit;
        }
    }
}
