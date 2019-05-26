using System;

namespace _06.StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            int numberOld = int.Parse(Console.ReadLine());
            int number = numberOld;
            int digit = 0;
            int factoriel = 1;
            int sum = 0;

            while (number != 0)
            {
                digit = number % 10;
                number = number / 10;                
                for (int i = 1; i <= digit; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                factoriel = 1;                
            }
            if (sum == numberOld)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
