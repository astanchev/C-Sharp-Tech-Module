using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputList = Console.ReadLine()
                                .Split(' ')
                                .Select(double.Parse)
                                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                List<string> inputCommand = input.Split().ToList();
                string command = inputCommand[0];
                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(inputCommand[1]);
                        AddNumber(numberToAdd, inputList);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(inputCommand[1]);
                        RemoveNumber(numberToRemove, inputList);
                        break;
                    case "RemoveAt":
                        int indexToRemoveFrom = int.Parse(inputCommand[1]);
                        RemoveAtIndex(indexToRemoveFrom, inputList);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(inputCommand[1]);
                        int indexToInsertAt = int.Parse(inputCommand[2]);
                        InsertAtIndex(numberToInsert, indexToInsertAt, inputList);
                        break;
                    default:  break;
                }                
            }
            PrintList(inputList);
        }

        private static void PrintList(List<double> inputList)
        {
            Console.WriteLine(string.Join(" ", inputList));
        }

        private static void InsertAtIndex(int numberToInsert, int indexToInsertAt, List<double> inputList)
        {
            inputList.Insert(indexToInsertAt, numberToInsert);
        }

        private static void RemoveAtIndex(int indexToRemoveFrom, List<double> inputList)
        {
            inputList.RemoveAt(indexToRemoveFrom);
        }

        private static void RemoveNumber(int numberToRemove, List<double> inputList)
        {
            inputList.Remove(numberToRemove);
        }

        private static void AddNumber(int numberToAdd, List<double> inputList)
        {
            inputList.Add(numberToAdd);
        }
    }
}
