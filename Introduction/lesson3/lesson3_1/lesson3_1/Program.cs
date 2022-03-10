using System;

namespace lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую элементы двухмерного массива по диагонали
            int[,] matrix = { { 1, 3, 4},{2, 6, 7 },{4, 8, 9 }};
            for (int i =0; i<matrix.GetLength(0); i++)
            {
                for (int j = 0; j<matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine($"{matrix[i, j]}");
                    }

                }
            }
        }
    }
}
