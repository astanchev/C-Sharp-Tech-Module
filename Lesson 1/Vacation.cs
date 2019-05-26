using System;

namespace _03.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0.0;
            double price = 0.0;

            if (typeOfGroup == "Students")
            {
                switch (day)
                {
                    case "Friday": price = 8.45; break;
                    case "Saturday": price = 9.80; break;
                    case "Sunday": price = 10.46; break;
                    default: break;
                }
                totalPrice = people * price;
                if (people >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                switch (day)
                {
                    case "Friday": price = 10.90; break;
                    case "Saturday": price = 15.60; break;
                    case "Sunday": price = 16.00; break;
                    default: break;
                }                
                if (people >= 100)
                {
                    people -= 10;
                }
                totalPrice = people * price;
            }
            else if (typeOfGroup == "Regular")
            {
                switch (day)
                {
                    case "Friday": price = 15.00; break;
                    case "Saturday": price = 20.00; break;
                    case "Sunday": price = 22.50; break;
                    default: break;
                }
                totalPrice = people * price;
                if (people >= 10 && people <= 20)
                {
                    totalPrice *= 0.95;
                }                
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
