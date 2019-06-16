using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        public Employee()
        {

        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int numberOfEmploees = int.Parse(Console.ReadLine());

            AddEmploeesToList(numberOfEmploees, employees);

            var result = employees.GroupBy(e => e.Department)
                                  .Select(e => new
                                  {
                                      Department = e.Key,
                                      AverageSalary = e.Average(emp => emp.Salary),
                                      Employees = e.OrderByDescending(emp => emp.Salary)
                                  })
                                  .OrderByDescending(e => e.AverageSalary)
                                  .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
                

        private static void AddEmploeesToList(int numberOfEmploees, List<Employee> employees)
        {
            for (int i = 0; i < numberOfEmploees; i++)
            {
                string[] inputEmploee = Console.ReadLine().Split();
                string name = inputEmploee[0];
                decimal salary = decimal.Parse(inputEmploee[1]);
                string department = inputEmploee[2];
                Employee newEmploee = new Employee(name, salary, department);
                employees.Add(newEmploee);
            }
        }


    }
}
