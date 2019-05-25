using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] typePrice = Console.ReadLine().Split('|');
            double budget = double.Parse(Console.ReadLine());
            double profit = 0.0;
            List<double> sellPrices = new List<double>();

            for (int i = 0; i < typePrice.Length; i++)
            {
                string type = typePrice[i].Split("->")[0];
                double price = double.Parse(typePrice[i].Split("->")[1]);
                if (type == "Clothes")
                {
                    if (price <= 50)
                    {
                        if (budget >= price)
                        {
                            budget -= price;
                            double increasedPrice = price * 1.4;
                            profit += increasedPrice - price;
                            sellPrices.Add(increasedPrice);
                        }
                    }
                }
                else if (type == "Shoes")
                {
                    if (price <= 35)
                    {
                        if (budget >= price)
                        {
                            budget -= price;
                            double increasedPrice = price * 1.4;
                            profit += increasedPrice - price;
                            sellPrices.Add(increasedPrice);
                        }
                    }
                }
                else if (type == "Accessories")
                {
                    if (price <= 20.50)
                    {
                        if (budget >= price)
                        {
                            budget -= price;
                            double increasedPrice = price * 1.4;
                            profit += increasedPrice - price;
                            sellPrices.Add(increasedPrice);
                        }
                    }
                }
            }


            for (int i = 0; i < sellPrices.Count-1; i++)
            {
                Console.Write($"{sellPrices[i]:f2} ");
            }
            Console.WriteLine($"{sellPrices[sellPrices.Count-1]:f2}");
            Console.WriteLine($"Profit: {profit:f2}");
            double endBudget = budget + sellPrices.Sum();
            if (endBudget >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }

        }
    }
}
