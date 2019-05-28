using System;

namespace _04_4._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= endNumber; currentNumber++)
            {
                bool isPrime = true;
                for (int devisor = 2; devisor < currentNumber; devisor++)
                {
                    if (currentNumber % devisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{currentNumber} -> true");
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> false");
                }
            }

        }
    }
}
