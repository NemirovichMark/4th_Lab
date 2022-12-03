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
        public static void Print(int[,] matrix)
        {
            if(matrix == null)
            {
                Error.Kill();
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 6}");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Set
        public static int SetRow()
        {
            int n = 0;
            while (n < 0)
            {
                Console.Write("input row: ");
                int.TryParse(Console.ReadLine(), out n);
            }
            return n;
        }

        public static int SetCol()
        {
            int n = 0;
            while (n < 0)
            {
                Console.Write("input col: ");
                int.TryParse(Console.ReadLine(), out n);
            }
            return n;
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
        static int[] FindMax(int[,] matrix)
        {
            if(matrix == null)
            {
                Error.Kill();
            }

            int max = matrix[0, 0];
            int[] index = { 0, 0 };
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }

            return index;
        }
        #endregion

        #region Erase
        public static void EraseRow(ref int[,] source, int row)
        {
            if (source == null)
            {
                Error.Kill();
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

        #endregion
    }
}
