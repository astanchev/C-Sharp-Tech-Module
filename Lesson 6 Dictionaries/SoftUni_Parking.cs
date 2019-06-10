using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var userPlateNumber = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                string command = inputLine[0];
                string username = inputLine[1];

                if (command == "register")
                {
                    string licensePlateNumber = inputLine[2];
                    if (!userPlateNumber.ContainsKey(username))
                    {
                        userPlateNumber[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userPlateNumber[username]}");
                    }
                }
                else if (command == "unregister")
                {
                    if (userPlateNumber.ContainsKey(username))
                    {
                        userPlateNumber.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var kvp in userPlateNumber)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
