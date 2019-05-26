using System;

namespace _10.RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            decimal expenses = (lostGames / 2) * headsetPrice + (lostGames / 3) * mousePrice + (lostGames / 6) * keyboardPrice + (lostGames / 12) * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

            
        }
    }
}
