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
            //Task1_3();
            //Task1_6();
            Task1_12();
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
            Console.WriteLine();
            Matrix.EraseRow(ref matrix, 4);
            Matrix.Print(matrix);
        }
        #endregion
        #endregion
    }
}
