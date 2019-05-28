using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int height = int.Parse(Console.ReadLine());
            //масив от едномерни масиви
            //броя на едномерните масиви е height
            long[][] triangle = new long[height][];
            
            //деклариране на всеки ред(едномерен масив) дължината му да е
            //row+1 елемента
            for (int row = 0; row < height; row++)
            {
                triangle[row] = new long[row + 1];
            }

            triangle[0][0] = 1;

            for (int row = 0; row < height-1; row++)
            {
                for (int col = 0; col <= row; col++)
                {//текущия елемент влиза като събираемо в двата под него
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            //отпечатване на триъгълника
            for (int row = 0; row < height; row++)
            {                
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(triangle[row][col] + " ");
                }
                Console.WriteLine();
            }




        }
    }
}
