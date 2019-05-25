using System;
using System.Globalization;

namespace _01._Softuni_Coffee_Orders_10._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0M;
            for (int i = 1; i <= numberOfOrders; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime dateOfOrder = DateTime
                                        .ParseExact(Console.ReadLine(),
                                        "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(dateOfOrder.Year, dateOfOrder.Month);

                decimal currentPrice = daysInMonth * capsules * price;
                totalPrice += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
