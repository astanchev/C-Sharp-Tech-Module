using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfValues = Console.ReadLine();
            string result = string.Empty;
            switch (typeOfValues)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    result = GetMax(firstNumber, secondNumber).ToString();
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    result = GetMax(firstChar, secondChar).ToString();
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    result = GetMax(firstString, secondString);
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
        }

        static int GetMax(int firstNumber, int secondNumber)
        {

            int result = int.MinValue;
            if (firstNumber > secondNumber)
            {
                result = firstNumber;
            }
            else
            {
                result = secondNumber;
            }
            return result;
        }

        static char GetMax(char firstChar, char secondChar)
        {

            char result = char.MinValue;
            if (firstChar > secondChar)
            {
                result = firstChar;
            }
            else
            {
                result = secondChar;
            }
            return result;
        }

        static string GetMax(string firstString, string secondString)
        {

            string result = string.Empty;
            //if (firstString.Length > secondString.Length)
            //{
            //    result = firstString;
            //}
            //else if(firstString.Length < secondString.Length)
            //{
            //    result = secondString;
            //}
            //else
            //{
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (firstString[i]>secondString[i])
                    {
                        result = firstString;
                        return result;
                    }
                    else if (firstString[i] < secondString[i])
                    {
                        result = secondString;
                        return result;
                    }
                //}
                result = firstString;
            }
            
            return result;
        }
    }
}
