using System;

namespace _01._Snowballs_05._01._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            int bestSnowBallValue = 0;

            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int currentSnowballValue = (int)Math.Pow((1.0 * snowballSnow / snowballTime), 1.0 * snowballQuality);

                if (currentSnowballValue>bestSnowBallValue)
                {
                    bestSnowBallValue = currentSnowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowBallValue} ({bestSnowballQuality})");
        }
    }
}
