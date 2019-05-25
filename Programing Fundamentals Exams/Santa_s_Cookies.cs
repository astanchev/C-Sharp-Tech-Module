using System;

namespace _01._Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfBatches = int.Parse(Console.ReadLine());
            int totalBoxesForAllBatches = 0;

            for (int i = 0; i < amountOfBatches; i++)
            {
                int flourInGrams = int.Parse(Console.ReadLine());
                int sugarInGrams = int.Parse(Console.ReadLine());
                int cocoaInGrams = int.Parse(Console.ReadLine());

                int flourCups = flourInGrams / 140;
                int sugarSpoons = sugarInGrams / 20;
                int cocoaSpoons = cocoaInGrams / 10;
                int min = int.MaxValue;
                if (flourCups<min)
                {
                    min = flourCups;
                }
                if (sugarSpoons < min)
                {
                    min = sugarSpoons;
                }
                if (cocoaSpoons < min)
                {
                    min = cocoaSpoons;
                }
                if (flourCups<=0 || sugarSpoons<=0 || cocoaSpoons<=0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    int totalCookiesPerBake = (140 + 10 + 20) * min / 25;
                    int boxesPerCurrentBatch = totalCookiesPerBake / 5;
                    Console.WriteLine($"Boxes of cookies: {boxesPerCurrentBatch}");
                    totalBoxesForAllBatches += boxesPerCurrentBatch;
                }


            }
            Console.WriteLine($"Total boxes: {totalBoxesForAllBatches}");
        }
    }
}
