using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Students_2._0
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }

        public string Hometown { get; set; }

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
                string firstName = students[0];
                string lastName = students[1];
                string age = students[2];
                string homeTown = students[3];

                if (IsStudentExist(studentsList, firstName, lastName))
                {
                    Student existingStudent = GetStudent(studentsList, firstName, lastName);
                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.Hometown = homeTown;
                }
                else
                {
                    Student newStudent = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = homeTown
                    };
                    studentsList.Add(newStudent);
                };
            }



            string inputCity = Console.ReadLine();

            foreach (Student student in studentsList)
            {
                if (student.Hometown == inputCity)
                {
                    Console.WriteLine($"{student.FirstName} " +
                        $"{ student.LastName} is " +
                        $"{student.Age} years old.");
                }
            }
        }

        static Student GetStudent(List<Student> studentsList, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in studentsList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        static bool IsStudentExist(List<Student> studentsList, string firstName, string lastName)
        {
            foreach (Student student in studentsList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
