using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Passed
{
    class Passed
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
