using System;
using System.Collections.Generic;

namespace _02._Hello__France_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] typePrice = Console.ReadLine().Split('|');
            double budget = double.Parse(Console.ReadLine());
            double profit = 0.0;
            List<string> sellPrices = new List<string>();
            double totalSelPrices = 0.0;

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
                            totalSelPrices += increasedPrice;
                            string sellPrice = $"{increasedPrice:f2}";
                            //string sellPrice = string.Format("{0:0.00}", increasedPrice);
                            sellPrices.Add(sellPrice);
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
                            totalSelPrices += increasedPrice;
                            string sellPrice = $"{increasedPrice:f2}";
                            //string sellPrice = string.Format("{0:0.00}", increasedPrice);
                            sellPrices.Add(sellPrice);
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
                            totalSelPrices += increasedPrice;
                            string sellPrice = $"{increasedPrice:f2}";
                            //string sellPrice = string.Format("{0:0.00}", increasedPrice);
                            sellPrices.Add(sellPrice);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", sellPrices));
            Console.WriteLine($"Profit: {profit:f2}");
            if (budget + totalSelPrices >= 150)
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
