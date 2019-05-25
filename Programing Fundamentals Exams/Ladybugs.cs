using System;
using System.Linq;

namespace _02._Ladybugs_23._10._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] inputPositions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] realPositions = new int[sizeOfField];
            bool[] ladyBugPosition = new bool[sizeOfField];

            for (int i = 0; i < sizeOfField; i++)
            {
                for (int j = 0; j < inputPositions.Length; j++)
                {
                    if (i == inputPositions[j])
                    {
                        realPositions[i] = 1;
                    }
                }
            }

            for (int i = 0; i < sizeOfField; i++)
            {
                if (realPositions[i] == 1)
                {
                    ladyBugPosition[i] = true;
                }
                else
                {
                    ladyBugPosition[i] = false;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] commandLine = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int ladyBugStartPosition = int.Parse(commandLine[0]);
                string ladyBugDirection = commandLine[1];
                int ladyBugFlyLenght = int.Parse(commandLine[2]);


                if (ladyBugStartPosition > ladyBugPosition.Length - 1 || ladyBugStartPosition < 0)
                {
                    continue;
                }
                else if (ladyBugPosition[ladyBugStartPosition] == false)
                {
                    continue;
                }
                else
                {
                    ladyBugPosition[ladyBugStartPosition] = false;
                    realPositions[ladyBugStartPosition] = 0;
                    if (ladyBugDirection == "right")
                    {
                        ladyBugStartPosition += ladyBugFlyLenght;
                        if (ladyBugStartPosition < ladyBugPosition.Length)
                        {
                            if (ladyBugPosition[ladyBugStartPosition] == false)
                            {
                                ladyBugPosition[ladyBugStartPosition] = true;
                                realPositions[ladyBugStartPosition] = 1;
                            }
                            else
                            {
                                while (true)
                                {
                                    ladyBugStartPosition += ladyBugFlyLenght;
                                    if (ladyBugStartPosition > ladyBugPosition.Length - 1)
                                    {
                                        break;
                                    }
                                    else if (ladyBugPosition[ladyBugStartPosition] == false)
                                    {
                                        ladyBugPosition[ladyBugStartPosition] = true;
                                        realPositions[ladyBugStartPosition] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (ladyBugDirection == "left")
                    {
                        ladyBugStartPosition -= ladyBugFlyLenght;
                        if (ladyBugStartPosition >= 0)
                        {
                            if (ladyBugPosition[ladyBugStartPosition] == false)
                            {
                                ladyBugPosition[ladyBugStartPosition] = true;
                                realPositions[ladyBugStartPosition] = 1;
                            }
                            else
                            {
                                while (true)
                                {
                                    ladyBugStartPosition -= ladyBugFlyLenght;
                                    if (ladyBugStartPosition < 0)
                                    {
                                        break;
                                    }
                                    else if (ladyBugPosition[ladyBugStartPosition] == false)
                                    {
                                        ladyBugPosition[ladyBugStartPosition] = true;
                                        realPositions[ladyBugStartPosition] = 1;
                                    }
                                }
                            }
                        }
                    }

                }
            }

            for (int i = 0; i < realPositions.Length; i++)
            {
                Console.Write($"{realPositions[i]} ");
            }
        }
    }
}
