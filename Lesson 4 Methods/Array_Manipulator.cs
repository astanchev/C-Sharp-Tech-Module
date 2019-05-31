using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            while (true)
            {
                string inputCommand = Console.ReadLine();
                if (inputCommand == "end")
                {
                    PrintArray(inputArray);
                    break;
                }
                string[] manipulation = inputCommand.Split().ToArray();
                switch (manipulation[0])
                {
                    case "exchange":
                        int indexOfExchange = int.Parse(manipulation[1]);
                        inputArray = Exchange(indexOfExchange, inputArray);
                        break;
                    case "max":
                        FindMax(manipulation[1], inputArray);
                        break;
                    case "min":
                        FindMin(manipulation[1], inputArray);
                        break;
                    case "first":
                        int countFirst = int.Parse(manipulation[1]);
                        FindFirst(countFirst, manipulation[2], inputArray);
                        break;
                    case "last":
                        int countLast = int.Parse(manipulation[1]);
                        FindLast(countLast, manipulation[2], inputArray);
                        break;
                    default: break;
                }
            }
        }

        static int[] Exchange(int index, int[] array)
        {
            if (index >= array.Length || index < 0)
            {
                Console.WriteLine("Invalid index");
                return array;
            }
            int[] firstArray = new int[index + 1];
            int[] secondArray = new int[array.Length - (index + 1)];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = array[i];
            }
            for (int i = 0, j = firstArray.Length; i < secondArray.Length; i++, j++)
            {
                secondArray[i] = array[j];
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                array[i] = secondArray[i];
            }
            for (int i = 0, j = secondArray.Length; i < firstArray.Length; i++, j++)
            {
                array[j] = firstArray[i];
            }

            return array;
        }

        static void FindMax(string parity, int[] array)
        {
            if (parity == "even")
            {
                int maxEven = int.MinValue;
                int maxIndex = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] >= maxEven)
                    {
                        maxEven = array[i];
                        maxIndex = i;
                    }
                }
                if (maxIndex < 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                else
                {
                    Console.WriteLine(maxIndex);
                }
            }
            else if (parity == "odd")
            {
                int maxOdd = int.MinValue;
                int maxIndex = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] >= maxOdd)
                    {
                        maxOdd = array[i];
                        maxIndex = i;
                    }
                }
                if (maxIndex < 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                else
                {
                    Console.WriteLine(maxIndex);
                }
            }

        }

        static void FindMin(string parity, int[] array)
        {
            if (parity == "even")
            {
                int minEven = int.MaxValue;
                int minIndex = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] <= minEven)
                    {
                        minEven = array[i];
                        minIndex = i;
                    }
                }
                if (minIndex < 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                else
                {
                    Console.WriteLine(minIndex);
                }
            }
            else if (parity == "odd")
            {
                int minOdd = int.MaxValue;
                int minIndex = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] <= minOdd)
                    {
                        minOdd = array[i];
                        minIndex = i;
                    }
                }
                if (minIndex < 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                else
                {
                    Console.WriteLine(minIndex);
                }
            }
        }

        static void FindFirst(int count, string parity, int[] array)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string even = string.Empty;
            string odd = string.Empty;
            if (parity == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        even += (char)array[i];
                    }
                }
                if (even == string.Empty)
                {
                    Console.WriteLine("[]");
                    return;
                }
                else
                {
                    int[] first = new int[even.Length];
                    for (int i = 0; i < even.Length; i++)
                    {
                        first[i] = even[i];
                    }
                    if (first.Length < count)
                    {
                        PrintArray(first);
                        return;
                    }
                    else
                    {
                        int[] firstElements = new int[count];
                        for (int i = 0; i < firstElements.Length; i++)
                        {
                            firstElements[i] = first[i];
                        }
                        PrintArray(firstElements);
                        return;
                    }
                }
            }
            else if (parity == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        odd += (char)array[i];
                    }
                }
                if (odd == string.Empty)
                {
                    Console.WriteLine("[]");
                    return;
                }
                else
                {
                    int[] first = new int[odd.Length];
                    for (int i = 0; i < odd.Length; i++)
                    {
                        first[i] = odd[i];
                    }
                    if (first.Length < count)
                    {
                        PrintArray(first);
                        return;
                    }
                    else
                    {
                        int[] firstElements = new int[count];
                        for (int i = 0; i < firstElements.Length; i++)
                        {
                            firstElements[i] = first[i];
                        }
                        PrintArray(firstElements);
                        return;
                    }
                }
            }
        }

        static void FindLast(int count, string parity, int[] array)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string even = string.Empty;
            string odd = string.Empty;
            if (parity == "even")
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0)
                    {
                        even += (char)array[i];
                    }
                }
                if (even == string.Empty)
                {
                    Console.WriteLine("[]");
                    return;
                }
                else
                {
                    int[] last = new int[even.Length];
                    for (int i = 0; i < even.Length; i++)
                    {
                        last[i] = even[i];
                    }
                    if (last.Length < count)
                    {
                        PrintArray(last);
                        return;
                    }
                    else
                    {
                        int[] lastElements = new int[count];
                        for (int i = 0, j = last.Length - count;
                                    i < lastElements.Length; i++, j++)
                        {
                            lastElements[i] = last[j];
                        }
                        PrintArray(lastElements);
                        return;
                    }
                }
            }
            else if (parity == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        odd += (char)array[i];
                    }
                }
                if (odd == string.Empty)
                {
                    Console.WriteLine("[]");
                    return;
                }
                else
                {
                    int[] last = new int[odd.Length];
                    for (int i = 0; i < odd.Length; i++)
                    {
                        last[i] = odd[i];
                    }
                    if (last.Length < count)
                    {
                        PrintArray(last);
                        return;
                    }
                    else
                    {
                        int[] lastElements = new int[count];
                        for (int i = 0, j = last.Length - count;
                                    i < lastElements.Length; i++, j++)
                        {
                            lastElements[i] = last[j];
                        }
                        PrintArray(lastElements);
                        return;
                    }
                }
            }
        }

        static void PrintArray(int[] array)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", array));
            Console.WriteLine("]");

        }
    }
}
