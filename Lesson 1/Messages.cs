using System;

namespace _5._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int letters = int.Parse(Console.ReadLine());
            int numberDigits = 0;
            int mainDigit = 0;
            int offset = 0;
            int letterIndex = 0;
            char letter;
            string sms = string.Empty;

            for (int i = 0; i < letters; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number / 1000 != 0)
                {
                    numberDigits = 4;
                }
                else if (number / 100 != 0)
                {
                    numberDigits = 3;
                }
                else if (number / 10 != 0)
                {
                    numberDigits = 2;
                }
                else
                {
                    numberDigits = 1;
                }
                mainDigit = number % 10;
                offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                letterIndex = (offset + numberDigits - 1);
                if (mainDigit!=0)
                {
                    letter = (char)(97 + letterIndex);
                }
                else
                {
                    letter = (char)32;
                }
                sms += letter;
            }

            Console.WriteLine(sms);
        }
    }
}
