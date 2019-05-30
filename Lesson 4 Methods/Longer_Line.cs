using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
                        
            PrintlongerLine(x1, y1, x2, y2, x3, y3, x4, y4);


        }

        static double DistanceToZero(double x, double y)
        {
            double result = 0.0;
            result = Math.Round(Math.Sqrt(x * x + y * y), 2);
            return result;
        }

        static void PrintlongerLine(double x1, double y1, double x2, double y2,
                                    double x3, double y3, double x4, double y4)
        {
            double lenghtFirstLine = CalculateLenghtLine(x1, y1, x2, y2);
            double lenghtSecondLine = CalculateLenghtLine(x3, y3, x4, y4);
            double distanceTo0First = DistanceToZero(x1, y1);
            double distanceTo0Second = DistanceToZero(x2, y2);
            double distanceTo0Third = DistanceToZero(x3, y3);
            double distanceTo0Fourth = DistanceToZero(x4, y4);

            if (lenghtFirstLine>=lenghtSecondLine)
            {
                if (distanceTo0First<=distanceTo0Second)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (lenghtFirstLine < lenghtSecondLine)
            {
                if (distanceTo0Third <= distanceTo0Fourth)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static double CalculateLenghtLine(double x1, double y1,
                                            double x2, double y2)
        {
            double result = 0.0;
            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }

    }

}
