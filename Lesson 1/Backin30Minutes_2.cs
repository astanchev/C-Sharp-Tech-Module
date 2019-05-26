using System;

namespace Backin30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            TimeSpan currentTime = new TimeSpan(hours, minutes,0);
            TimeSpan after30Time = new TimeSpan(hours, minutes+30,0);

            int hoursAfter = after30Time.Hours;
            int minutesAfter = after30Time.Minutes;

            Console.WriteLine($"{after30Time:h\\:mm}");
            Console.WriteLine();
            Console.WriteLine($"{hoursAfter:d2}:{minutesAfter:d2}");
            Console.WriteLine();

        }
    }
}
