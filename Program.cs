using System;
using System.Collections.Generic;
using System.Text;

namespace _4th_Lab
{
    internal class Program
    {
        static int minValue = -1000;
        static int maxValue = 1000;

        static void Main()
        {
            #region Testing buns
            //int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //Console.WriteLine(a[a.GetLength(0) - 2, a.GetLength(1) - 1]);
            #endregion

            //Task1_3();
            //Task1_6();
            //Task1_12();
            //Task1_13();
            //Task1_17();
            //Task1_29();
            //Task1_31();
            Task2_7();
        }

        #region Level1
        #region Task1_3
        static void Task1_3()
        {
            int[,] matrix = new int[4, 4];
            Matrix.Fill(matrix, minValue, maxValue);
            Matrix.Print(matrix);

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine($"Sum = {sum}");
        }
        #endregion

        #region Task1_6
        static void Task1_6()
        {
            int[,] matrix = new int[4, 7];
            Matrix.Fill(matrix, minValue, maxValue);
            Matrix.Print(matrix);

            string[] array = new string[0];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[i, 0];
                string index = $"({i}; 0)";
                for(int j = 1; j < matrix.GetLength(1); j++)
                {
                    if(min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        index = $"({i}; {j})";
                    }
                }
                Line.Add(ref array, index);
            }
            Console.WriteLine();
            Line.Print(array);
        }
        #endregion

        #region Task1_12
        static void Task1_12()
        {
            int[,] matrix = new int[6, 7];
            Matrix.Fill(matrix, minValue, maxValue);
            Matrix.Print(matrix);

            int[] index = Matrix.FindMax(matrix);
            Console.WriteLine();
            Line.Print(index);
            Console.WriteLine();

            Matrix.EraseRow(ref matrix, index[0]);
            Matrix.EraseCol(ref matrix, index[1]);

            Console.WriteLine();
            Matrix.Print(matrix);
        }
        #endregion

        #region Task1_13
        static void Task1_13()
        {
            int[,] matrix = new int[5, 5]; 
            Matrix.Fill(matrix, minValue, maxValue);
            Matrix.Print(matrix);
            Console.WriteLine();

            int[] fourth = Matrix.GetCol(matrix, 3);
            int index = Matrix.FindMaxOnDiag(matrix);
            int[] column = Matrix.GetCol(matrix, index);

            Matrix.SetCol(ref matrix, fourth, index);
            Matrix.SetCol(ref matrix, column, 3);

            Matrix.Print(matrix);
        }
        #endregion

        #region Task1_17
        static void Task1_17()
        {
            int n = Matrix.SetLengthRow();
            int m = Matrix.SetLengthCol();

            int[,] matrix = new int[n, m];
            Matrix.Fill(matrix, minValue, maxValue);
            Matrix.Print(matrix);
            Console.WriteLine();

            int[,] indexes = Matrix.FindMinOnRow(matrix);
            Matrix.Print(indexes);
            Console.WriteLine();

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowNumber = indexes[i, 0];
                int colNumber = indexes[i, 1];

                matrix[i, 0] += matrix[rowNumber, colNumber];
                matrix[rowNumber, colNumber] = matrix[i, 0] - matrix[rowNumber, colNumber];
                matrix[i, 0] = matrix[i, 0] - matrix[rowNumber, colNumber];
            }

            Matrix.Print(matrix);
        }
        #endregion

        #region Task1_29
        static void Task1_29()
        {
            int[,] matrix = new int[5, 7];
            Matrix.Fill(matrix, minValue, maxValue);
            Matrix.Print(matrix);
            Console.WriteLine();

            int colNumber = Matrix.FindMinOnRow(matrix, 1, true);
            Matrix.EraseCol(ref matrix, colNumber + 1);
            Console.WriteLine();
            Matrix.Print(matrix);
        }
        #endregion

        #region Task1_31
        static void Task1_31()
        {
            int[] column = new int[5];
            Line.Fill(column, minValue, maxValue);
            Line.Print(column);
            Console.WriteLine();

            int[,] matrix = new int[5, 8];
            Matrix.Fill(matrix, minValue, maxValue);
            Matrix.SetCol(ref matrix, 0, 7);
            Matrix.Print(matrix);

            int colNumber = Matrix.FindMinOnRow(matrix, matrix.GetLength(0) - 1) + 1;
            Matrix.MoveCols(ref matrix, colNumber);
            Console.WriteLine();
            Matrix.SetCol(ref matrix, column, colNumber);
            Matrix.Print(matrix);
        }
        #endregion
        #endregion

        #region Level2
        static void Task2_7()
        {
            int[,] matrix = new int[6, 6];
            Matrix.Fill(matrix, minValue, maxValue);
            Matrix.Print(matrix);
            Console.WriteLine();

            int index = Matrix.FindMaxOnDiag(matrix);

        }
        #endregion
    }
}
