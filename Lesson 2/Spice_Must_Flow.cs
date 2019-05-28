using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalAmount = 0;
            while (true)
            {
                if (startingYield < 100)
                {
                    Console.WriteLine(days);
                    if (totalAmount > 26)
                    {
                        totalAmount -= 26;
                    }
                    else
                    {
                        totalAmount = 0;
                    }
                    Console.WriteLine(totalAmount);
                    break;
                }
                days++;
                totalAmount += startingYield-26;
                
                startingYield -= 10;
                
            }
            
        }
    }
}
