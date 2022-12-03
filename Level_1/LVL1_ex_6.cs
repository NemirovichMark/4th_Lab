using System;
using System.Reflection;
using System.Collections.Generic;
using System.Numerics;
using System.Data;
using System.Linq;

namespace _4th_Lab
{
    class Theory
    {
        public static void Main()
        {
            ex_6();
        }

        static int ex_6()
        {

            #region ex.6
            int rows = 0;
            int cols = 0;
            int[] indexes = new int[4];
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
            int[,] matrix6 = new int[rows, cols];
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
                            matrix6[i, j] = element;
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

            for(int i = 0; i < rows; i++)
            {
                int min = matrix6[0,0];
                for(int j = 0; j < cols; j++)
                {   
                    if(matrix6[i,j] < min) min = matrix6[i,j];
                }
                indexes[i] = min;
            }
            Console.Write("Lvl_1 || ex.6: ");
            foreach(int i in indexes)
            {
                Console.Write(i + "; ");
            }
            return 0;
        }
        #endregion

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

        static (int rowWithMax, int columnWithMax) MaxIndex(int[,] list)
        {
            int max = list[0,0];
            int rowWithMax = 0;
            int columnWithMax = 0;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.GetLength(i) ; j++)
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