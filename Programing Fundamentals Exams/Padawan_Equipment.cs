using System;

namespace _01._Padawan_Equipment_04._03._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal priceLightSabers = decimal.Parse(Console.ReadLine());
            decimal priceRobes = decimal.Parse(Console.ReadLine());
            decimal priceBelts = decimal.Parse(Console.ReadLine());

            decimal sumLight = priceLightSabers * Math.Ceiling(1.1m * students);
            decimal sumRobes = priceRobes * students;
            decimal sumBelts = priceBelts * (students - students / 6);

            decimal totalSum = sumLight + sumRobes + sumBelts;

            decimal neededMoney = totalSum - money;

            if (money >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
        }
    }
}
