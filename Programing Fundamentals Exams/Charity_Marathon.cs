using System;

namespace _01._Charity_Marathon_23._10._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long totalRunners = long.Parse(Console.ReadLine());
            int averageLapsPerRunner = int.Parse(Console.ReadLine());
            int lapLenght = int.Parse(Console.ReadLine());
            long trackCapacityPerDay = long.Parse(Console.ReadLine());
            decimal moneyPerKM = decimal.Parse(Console.ReadLine());

            long maximumRunners = trackCapacityPerDay * days;
            if (totalRunners > maximumRunners)
            {
                totalRunners = maximumRunners;
            }
            long totalKM = (totalRunners * averageLapsPerRunner * lapLenght) / 1000;

            decimal totalMoney = totalKM * moneyPerKM;

            Console.WriteLine($"Money raised: {totalMoney:f2}");

        }
    }
}
