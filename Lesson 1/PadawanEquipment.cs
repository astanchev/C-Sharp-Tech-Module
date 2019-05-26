using System;

namespace _09.PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal priceLightsaber = decimal.Parse(Console.ReadLine());
            decimal priceRobes = decimal.Parse(Console.ReadLine());
            decimal priceBelt = decimal.Parse(Console.ReadLine());

            int freeBelts = students / 6;

            decimal neededMoney = priceLightsaber * Math.Ceiling(students * 1.1m) + priceRobes * students + priceBelt * (students - freeBelts);

            if (neededMoney<=money)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(neededMoney-money):f2}lv more.");
            }

        }
    }
}
