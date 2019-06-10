using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentPoints = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }
                string[] inputLine = input.Split('-');
                string name = inputLine[0];
                if (inputLine[1] == "banned")
                {
                    if (studentPoints.ContainsKey(name))
                    {
                        studentPoints.Remove(name);
                    }
                }
                else
                {
                    string language = inputLine[1];
                    int points = int.Parse(inputLine[2]);

                    if (!studentPoints.ContainsKey(name))
                    {
                        studentPoints[name] = points;
                    }
                    else
                    {
                        if (points > studentPoints[name])
                        {
                            studentPoints[name] = points;
                        }
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions[language] = 0;
                    }
                    submissions[language]++;
                }
            }

            Console.WriteLine("Results:");
            foreach (var student in studentPoints
                                    .OrderByDescending(s => s.Value)
                                    .ThenBy(s => s.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var lang in submissions
                                 .OrderByDescending(l => l.Value)
                                 .ThenBy(l => l.Key))
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}
