using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int index = input.LastIndexOf('\\');
            string file = input.Substring(index+1);
            string[] fileParts = file.Split('.');
            string name = fileParts[0];
            string extension = fileParts[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
