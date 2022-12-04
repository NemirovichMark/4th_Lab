using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _4th_Lab
{
    internal class Matrix
    {
        static Random rand;

        #region OutPut
        public static void Print(int[,] source)
        {
            if(source == null)
            {
                Error.Kill();
            }

            for(int i = 0; i < source.GetLength(0); i++)
            {
                for(int j = 0; j < source.GetLength(1); j++)
                {
                    Console.Write($"{source[i, j], 6}");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Set
        public static int SetLengthRow()
        {
            int n = 0;
            while (n <= 0)
            {
                Console.Write("input row: ");
                int.TryParse(Console.ReadLine(), out n);
            }
            return n;
        }

        public static void SetRow(int[,] source, int[] row, int rowNumber)
        {
            if (source == null || row == null)
            {
                Error.Kill();
            }

            if (row.Length != source.GetLength(1) || rowNumber >= source.GetLength(0))
            {
                Error.Kill();
            }

            for (int j = 0; j < source.GetLength(1); j++)
            {
                source[rowNumber, j] = row[j];
            }
        }

        public static void SetRowInRange(int[,] source, int element, int rowNumber, int colNumber)
        {
            if(source == null)
            {
                Error.Kill();
            }

            if(rowNumber < 0 || rowNumber >= source.GetLength(0))
            {
                Error.Kill();
            }

            if(colNumber < 0)
            {
                Error.Kill();
            }

            for(int j = colNumber; j < source.GetLength(1); j++)
            {
                source[rowNumber, j] = element;
            }
        }

        public static int SetLengthCol()
        {
            int n = 0;
            while (n <= 0)
            {
                Console.Write("input col: ");
                int.TryParse(Console.ReadLine(), out n);
            }
            return n;
        }

        public static void SetCol(int[,] source, int[] col, int colNumber)
        {
            if(source == null || col == null)
            {
                Error.Kill();
            }

            if(col.Length != source.GetLength(0) || colNumber >= source.GetLength(1))
            {
                Error.Kill();
            }

            for (int i = 0; i < source.GetLength(0); i++)
            {
                source[i, colNumber] = col[i];
            }
        }

        public static void SetCol(int[,] source, int element, int colNumber)
        {
            if(source == null)
            {
                Error.Kill();
            }

            if(colNumber >= source.GetLength(1) || colNumber < 0)
            {
                Error.Kill();
            }

            for(int i = 0; i < source.GetLength(0); i++)
            {
                source[i, colNumber] = element;
            }
        }

        #endregion

        #region Get
        public static int[] GetRow(int[,] source, int row)
        {
            if (source == null)
            {
                Error.Kill();
            }

            if (row < 0 || row >= source.GetLength(0))
            {
                Error.Kill();
            }

            int[] array = new int[0];
            for (int j = 0; j < source.GetLength(1); j++)
            {
                Line.Add(ref array, source[row, j]);
            }

            return array;
        }

        public static int[] GetCol(int[,] source, int col)
        {
            if(source == null)
            {
                Error.Kill();
            }

            if(col < 0 || col >= source.GetLength(1))
            {
                Error.Kill();
            }

            int[] array = new int[0];
            for(int i = 0; i < source.GetLength(0); i++)
            {
                Line.Add(ref array, source[i, col]);
            }

            return array;
        }
        #endregion

        #region Fill
        public static void Fill(int[,] matrix, int minValue, int maxValue)
        {
            if(matrix == null)
            {
                Error.Kill();
            }

            int seed = DateTime.Now.Millisecond;
            rand = new Random(seed);
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(minValue, maxValue);
                }
            }
        }
        #endregion

        #region Search

        #region Max
        /// <summary>
        /// Search for the largest value across the entire matrix
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int[] FindMax(int[,] source)
        {
            if(source == null)
            {
                Error.Kill();
            }

            int max = source[0, 0];
            int[] index = { 0, 0 };
            for(int i = 0; i < source.GetLength(0); i++)
            {
                for(int j = 0; j < source.GetLength(1); j++)
                {
                    if (max < source[i, j])
                    {
                        max = source[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }

            return index;
        }

        public static int[,] FindMaxOnRow(int[,] source)
        {
            if (source == null)
            {
                Error.Kill();
            }

            int[,] indexes = new int[source.GetLength(0), 2];
            for (int i = 0; i < source.GetLength(0); i++)
            {
                int max = source[i, 0];
                for (int j = 0; j < source.GetLength(1); j++)
                {
                    if (max < source[i, j])
                    {
                        max = source[i, j];
                        indexes[i, 0] = i;
                        indexes[i, 1] = j;
                    }
                }
            }

            return indexes;
        }

        public static int FindMaxOnDiag(int[,] source)
        {
            if(source == null)
            {
                Error.Kill();
            }

            if(source.GetLength(1) != source.GetLength(0))
            {
                Error.Kill();
            }

            int max = source[0, 0];
            int index = 0;
            for(int i = 0; i < source.GetLength(0); i++)
            {
                if(max < source[i, i])
                {
                    max = source[i, i];
                    index = i;
                }
            }

            return index;
        }
        #endregion

        #region Min
        /// <summary>
        /// Finding the minimum value on each row
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int[,] FindMinOnRow(int[,] source)
        {
            if(source == null)
            {
                Error.Kill();
            }

            int[,] indexes = new int[source.GetLength(0), 2];
            for(int i = 0; i < source.GetLength(0); i++)
            {
                int min = source[i, 0];
                for(int j = 0; j < source.GetLength(1); j++)
                {
                    if(min > source[i, j])
                    {
                        min = source[i, j];
                        indexes[i, 0] = i;
                        indexes[i, 1] = j;
                    }
                }
            }

            return indexes;
        }

        /// <summary>
        /// Finding the minimum value on a specific row
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="rowNumber"></param>
        /// <returns></returns>
        public static int FindMinOnRow(int[,] matrix, int rowNumber)
        {
            if(matrix == null)
            {
                Error.Kill();
            }

            if(rowNumber >= matrix.GetLength(0))
            {
                Error.Kill();
            }

            int min = matrix[rowNumber, 0];
            int colNumber = 0;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if(min > matrix[rowNumber, j])
                {
                    min = matrix[rowNumber, j];
                    colNumber = j;
                }
            }

            return colNumber;
        }

        public static int FindMinOnRow(int[,] source, int rowNumber, bool absolute)
        {
            if (source == null)
            {
                Error.Kill();
            }

            if (rowNumber >= source.GetLength(0))
            {
                Error.Kill();
            }

            int min = Math.Abs(source[rowNumber, 0]);
            int colNumber = 0;
            for (int j = 0; j < source.GetLength(1); j++)
            {
                if (min > Math.Abs(source[rowNumber, j]))
                {
                    min = Math.Abs(source[rowNumber, j]);
                    colNumber = j;
                }
            }

            return colNumber;
        }
        #endregion

        #endregion

        #region Erase
        public static void EraseRow(ref int[,] source, int row)
        {
            if (source == null)
            {
                Error.Kill();
            }

            if(row < 0 || row >= source.GetLength(0))
            {
                Console.WriteLine("Nothing to erase");
                return;
            }

            int[,] dest = new int[source.GetLength(0) - 1, source.GetLength(1)];
            int externalRow = 0;
            for(int i = 0; i < dest.GetLength(0); i++)
            {
                if(externalRow == row)
                {
                    externalRow++;
                }

                for(int j = 0; j < dest.GetLength(1); j++)
                {
                    dest[i, j] = source[externalRow, j];
                }

                externalRow++;
            }

            source = dest;
        }

        public static void EraseCol(ref int[,] source, int col)
        {
            if(source == null)
            {
                Error.Kill();
            }

            if(col < 0 || col >= source.GetLength(1))
            {
                Console.WriteLine("Nothing to erase");
                return;
            }

            int[,] dest = new int[source.GetLength(0), source.GetLength(1) - 1];
            for(int i = 0; i < dest.GetLength(0); i++)
            {
                int externalCol = 0;
                for(int j = 0; j < dest.GetLength(1) && externalCol < source.GetLength(1); j++)
                {
                    if(externalCol == col)
                    {
                        externalCol++;
                    }

                    dest[i, j] = source[i, externalCol];
                    externalCol++;
                }
            }

            source = dest;
        }

        #endregion

        #region Move
        public static void MoveCols(ref int[,] source, int end)
        {
            if(source == null)
            {
                Error.Kill();
            }

            if(end < 0 || end > source.GetLength(1))
            {
                Error.Kill();
            }

            for (int j = source.GetLength(1) - 1; j >= end + 1; j--)
            {
                SetCol(source, GetCol(source, j - 1), j);
            }
        }
        #endregion
    }
}
