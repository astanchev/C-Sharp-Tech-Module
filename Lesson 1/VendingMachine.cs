using System;

namespace _07.VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            string coins = string.Empty;
            string product = string.Empty;
            decimal money = 0.0m;
            decimal totalMoney = 0.0m;
            decimal price = 0.0m;

            while (true)
            {
                coins = Console.ReadLine();
                if (coins == "Start")
                {
                    break;
                }
                else
                {
                    money = decimal.Parse(coins);
                }
                if (money == 0.1m || money == 0.2m || money == 0.5m || money == 1.0m || money == 2.0m)
                {
                    totalMoney += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                    continue;
                }
            }

            while (true)
            {
                product = Console.ReadLine();
                if (product == "End")
                {
                    Console.WriteLine($"Change: {totalMoney:f2}");
                    break;
                }
                switch (product)
                {
                    case "Nuts":
                        price = 2.0m;
                        if (price > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalMoney -= price;
                        }                        
                        break;
                    case "Water":
                        price = 0.7m;
                        if (price > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalMoney -= price;
                        }
                        break;
                    case "Crisps":
                        price = 1.5m;
                        if (price > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalMoney -= price;
                        }
                        break;
                    case "Soda":
                        price = 0.8m;
                        if (price > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalMoney -= price;
                        }
                        break;
                    case "Coke":
                        price = 1.0m;
                        if (price > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalMoney -= price;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

            }
        }
    }
}
