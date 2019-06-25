using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder outputNumber = new StringBuilder();
            int transfer = 0;

            if (multiplier == 0)
            {
                Console.WriteLine(0);
            }
            else if (input == "0")
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    int number = input[i] - 48;
                    int result = number * multiplier;
                    result += transfer;
                    int ones = result % 10;
                    transfer = result / 10;
                    string digit = ones.ToString();
                    if (outputNumber.Length == 0)
                    {
                        outputNumber.Append(digit);
                    }
                    else
                    {
                        outputNumber.Insert(0, digit);
                    }
                }

                if (transfer > 0)
                {
                    string addedNumber = transfer.ToString();
                    outputNumber.Insert(0, addedNumber);
                }
                Console.WriteLine(outputNumber);
            }

        }
    }
}
