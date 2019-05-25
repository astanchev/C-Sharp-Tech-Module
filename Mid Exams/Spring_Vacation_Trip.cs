using System;

namespace _01._Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfVacantion = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int countPeople = int.Parse(Console.ReadLine());
            double fuelPerKM = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());
            double sleepPerPerson = double.Parse(Console.ReadLine());

            double foodExpenses = daysOfVacantion * countPeople * foodPerPerson;
            double sleepExpenses = daysOfVacantion * countPeople * sleepPerPerson;
            if (countPeople > 10)
            {
                sleepExpenses *= 0.75;
            }
            double currentExpenses = foodExpenses + sleepExpenses;

            if (currentExpenses > budget)
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {currentExpenses - budget:f2}$ more.");
                return;
            }

            for (int i = 1; i <= daysOfVacantion; i++)
            {
                double travaledDistance = double.Parse(Console.ReadLine());
                double priceTravelforDay = travaledDistance * fuelPerKM;

                currentExpenses += priceTravelforDay;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentExpenses *= 1.4;
                }

                if (i % 7 == 0)
                {
                    double withdraw = currentExpenses / countPeople;
                    currentExpenses -= withdraw;
                }
                if (currentExpenses > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {currentExpenses - budget:f2}$ more.");
                    return;
                }
            }

            Console.WriteLine($"You have reached the destination. You have {budget-currentExpenses:f2}$ budget left.");
        }
    }
}
