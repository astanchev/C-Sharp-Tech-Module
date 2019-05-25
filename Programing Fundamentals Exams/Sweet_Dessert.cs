using System;

namespace _01._Sweet_Dessert__10._2016_II
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal initialMoney = decimal.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            decimal priceBananas = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerries = decimal.Parse(Console.ReadLine());

            decimal costOneSet = 2 * priceBananas + 4 * priceEggs + 0.2M * priceBerries;

            long totalSets = (long)Math.Ceiling(1.0 * guests / 6);
            decimal totalCosts = totalSets * costOneSet;

            if (initialMoney >= totalCosts)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCosts:f2}lv.");
            }
            else
            {
                decimal neededMoney = totalCosts - initialMoney;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }
        }
    }
}
