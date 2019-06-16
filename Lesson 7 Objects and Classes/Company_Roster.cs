using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
    }

    class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
        public decimal TotalSalaries { get; set; }

        public void AddNewEmployee(string empName, decimal empSalary)
        {
            this.TotalSalaries += empSalary;

            this.Employees.Add(new Employee(empName, empSalary));
        }

        public Department(string departmentName)
        {
            this.Employees = new List<Employee>();
            this.DepartmentName = departmentName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            int numberOfEmploees = int.Parse(Console.ReadLine());

            AddEmploeesToList(numberOfEmploees, departments);

            Department bestDepartment = GetBestDepartment(departments);

            PrintBestDepartment(bestDepartment);

        }

        private static void PrintBestDepartment(Department bestDepartment)
        {
            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

            foreach (var employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }

        private static Department GetBestDepartment(List<Department> departments)
        {
            return departments.OrderByDescending(d => d.TotalSalaries / d.Employees.Count).First();
        }

        private static void AddEmploeesToList(int numberOfEmploees, List<Department> departments)
        {
            for (int i = 0; i < numberOfEmploees; i++)
            {
                string[] inputEmployee = Console.ReadLine().Split();
                string name = inputEmployee[0];
                decimal salary = decimal.Parse(inputEmployee[1]);
                string department = inputEmployee[2];
                if (!departments.Any(d => d.DepartmentName == department))
                {
                    departments.Add(new Department(department));
                }

                departments.Find(d => d.DepartmentName == department)
                           .AddNewEmployee(name, salary);
            }
        }


    }
}
