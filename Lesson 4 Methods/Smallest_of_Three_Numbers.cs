using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = SmalestNumber(firstNumber, secondNumber,thirdNumber);
            Console.WriteLine(result);
        }

        static int SmalestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int result = firstNumber;

            if (result >= secondNumber)
            {
                result = secondNumber;
            }
            if (result >= thirdNumber)
            {
                result = thirdNumber;
            }            
            return result;
        }
    }
}
