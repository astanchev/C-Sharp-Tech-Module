using System;

namespace _01._Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i%10==0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                coins += 50 - 2 * partySize;

                if (i % 3 == 0)
                {
                    coins -= 3*partySize;
                }
                if (i % 5 == 0)
                {
                    coins += 20 * partySize;
                }
                if (i % 15 == 0)
                {
                    coins -= 2 * partySize;
                }
            }

            int coinsPerCompanion = coins / partySize;
            Console.WriteLine($"{partySize} companions received {coinsPerCompanion} coins each.");
        }
    }
}
