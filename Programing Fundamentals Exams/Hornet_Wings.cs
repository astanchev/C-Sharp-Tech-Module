using System;

namespace _01._Hornet_Wings_26._02._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceToTravelfor1000fl = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            //100flaps per second

            double distance = (wingFlaps / 1000) * distanceToTravelfor1000fl;
            int rest = (wingFlaps / endurance) * 5;
            int timeWithouthRest = wingFlaps / 100;

            int totalTime = rest + timeWithouthRest;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
