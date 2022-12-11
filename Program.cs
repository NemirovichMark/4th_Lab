using System;
using System.Linq;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            #region III|8 
            Console.WriteLine("III|8");

            double[,] matrix = new double[7, 5] { {4, 5, 6, 7, 5},
                                        {1, -7, 2, 0, -7},
                                        {9, 4, 3, 6, 4},
                                        {2, 4, -7, 5, 4},
                                        {7, -1, 3, 9, -2},
                                        {3, 5, 1, -2, -9},
                                        {5, 2, -10, 4, 2}};
            double[,] answ = new double[7, 5];
            int row = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / row;
            double[,] matrix1 = new double[row, 2];
            double num1 = 0;
            double num2 = 0;

            for (int i = 0; i < row; i++)
            {
                matrix1[i, 0] = i;
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix1[i, 1]++;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row - i - 1; j++)
                {
                    if (matrix1[j, 1] < matrix1[j + 1, 1])
                    {
                        num1 = matrix1[j, 0];
                        num2 = matrix1[j, 1];
                        matrix1[j, 0] = matrix1[j + 1, 0];
                        matrix1[j, 1] = matrix1[j + 1, 1];
                        matrix1[j + 1, 0] = num1;
                        matrix1[j + 1, 1] = num2;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    answ[i, j] = matrix[(int)matrix1[i, 0], j];
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", answ[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region III|10 
            Console.WriteLine("III|10");

            matrix = new double[7, 5] { {4, 5, 6, 7, 5},
                                        {1, -7, 2, 0, -7},
                                        {9, 4, 3, 6, 4},
                                        {2, 4, -7, 5, 4},
                                        {7, -1, 3, 9, -2},
                                        {3, 5, 1, -2, -9},
                                        {5, 2, -10, 4, 2}};
            double[] array = new double[5];
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            num1 = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) array[j] = matrix[i, j];
                Array.Sort(array);
                if (i % 2 == 0)
                {
                    for (int j = 0; j < col/2; j++)
                    {
                        num1 = array[j];
                        array[j] = array[col - j - 1];
                        array[col - j - 1] = num1;
                    }
                }
                for (int j = 0; j < col; j++) matrix[i, j] = array[j];
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");

            #endregion
        }
    }
}