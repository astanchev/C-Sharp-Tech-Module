using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Anonymous_Threat_05._11._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputArray = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "3:1")
                {
                    Console.WriteLine(string.Join(" ", inputArray));
                    return;
                }
                string[] inputLine = input.Split();
                string command = inputLine[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(inputLine[1]);
                    int endIndex = int.Parse(inputLine[2]);
                    Merge(startIndex, endIndex, inputArray);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(inputLine[1]);
                    int partitions = int.Parse(inputLine[2]);
                    Divide(index, partitions, inputArray);
                }
            }
        }

        private static void Divide(int index, int partitions, List<string> inputArray)
        {
            List<char> stringToChars = inputArray[index].ToList();
            List<string> charsToStrings = new List<string>();

            if (stringToChars.Count % partitions == 0)
            {
                int partitionLenght = stringToChars.Count / partitions;
                for (int i = 0; i < partitions; i++)
                {
                    string tempWord = string.Empty;
                    for (int j = 0; j < partitionLenght; j++)
                    {
                        tempWord += stringToChars[j].ToString();
                    }
                    charsToStrings.Add(tempWord);
                    stringToChars.RemoveRange(0, partitionLenght);
                }
            }
            else
            {
                int partitionLenght = stringToChars.Count / partitions;
                for (int i = 0; i < partitions-1; i++)
                {
                    string tempWord = string.Empty;
                    for (int j = 0; j < partitionLenght; j++)
                    {
                        tempWord += stringToChars[j].ToString();
                    }
                    charsToStrings.Add(tempWord);
                    stringToChars.RemoveRange(0, partitionLenght);
                }
                string lastPartition = string.Empty;
                for (int i = 0; i < stringToChars.Count; i++)
                {
                    lastPartition += stringToChars[i].ToString();
                }
                charsToStrings.Add(lastPartition);
            }
            inputArray.InsertRange(index, charsToStrings);
            inputArray.RemoveAt(index+ charsToStrings.Count);
        }

        private static void Merge(int startIndex, int endIndex, List<string> inputArray)
        {
            if (startIndex > inputArray.Count - 1)
            {
                return;
            }
            else if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > inputArray.Count - 1)
            {
                endIndex = inputArray.Count - 1;
            }

            string temp = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                temp += inputArray[i];
            }
            int range = endIndex - startIndex + 1;
            inputArray.Insert(startIndex, temp);
            inputArray.RemoveRange(startIndex+1, range);
        }
    }
}
