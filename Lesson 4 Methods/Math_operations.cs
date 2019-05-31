using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string calculation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, calculation, secondNumber);
            Console.WriteLine(result);
        }

        static double Calculate(int a, string @operation, int b)
        {
            double result = 0;

            switch (operation)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/": result = a * 1.0 / b; break;
                default: break;
            }

            return result;
        }
    }
}
