using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticket = 0;

            if (age >= 0 && age <= 18)
            {
                if (typeOfDay=="Weekday")
                {
                    ticket = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    ticket = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    ticket = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    ticket = 18;
                }
                else if (typeOfDay == "Weekend")
                {
                    ticket = 20;
                }
                else if (typeOfDay == "Holiday")
                {
                    ticket = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    ticket = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    ticket = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    ticket = 10;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }
            Console.WriteLine($"{ticket}$");
        }
    }
}
