using System;

namespace _01._Rage_Expenses_25._04._2018
{
    class Program
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
