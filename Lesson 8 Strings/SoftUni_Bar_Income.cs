using System;
using System.Text.RegularExpressions;

namespace _12._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[0-9]+\.?[0-9]+)\$";

            double totalIncome = 0.0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }

                Regex order = new Regex(pattern);

                if (order.IsMatch(input))
                {
                    string customerName = order.Match(input)
                                            .Groups["customer"]
                                            .Value;
                    string product = order.Match(input)
                                            .Groups["product"]
                                            .Value;
                    int count = int.Parse(order.Match(input)
                                            .Groups["count"]
                                            .Value);
                    double price = double.Parse(order.Match(input)
                                            .Groups["price"]
                                            .Value);

                    double totalPrice = price * count;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");                    

                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
