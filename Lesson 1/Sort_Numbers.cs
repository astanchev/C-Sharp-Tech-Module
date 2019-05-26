using System;

namespace _1._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double max = Math.Max(Math.Max(first, second), third);
            double min = Math.Min(Math.Min(first, second), third);
            double middle = (first + second + third) - (max + min); ;

            Console.WriteLine(max);
            Console.WriteLine(middle);
            Console.WriteLine(min);
            
        }
    }
}
