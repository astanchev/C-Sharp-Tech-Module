using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Backin30Minutes
{
    class Backin30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int arriveTimeMinutes = hours * 60 + minutes;
            int timeInHalfHour = arriveTimeMinutes + 30;

            int hoursLater = timeInHalfHour / 60;
            int minutesLater = timeInHalfHour % 60;

            if (hoursLater>23)
            {
                hoursLater -= 24;
            }

            Console.WriteLine($"{hoursLater}:{minutesLater:00}");
        }
    }
}
