using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrayOfData = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "3:1")
                {
                    Console.WriteLine(string.Join(" ", arrayOfData));
                    return;
                }

                List<string> inputComand = input
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
                string command = inputComand[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(inputComand[1]);
                    int endIndex = int.Parse(inputComand[2]);
                    Merge(startIndex, endIndex, arrayOfData);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(inputComand[1]);
                    int partitions = int.Parse(inputComand[2]);
                    Divide(index, partitions, arrayOfData);
                }
            }
        }

        private static void Divide(int index, int partitions, List<string> arrayOfData)
        {
            string temp = arrayOfData[index];
            List<char> tempListChars = temp.ToList();
            List<string> tempListStrings = new List<string>();
            
            if (tempListChars.Count % partitions == 0)
            {
                int stringRange = tempListChars.Count / partitions;
                for (int i = 0; i < partitions; i++)
                {
                    string charsToString = string.Empty;
                    for (int j = 0; j < stringRange; j++)
                    {
                        charsToString  += tempListChars[j].ToString();
                    }
                    tempListStrings.Add(charsToString);
                    tempListChars.RemoveRange(0, stringRange);
                }
                arrayOfData.RemoveAt(index);
                arrayOfData.InsertRange(index, tempListStrings);
            }
            else
            {
                int stringRange = tempListChars.Count / partitions;
                for (int i = 0; i < partitions-1; i++)
                {
                    string charsToString = string.Empty;
                    for (int j = 0; j < stringRange; j++)
                    {
                        charsToString += tempListChars[j].ToString();
                    }
                    tempListStrings.Add(charsToString);
                    tempListChars.RemoveRange(0, stringRange);
                }
                string restChars = string.Empty;
                for (int i = 0; i < tempListChars.Count; i++)
                {
                    restChars += tempListChars[i].ToString();
                }
                tempListStrings.Add(restChars);
                arrayOfData.RemoveAt(index);
                arrayOfData.InsertRange(index, tempListStrings);
            }
        }

        private static void Merge(int startIndex, int endIndex, List<string> arrayOfData)
        {
            string temp = string.Empty;
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > arrayOfData.Count - 1)
            {
                return;
            }
            if (endIndex > arrayOfData.Count - 1)
            {
                endIndex = arrayOfData.Count - 1;
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                temp += arrayOfData[i];
            }
            arrayOfData[startIndex] = temp;
            int range = endIndex - startIndex;
            arrayOfData.RemoveRange(startIndex + 1, range);
        }
    }
}
