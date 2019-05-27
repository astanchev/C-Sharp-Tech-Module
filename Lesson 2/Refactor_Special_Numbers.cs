using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());    
            for (int currentNum = 1; currentNum <= numbers; currentNum++)
            {
                int sumOfDigits = 0;
                int digits = currentNum;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool isSpecialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{currentNum} -> {isSpecialNum}");
                }
        }
    }
}
