using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] typePrice = Console.ReadLine().Split('|');
            double budget = double.Parse(Console.ReadLine());
            List<double> increasedPrices = new List<double>();
            double profit = 0.0;
            for (int i = 0; i < typePrice.Length; i++)
            {
                string[] input = typePrice[i].Split("->");
                string type = input[0];
                double price = double.Parse(input[1]);
                double priceClothes = 50.00;
                double priceShoes = 35.00;
                double priceAccesories = 20.50;
                
                
                switch (type)
                {
                    case "Clothes":
                        if (price> priceClothes)
                        {
                            continue;
                        }
                        if (price<=budget)
                        {
                            budget -= price;
                            double increasedPrice = price * 1.4;
                            profit += increasedPrice - price;
                            increasedPrices.Add(increasedPrice);
                        }


                        break;
                    case "Shoes":
                        if (price > priceShoes)
                        {
                            continue;
                        }
                        if (price <= budget)
                        {
                            budget -= price;
                            double increasedPrice = price * 1.4;
                            profit += increasedPrice - price;
                            increasedPrices.Add(increasedPrice);
                        }

                        break;
                    case "Accessories":
                        if (price > priceAccesories)
                        {
                            continue;
                        }
                        if (price <= budget)
                        {
                            budget -= price;
                            double increasedPrice = price * 1.4;
                            profit += increasedPrice - price;
                            increasedPrices.Add(increasedPrice);
                        }

                        break;
                    default: break;
                }
            }
            for (int i = 0; i < increasedPrices.Count-1; i++)
            {
                Console.Write($"{increasedPrices[i]:f2} ");
            }
            Console.WriteLine($"{increasedPrices[increasedPrices.Count - 1]:f2}");
            Console.WriteLine($"Profit: {profit:f2}");
            double endbudget = budget + increasedPrices.Sum();
            if (endbudget>=150)
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
