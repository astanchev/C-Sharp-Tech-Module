using System;

namespace _06._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tickets.Length; i++)
            {
                string ticket = tickets[i];
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string leftString = ticket.Substring(0, 10);
                string rightString = ticket.Substring(10);

                int length = 0;
                char symb = ' ';

                for (int j = 6; j <= 10; j++)
                {
                    if (leftString.Contains(new string('@', j)) && rightString.Contains(new string('@', j)))
                    {
                        length = j;
                        symb = '@';
                    }
                    else if (leftString.Contains(new string('#', j)) && rightString.Contains(new string('#', j)))
                    {
                        length = j;
                        symb = '#';
                    }
                    else if (leftString.Contains(new string('$', j)) && rightString.Contains(new string('$', j)))
                    {
                        length = j;
                        symb = '$';
                    }
                    else if (leftString.Contains(new string('^', j)) && rightString.Contains(new string('^', j)))
                    {
                        length = j;
                        symb = '^';
                    }
                }

                if (length < 6)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                else if (length == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {length}{symb} Jackpot!");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {length}{symb}");
                }

            }




        }
    }
}
