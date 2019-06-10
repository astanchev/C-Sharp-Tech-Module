using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                string[] inputLine = input.Split(" : ");
                string courseName = inputLine[0];
                string student = inputLine[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();                    
                }
                courses[courseName].Add(student);
            }

            foreach (var kvp in courses
                                .OrderByDescending(kvp => kvp.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value.OrderBy(s => s))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
