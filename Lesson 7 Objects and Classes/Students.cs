using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }

        public string Hometown { get; set; }

        public Student(string[] students)
        {
            this.FirstName = students[0];
            this.LastName = students[1];
            this.Age = students[2];
            this.Hometown = students[3];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] students = input.Split().ToArray();
                Student newStudent = new Student(students);
                studentsList.Add(newStudent);

            }

            string inputCity = Console.ReadLine();

            List<Student> filteredList = studentsList
                                        .Where(s => s.Hometown == inputCity)
                                        .ToList();

            foreach (var student in filteredList)
            {
                Console.WriteLine($"{student.FirstName} " +
                        $"{ student.LastName} is " +
                        $"{student.Age} years old.");
            }

            //foreach (var student in studentsList)
            //{
            //    if (student.Hometown==inputCity)
            //    {
            //        Console.WriteLine($"{student.FirstName} " +
            //            $"{ student.LastName} is " +
            //            $"{student.Age} years old.");
            //    }
            //}
        }
    }
}
