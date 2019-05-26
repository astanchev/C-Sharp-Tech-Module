using System;

namespace _02.Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (age % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (age % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (age % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (age % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else if (age == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
