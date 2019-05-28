using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPours = int.Parse(Console.ReadLine());
            int tank = 255;
            int sumPours = 0;
            for (int i = 0; i < numberPours; i++)
            {
                int pours = int.Parse(Console.ReadLine());
                if (pours>tank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    sumPours += pours;
                    tank -= pours;                   
                }
            }
            Console.WriteLine(sumPours);
        }
    }
}
