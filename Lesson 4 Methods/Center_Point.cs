using System;

namespace _02._Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distanceTo0First = DistanceToZero(x1, y1);
            double distanceTo0Second = DistanceToZero(x2, y2);

            PrintCenterPoint(distanceTo0First, distanceTo0Second, 
                            x1, y1, x2, y2);

            
        }

        static double DistanceToZero(double x, double y)
        {
            double result = 0.0;
            result = Math.Round(Math.Sqrt(x*x + y*y), 2);
            return result;
        }

        static void PrintCenterPoint(double first, double second, double x1, 
                                double y1, double x2, double y2)
        {            
            if (first<=second)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }            
        }

        
    }
}
