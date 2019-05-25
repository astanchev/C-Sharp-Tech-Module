using System;

namespace _01._Bonus_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            double maximumBonus = 0;
            int maxStudentAttendances = 0;

            for (int i = 0; i < students; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double totalBonus = 0.0;
                if (lectures != 0)
                {
                    totalBonus = 1.0 * attendances / lectures * (5 + initialBonus);
                }
                
                if (totalBonus > maximumBonus)
                {
                    maximumBonus = totalBonus;
                    maxStudentAttendances = attendances;
                }
            }

            Console.WriteLine($"The maximum bonus score for this course is {Math.Round(maximumBonus)}.The student has attended {maxStudentAttendances} lectures.");
        }
    }
}
