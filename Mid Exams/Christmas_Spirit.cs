using System;

namespace _01.Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int budget = 0;
            int totalSpirit = 0;
            int priceOrnaments = 2;
            int priceSkirt = 5;
            int priceGarlands = 3;
            int priceLights = 15;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 2 == 0)
                {
                    budget += priceOrnaments * quantity;
                    totalSpirit += 5;
                }
                if (i % 3 == 0)
                {
                    budget += (priceSkirt + priceGarlands) * quantity;
                    totalSpirit += 13;
                }
                if (i % 5 == 0)
                {
                    budget += priceLights * quantity;
                    totalSpirit += 17;
                }
                if (i % 15 == 0)
                {
                    totalSpirit += 30;
                }
                if (i % 10 == 0)
                {
                    budget += priceLights + priceSkirt + priceGarlands;
                    totalSpirit -= 20;
                    if (i == days)
                    {
                        totalSpirit -= 30;
                    }
                }
            }


            Console.WriteLine($"Total cost: {budget}");
            Console.WriteLine($"Total spirit: {totalSpirit}");
        }
    }
}
