using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                List<string> inputCommand = input.Split().ToList();

                if (inputCommand.Count > 2)
                {
                    int numberToInsert = int.Parse(inputCommand[1]);
                    int indexToInsert = int.Parse(inputCommand[2]);
                    numbers.Insert(indexToInsert, numberToInsert);                    
                }
                else
                {
                    int numberToDelete = int.Parse(inputCommand[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == numberToDelete)
                        {
                            numbers.Remove(numberToDelete);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
