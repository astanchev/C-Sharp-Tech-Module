using System;

namespace _05.Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = string.Empty;
            string input = string.Empty;

            for (int i = user.Length - 1; i >= 0; i--)
            {
                password += user[i];
            }

            for (int j = 1; j <= 4; j++)
            {
                input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else if (input != password && j == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                }
                else if (input != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
