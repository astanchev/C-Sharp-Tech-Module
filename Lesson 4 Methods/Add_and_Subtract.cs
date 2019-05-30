using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = Subtract( Add(firstNumber, secondNumber), thirdNumber);
            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int sum, int c)
        {
            return sum - c;
        }
    }
}
