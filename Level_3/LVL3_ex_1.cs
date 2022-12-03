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
            ex_1();
        }

        static int ex_1()
        {
            #region ex.1
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
                Console.WriteLine($"Row {i + 1}");
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
            List<(int, int)>  minElementsWithIndexes = new List<(int, int)> ();
            int min;
            int rowIndex;
            for(int i = 0; i < rows; i++)
            {
                min = matrix13[i, 0];
                rowIndex = 0;
                (int, int) tuple = (0, 0);
                for (int j = 0; j < cols; j++)
                {
                    if (matrix13[i, j] <= min)
                    {
                        min = matrix13[i, j];
                        rowIndex = i;
                        tuple = (min, rowIndex);
                    }
                }
                minElementsWithIndexes.Add(tuple);                
            }
            minElementsWithIndexes.Sort((a,b) => a.Item1.CompareTo(b.Item1));
            int[,] additionalMatrix = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    additionalMatrix[i, j] = matrix13[minElementsWithIndexes[i].Item2, j];
                }
            }
            int buffer;
            for(int i = 0; i < rows ; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix13[i, j] = additionalMatrix[i, j];
                }
            }
            Console.WriteLine("Lvl_3 || ex.1: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix13[i, j] + " ");
                }
                Console.WriteLine();
            }
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