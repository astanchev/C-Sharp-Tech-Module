using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Command_Interpreter_10._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine()
                                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] inputLine = input.Split();
                string command = inputLine[0];

                switch (command)
                {
                    case "reverse":
                        {
                            int start = int.Parse(inputLine[2]);
                            int count = int.Parse(inputLine[4]);
                            if (start < 0
                                         || start > array.Count - 1
                                         || count > array.Count - start
                                         || count < 0)
                            {
                                Console.WriteLine("Invalid input parameters.");
                                continue;
                            }
                            else
                            {
                                Reverse(start, count, array);
                            }
                        }
                        break;
                    case "sort":
                        {
                            int start = int.Parse(inputLine[2]);
                            int count = int.Parse(inputLine[4]);
                            if (start < 0
                                         || start > array.Count - 1
                                         || count > array.Count - start
                                         || count < 0)
                            {
                                Console.WriteLine("Invalid input parameters.");
                                continue;
                            }
                            else
                            {
                                Sort(start, count, array);
                            }
                        }
                        break;
                    case "rollLeft":
                        {
                            int count = int.Parse(inputLine[1]);
                            if (count < 0)
                            {
                                Console.WriteLine("Invalid input parameters.");
                                continue;
                            }
                            else
                            {
                                RollLeft(count, array);
                            }
                        }
                        break;
                    case "rollRight":
                        {
                            int count = int.Parse(inputLine[1]);
                            if (count < 0)
                            {
                                Console.WriteLine("Invalid input parameters.");
                                continue;
                            }
                            else
                            {
                                RollRight(count, array);
                            }
                        }
                        break;

                    default: break;
                }
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        private static void RollRight(int count, List<string> array)
        {
            for (int i = 0; i < count % array.Count; i++)
            {
                string temp = array[array.Count - 1];
                array.RemoveAt(array.Count - 1);
                array.Insert(0, temp);
            }
        }

        private static void RollLeft(int count, List<string> array)
        {
            for (int i = 0; i < count % array.Count; i++)
            {
                string temp = array[0];
                array.RemoveAt(0);
                array.Add(temp);
            }
        }

        private static void Sort(int start, int count, List<string> array)
        {
            List<string> sortedElements = new List<string>();
            for (int i = start; i < start + count; i++)
            {
                sortedElements.Add(array[i]);
            }
            sortedElements.Sort();
            array.RemoveRange(start, count);
            array.InsertRange(start, sortedElements);
        }

        private static void Reverse(int start, int count, List<string> array)
        {
            List<string> reversedElements = new List<string>();
            for (int i = start; i < start + count; i++)
            {
                reversedElements.Add(array[i]);
            }
            reversedElements.Reverse();
            array.RemoveRange(start, count);
            array.InsertRange(start, reversedElements);
        }
    }
}
