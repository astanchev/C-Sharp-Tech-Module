using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday",
                                    "Thursday", "Friday",
                                    "Saturday", "Sunday"};

            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber>=1&& inputNumber <= 7)
            {
                Console.WriteLine(weekDays[inputNumber-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
