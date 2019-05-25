using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cellsWithFire = Console.ReadLine().Split('#');
            int totalWater = int.Parse(Console.ReadLine());
            List<int> putOutCells = new List<int>();
            int totalFire = 0;
            double effort = 0;

            for (int i = 0; i < cellsWithFire.Length; i++)
            {
                string typeOfFire = cellsWithFire[i].Split(" = ")[0];
                int valueOfCell = int.Parse(cellsWithFire[i].Split(" = ")[1]);

                switch (typeOfFire)
                {
                    case "High":
                        if (valueOfCell >= 81 && valueOfCell <= 125)
                        {
                            if (totalWater >= valueOfCell)
                            {
                                totalWater -= valueOfCell;
                                putOutCells.Add(valueOfCell);
                                effort += 0.25 * valueOfCell;
                            }
                        }
                        break;
                    case "Medium":
                        if (valueOfCell >= 51 && valueOfCell <= 80)
                        {
                            if (totalWater >= valueOfCell)
                            {
                                totalWater -= valueOfCell;
                                putOutCells.Add(valueOfCell);
                                effort += 0.25 * valueOfCell;
                            }
                        }
                        break;
                    case "Low":
                        if (valueOfCell >= 1 && valueOfCell <= 50)
                        {
                            if (totalWater >= valueOfCell)
                            {
                                totalWater -= valueOfCell;
                                putOutCells.Add(valueOfCell);
                                effort += 0.25 * valueOfCell;
                            }
                        }
                        break;
                    default: break;
                }
            }

            Console.WriteLine("Cells:");
            foreach (var cell in putOutCells)
            {
                Console.WriteLine($"- {cell}");
            }

            totalFire = putOutCells.Sum();
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
