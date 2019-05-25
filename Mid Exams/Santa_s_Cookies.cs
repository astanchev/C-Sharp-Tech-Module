using System;

namespace _01._Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberBatches = int.Parse(Console.ReadLine());
            int totalBoxes = 0;

            for (int i = 0; i < numberBatches; i++)
            {
                int flourInGrams = int.Parse(Console.ReadLine());
                int sugarInGrams = int.Parse(Console.ReadLine());
                int cocoaInGrams = int.Parse(Console.ReadLine());
                int currentBoxes = 0;

                int flourCups = flourInGrams / 140;
                int sugarSpoons = sugarInGrams / 20;
                int cocoaSpoons = cocoaInGrams / 10;
                int cookiesPerBox = 5;
                int singleCookieGrams = 25;
                if (flourCups <= 0 || sugarSpoons <= 0 || cocoaSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    int totalCookiesPerBake = (140 + 10 + 20) * Math.Min(flourCups, Math.Min(sugarSpoons, cocoaSpoons)) / singleCookieGrams;
                    currentBoxes = totalCookiesPerBake / cookiesPerBox;
                    Console.WriteLine($"Boxes of cookies: {currentBoxes}");
                }

                totalBoxes += currentBoxes;
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
