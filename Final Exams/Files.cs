using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04._Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var rootNameLength = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                int indexOfFirst = input.IndexOf('\\');
                int indexOfLast = input.LastIndexOf('\\');

                string root = input.Remove(indexOfFirst);
                string[] fileAndLength = input.Substring(indexOfLast + 1).Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string file = fileAndLength[0];
                long length = long.Parse(fileAndLength[fileAndLength.Length-1]);

                if (!rootNameLength.ContainsKey(root))
                {
                    rootNameLength[root] = new Dictionary<string, long>();
                }

                if (!rootNameLength[root].ContainsKey(file))
                {
                    rootNameLength[root][file] = 0;
                }

                rootNameLength[root][file] = length;
            }

            string[] command = Console.ReadLine().Split( new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            string filesToShow = "." + command[0];
            string rootToShow = command[2];

            bool isRootContainFile = false;
            if (rootNameLength.ContainsKey(rootToShow))
            {
                foreach (var file in rootNameLength[rootToShow])
                {
                    if (file.Key.Contains(filesToShow))
                    {
                        isRootContainFile = true;
                    }
                }
            }
            

            if (isRootContainFile)
            {
                foreach (var file in rootNameLength[rootToShow]
                                        .Where(f=>f.Key.Contains(filesToShow))
                                        .OrderByDescending(f=>f.Value)
                                        .ThenBy(f=>f.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
