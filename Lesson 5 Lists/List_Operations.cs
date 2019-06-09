using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                List<string> inputCommand = input.Split().ToList();
                string command = inputCommand[0];
                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(inputCommand[1]);
                        inputList.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(inputCommand[1]);
                        int indexToInsert = int.Parse(inputCommand[2]);
                        if (indexToInsert<0 || indexToInsert > inputList.Count-1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            inputList.Insert(indexToInsert, numberToInsert);
                        }                        
                        break;
                    case "Remove":
                        int indexToRemoveAt = int.Parse(inputCommand[1]);
                        if (indexToRemoveAt < 0 || indexToRemoveAt > inputList.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            inputList.RemoveAt(indexToRemoveAt);
                        }                        
                        break;
                    case "Shift":
                        string direction = inputCommand[1];
                        int numberOfShifts = int.Parse(inputCommand[2]);
                        Shift(direction, numberOfShifts, inputList);
                        break;
                    default: break;
                }
            }
            Console.WriteLine(string.Join(" ", inputList));
        }

        private static void Shift(string direction, int numberOfShifts, List<int> inputList)
        {
            if (direction=="left")
            {
                ShiftLeft(numberOfShifts, inputList);
            }
            else
            {
                ShiftRight(numberOfShifts, inputList);
            }
        }

        private static void ShiftRight(int numberOfShifts, List<int> inputList)
        {
            for (int i = 0; i < numberOfShifts; i++)
            {
                int temp = inputList[inputList.Count-1];
                inputList.RemoveAt(inputList.Count - 1);
                inputList.Insert(0, temp);
            }
        }

        private static void ShiftLeft(int numberOfShifts, List<int> inputList)
        {
            for (int i = 0; i < numberOfShifts; i++)
            {
                int temp = inputList[0];
                inputList.RemoveAt(0);
                inputList.Add(temp);
            }
        }
    }
}
