using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] passangersInWagon = new int[wagons];
            int allPassangers = 0;

            for (int i = 0; i < passangersInWagon.Length; i++)
            {
                passangersInWagon[i] = int.Parse(Console.ReadLine());
                allPassangers += passangersInWagon[i];
            }

            Console.WriteLine(string.Join(" ",passangersInWagon));
            Console.WriteLine(allPassangers);
        }
    }
}
