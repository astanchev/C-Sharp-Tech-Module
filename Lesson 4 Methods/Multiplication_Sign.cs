using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            PrintMultiplicationSign(num1, num2, num3);
        }

        static void PrintMultiplicationSign(double num1, double num2, double num3)
        {
            int counterNegative = 0;
            if (num1 < 0)
            {
                counterNegative++;
            }
            if (num2 < 0)
            {
                counterNegative++;
            }
            if (num3 < 0)
            {
                counterNegative++;
            }
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            if (counterNegative % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
