using System;

namespace _01._Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());
            int totalSpirit = 0;
            int budget = 0;

            for (int i = 1; i <= daysLeft; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }

                if (i % 2 == 0)
                {
                    totalSpirit += 5;
                    budget += 2 * quantity;
                }

                if (i % 3 == 0)
                {
                    totalSpirit += 13;
                    budget += (5 + 3) * quantity;
                }

                if (i % 5 == 0)
                {
                    totalSpirit += 17;
                    budget += 15 * quantity;
                    if (i % 3 == 0)
                    {
                        totalSpirit += 30;
                    }
                }

                if (i % 10 == 0)
                {
                    totalSpirit -= 20;
                    budget += (5 + 3 + 15);
                    if (i == daysLeft)
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
