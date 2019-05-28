using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumDigits = 0;

            while (number>0)
            {
                sumDigits += number % 10;
                number = number / 10;
            }
            Console.WriteLine(sumDigits);
        }
    }
}
