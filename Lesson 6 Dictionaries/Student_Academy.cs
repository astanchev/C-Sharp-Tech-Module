using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName] = new List<double>();
                }
                studentGrades[studentName].Add(grade);
            }

            Dictionary<string, double> studentAverage = studentGrades
                                                        .ToDictionary(kvp => kvp.Key,
                                                                      kvp => kvp.Value.Average());

            foreach (var kvp in studentAverage
                                        .Where(kvp => kvp.Value >= 4.5)
                                        .OrderByDescending(kvp => kvp.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
