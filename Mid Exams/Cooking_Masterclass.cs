using System;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            double moneyForFlour = students * priceFlour - students / 5 * priceFlour;
            double moneyForEggs = students * 10 * priceEgg;
            double moneyForApron = Math.Ceiling(students * 1.2) * priceApron;

            double moneyForAll = moneyForFlour + moneyForEggs + moneyForApron;

            if (moneyForAll <= budget)
            {
                Console.WriteLine($"Items purchased for {moneyForAll:f2}$.");
            }
            else
            {
                Console.WriteLine($"{moneyForAll - budget:f2}$ more needed.");
            }

        }
    }
}
