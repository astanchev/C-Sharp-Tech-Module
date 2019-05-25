using System;
using System.Numerics;

namespace _01._Sino_The_Walker_06._01._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(':');

            int hours = int.Parse(time[0]);
            int minutes = int.Parse(time[1]);
            int seconds = int.Parse(time[2]);
            TimeSpan leaveTime = new TimeSpan(hours, minutes, seconds);

            int numberSteps = int.Parse(Console.ReadLine()) % 86400;
            int secondsForStep = int.Parse(Console.ReadLine()) % 86400;

            long timeFortravel = numberSteps * secondsForStep;


            leaveTime += TimeSpan.FromSeconds(timeFortravel);

            Console.WriteLine($"Time Arrival: {leaveTime:hh\\:mm\\:ss}");
        }
    }
}
