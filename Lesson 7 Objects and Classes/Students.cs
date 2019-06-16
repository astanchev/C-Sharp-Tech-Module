using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());
            List<Students> studentsList = new List<Students>();
            for (int i = 0; i < numberStudents; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                string firstName = inputLine[0];
                string lastName = inputLine[1];
                double grade = double.Parse(inputLine[2]);

                Students newStudent = new Students(firstName, lastName, grade);
                studentsList.Add(newStudent);
            }
            List<Students> orderedtudentsList = studentsList
                                                .OrderByDescending(s => s.Grade)
                                                .ToList();

            foreach (var student in orderedtudentsList)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
