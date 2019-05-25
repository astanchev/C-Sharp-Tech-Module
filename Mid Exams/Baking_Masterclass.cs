using System;

namespace _01._Baking_Masterclass
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


            double sumEggs = 10 * priceEgg * students;
            double sumApron = priceApron * Math.Ceiling(1.2 * students);
            double sumFlour = (students - students / 5) * priceFlour;

            double sum = sumEggs + sumApron + sumFlour;


            if (sum <= budget)
            {
                Console.WriteLine($"Items purchased for {sum:f2}$.");
            }
            else
            {
                Console.WriteLine($"{ sum - budget:f2}$ more needed.");
            }
        }
    }
}
