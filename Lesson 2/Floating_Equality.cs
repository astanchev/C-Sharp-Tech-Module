using System;

namespace _03_3._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if (firstNumber==secondNumber || Math.Abs(firstNumber-secondNumber)<eps)
            {
                Console.WriteLine("True");
            }
            else if (firstNumber != secondNumber || !(Math.Abs(firstNumber - secondNumber) < eps))
            {
                Console.WriteLine("False");
            }

            

        }
    }
}
