using System;

namespace _01._Hogswatch_27._08._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberHomesToVisit = int.Parse(Console.ReadLine());
            int initialNumberPresents = int.Parse(Console.ReadLine());

            int timesBack = 0;
            int additionalPresents = 0;
            int additionalPresentsTaken = 0;
            int numberPresents = initialNumberPresents;

            for (int i = 1; i <= numberHomesToVisit; i++)
            {
                int numberSocksInHouse = int.Parse(Console.ReadLine());

                if (numberSocksInHouse <= numberPresents)
                {
                    numberPresents -= numberSocksInHouse;
                }
                else
                {
                    additionalPresents = numberSocksInHouse - numberPresents;
                    timesBack++;
                    numberPresents = (initialNumberPresents / i) * (numberHomesToVisit - i) + additionalPresents;
                    additionalPresentsTaken += numberPresents;
                    numberPresents -= additionalPresents;
                }
            }

            if (timesBack==0)
            {
                Console.WriteLine(numberPresents);
            }
            else
            {
                Console.WriteLine(timesBack);
                Console.WriteLine(additionalPresentsTaken);
            }

        }
    }
}
