using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            double result = Devide(Factorial(firstNumber), Factorial(secondNumber));
            Console.WriteLine($"{result:f2}");
        }

        static long Factorial(long n)
        {
            long factorial = 1;
            for (long i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static double Devide(long a, long b)
        {
            double result = (double)a / b;
            return result;
        }
    }
}
