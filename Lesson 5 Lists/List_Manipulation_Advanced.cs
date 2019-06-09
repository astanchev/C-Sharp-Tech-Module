using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();
            bool areChangesMade = false;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                List<string> inputCommand = input.Split().ToList();
                string command = inputCommand[0];
                switch (command)
                {
                    case "Contains":
                        int checkedNumber = int.Parse(inputCommand[1]);
                        PrintIfContainsNumber(checkedNumber, inputList);
                        break;
                    case "PrintEven":
                        PrintEven(inputList);
                        break;
                    case "PrintOdd":
                        PrintOdd(inputList);
                        break;
                    case "GetSum":
                        PrintSum(inputList);
                        break;
                    case "Filter":
                        string condition = inputCommand[1];
                        int conditionBorderNumber = int.Parse(inputCommand[2]);
                        PrintWithFilter(condition, conditionBorderNumber, inputList);
                        break;
                    case "Add":
                        int numberToAdd = int.Parse(inputCommand[1]);
                        AddNumber(numberToAdd, inputList);
                        areChangesMade = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(inputCommand[1]);
                        RemoveNumber(numberToRemove, inputList);
                        areChangesMade = true;
                        break;
                    case "RemoveAt":
                        int indexToRemoveFrom = int.Parse(inputCommand[1]);
                        RemoveAtIndex(indexToRemoveFrom, inputList);
                        areChangesMade = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(inputCommand[1]);
                        int indexToInsertAt = int.Parse(inputCommand[2]);
                        InsertAtIndex(numberToInsert, indexToInsertAt, inputList);
                        areChangesMade = true;
                        break;
                    default: break;
                }
            }

            if (areChangesMade)
            {
                PrintList(inputList);
            }            
        }

        private static void PrintWithFilter(string condition, int conditionBorderNumber, List<int> inputList)
        {
            List<int> resultList = new List<int>();
            switch (condition)
            {
                case "<":
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i]<conditionBorderNumber)
                        {
                            int element = inputList[i];
                            resultList.Add(element);
                        }
                    }
                    break;
                case ">":
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] > conditionBorderNumber)
                        {
                            int element = inputList[i];
                            resultList.Add(element);
                        }
                    }
                    break;
                case "<=":
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] <= conditionBorderNumber)
                        {
                            int element = inputList[i];
                            resultList.Add(element);
                        }
                    }
                    break;
                case ">=":
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] >= conditionBorderNumber)
                        {
                            int element = inputList[i];
                            resultList.Add(element);
                        }
                    }
                    break;
                default: break;
            }
            Console.WriteLine(string.Join(" ", resultList));
        }

        private static void PrintSum(List<int> inputList)
        {
            int sum = inputList.Sum();
            Console.WriteLine(sum);
        }

        private static void PrintOdd(List<int> inputList)
        {
            List<int> oddList = new List<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 != 0)
                {
                    int element = inputList[i];
                    oddList.Add(element);
                }
            }
            if (oddList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", oddList));
            }
        }

        private static void PrintEven(List<int> inputList)
        {
            List<int> evenList = new List<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i]%2==0)
                {
                    int element = inputList[i];
                    evenList.Add(element);
                }
            }
            if (evenList.Count>0)
            {
                Console.WriteLine(string.Join(" ", evenList));
            }
        }

        private static void PrintIfContainsNumber(int checkedNumber, List<int> inputList)
        {
            if (inputList.Contains(checkedNumber))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        private static void PrintList(List<int> inputList)
        {
            Console.WriteLine(string.Join(" ", inputList));
        }
        
        private static void InsertAtIndex(int numberToInsert, int indexToInsertAt, List<int> inputList)
        {
            inputList.Insert(indexToInsertAt, numberToInsert);
        }

        private static void RemoveAtIndex(int indexToRemoveFrom, List<int> inputList)
        {
            inputList.RemoveAt(indexToRemoveFrom);
        }

        private static void RemoveNumber(int numberToRemove, List<int> inputList)
        {
            inputList.Remove(numberToRemove);
        }

        private static void AddNumber(int numberToAdd, List<int> inputList)
        {
            inputList.Add(numberToAdd);
        }
    
    }
}

