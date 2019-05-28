using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string bestModel = string.Empty;
            double maxVolume = 0.0;
            for (int i = 0; i < numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * heightOfKeg;
                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    bestModel = model;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}
