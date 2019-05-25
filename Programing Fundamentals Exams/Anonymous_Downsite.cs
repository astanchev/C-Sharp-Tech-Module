using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01._Anonymous_Downsite_05._11._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());
            byte securityKey = byte.Parse(Console.ReadLine());
            decimal totalLoss = 0M;
            List<string> sites = new List<string>();
            for (int i = 1; i <= numberOfWebsites; i++)
            {
                string[] website = Console.ReadLine().Split();
                string siteName = website[0];
                long siteVisits = long.Parse(website[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(website[2]);

                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;

                totalLoss += siteLoss;
                sites.Add(siteName);
            }

            BigInteger securityToken = BigInteger.Pow(new BigInteger(securityKey), numberOfWebsites);
            Console.WriteLine(string.Join(Environment.NewLine, sites));
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
