using System;
using System.Reflection;
using System.Collections.Generic;
using System.Numerics;
using System.Data;
using System.Linq;
using System.Globalization;

namespace _4th_Lab
{
    class Theory
    {
        public static void Main()
        {
            ex_29();
        }

        static int ex_29()
        {
            #region ex.29
            int rows = 0;
            int cols = 0;
            Console.Write("Enter the number of rows: ");
            if (int.TryParse(Console.ReadLine(), out rows))
            {
                Console.Write("Enter the number of cols: ");
                if (int.TryParse(Console.ReadLine(), out cols))
                {
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Enter correct data!");
            if (rows <= 0 || cols <= 0) return 0;
            int[,] matrix13 = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Rows {i + 1}");
                string[] rowElements = Console.ReadLine().Split(' ');
                if (rowElements.Length == cols)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (int.TryParse(rowElements[j], out int element))
                        {
                            matrix13[i, j] = element;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect data");
                            return 0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not enough elements");
                    return 0;
                }
            }
            if (rows >= 2)
            {
                int min = matrix13[1, 0];
                int colsIndex = 0;
                for (int i = 0; i < cols; i++)
                {
                    if (matrix13[1, i] < min) { min = matrix13[1, i]; colsIndex = i; }
                }
                int colNumber = colsIndex;
                cols = cols - 1;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = colNumber + 1; j < cols; j++)
                    {
                        matrix13[i, j] = matrix13[i, j + 1];
                    }
                }
                Console.WriteLine("Lvl_1 || ex.29: ");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix13[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                return 0;
            }
            else Console.WriteLine("Task requires a matrix with 2xM size");
            return 0;
            #endregion
        }

            #region Algorithms for tasks
            static int Min(int[] list)
        {
            int min = list[0];
            for (int i = 0; i < list.Length; i++)
            {                
                if (list[i] < min) min = list[i];   
            }
            return min;
        }
        static int MinForMatrix(int[,] list)
        {
            int min = list[0,0];
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.GetLength(i); i++)
                {
                    if (list[i, j] < min) min = list[i, j];
                }
            }
            return min;
        }

        static int Max(int[,] list)
        {
            int max = list[0,0];
            for (int i = 0; i < list.Length; i++)
            {
                for(int j = 0; j < list.GetLength(i); j++)
                {
                    if (list[i,j] > max) max = list[i,j];
                }
            }
            return max;
        }

        static (int rowWithMax, int columnWithMax) MaxIndex(int[,] list, int row, int columns)
        {
            int max = list[0,0];
            int rowWithMax = 0;
            int columnWithMax = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns ; j++)
                {
                    if (list[i,j] > max)
                    {
                        max = list[i,j];
                        rowWithMax = i;
                        columnWithMax = j;
                    }
                }
            }
            (int, int) result = (rowWithMax, columnWithMax);
            return result;
        }
        #endregion
    }
}