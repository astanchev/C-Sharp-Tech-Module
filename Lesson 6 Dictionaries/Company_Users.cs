using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] inputLine = input.Split(" -> ");
                string companyName = inputLine[0];
                string employeeId = inputLine[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                if (!companies[companyName].Contains(employeeId))
                {
                    companies[companyName].Add(employeeId);
                }
            }

            foreach (var kvp in companies.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (var empoyeeID in kvp.Value)
                {
                    Console.WriteLine($"-- {empoyeeID}");
                }
            }
        }
    }
}
