using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> productQuantity = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                string[] inputLine = input.Split();
                string product = inputLine[0];
                decimal price = decimal.Parse(inputLine[1]);
                int quantity = int.Parse(inputLine[2]);

                productPrice[product] = price;
                if (!productQuantity.ContainsKey(product))
                {                   
                    productQuantity.Add(product, quantity);
                }
                else
                {
                    productQuantity[product] += quantity;
                }
            }
            foreach (var kvp in productQuantity)
            {
                string productName = kvp.Key;
                int totalquantity = kvp.Value;
                decimal price = productPrice[productName];
                decimal totalPrice = totalquantity * price;
                Console.WriteLine($"{productName} -> {totalPrice}");
            }
        }
    }
}
