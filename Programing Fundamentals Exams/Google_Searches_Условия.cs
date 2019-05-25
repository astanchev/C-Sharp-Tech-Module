using System;

namespace _01._Google_Searches_Условия
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            int numberUsers = int.Parse(Console.ReadLine());
            double moneyPerSearch = double.Parse(Console.ReadLine());

            double earnedMoney = 0.0;

            for (int i = 1; i <= numberUsers; i++)
            {
                int numberWordsForUser = int.Parse(Console.ReadLine());
                double moneyFromCurrentUser = 0.0;
                moneyFromCurrentUser = moneyPerSearch * totalDays;

                if (numberWordsForUser > 5)
                {
                    moneyFromCurrentUser = 0.0;
                }
                else if (numberWordsForUser == 1)
                {
                    moneyFromCurrentUser *= 2;
                }
                if (i % 3 == 0)
                {
                    moneyFromCurrentUser *= 3;
                }
                earnedMoney += moneyFromCurrentUser;
            }

            Console.WriteLine($"Total money earned for {totalDays} days: {earnedMoney:f2}");
        }
    }
}
