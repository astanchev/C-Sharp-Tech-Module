using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Students_2
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line = Console.ReadLine().Trim();
            while (line != "end")
            {
                string[] tokens = line.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                if (IsStudentExist(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = city;
                }
                else
                {
                    Student student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = city
                    };

                    students.Add(student);
                }
                
                line = Console.ReadLine().Trim();
            }

            string filterCity = Console.ReadLine();
            List<Student> filteredStudents = students
                                            .Where(s => s.HomeTown == filterCity)
                                            .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} " +
                        $"{ student.LastName} is " +
                        $"{student.Age} years old.");
            }

        }

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        private static bool IsStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
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
