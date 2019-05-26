using System;

namespace _09.SumofOddNumbers
{
    class SumofOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= 2 * n; i += 2)
            {
                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(2*i+1);
            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(2*i-1);
            //}

        }
    }
}
