using System;

namespace _01._SoftUni_Reception_01._07._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1StudentsPerHour = int.Parse(Console.ReadLine());
            int employee2StudentsPerHour = int.Parse(Console.ReadLine());
            int employee3StudentsPerHour = int.Parse(Console.ReadLine());
            int allStudents = int.Parse(Console.ReadLine());

            int totalStudentsPerHour = employee1StudentsPerHour + employee2StudentsPerHour + employee3StudentsPerHour;
            int totalTimeWithoutBreak = allStudents / totalStudentsPerHour;
            int totalTime = 0;
            while (true)
            {
                if (allStudents<=0)
                {
                    break;
                }
                totalTime++;
                if (totalTime % 4 == 0)
                {
                    totalTime ++;
                }
                
                allStudents -= totalStudentsPerHour;                
            }
            Console.WriteLine($"Time needed: {totalTime}h.");
        }
    }
}
