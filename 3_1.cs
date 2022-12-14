using System;


namespace _4th_defence
{
    class Program
    {
        static double[,] double_matrix(int rows, int columns, ref bool flag)
        {
            double[,] fin_matrix = new double[rows, columns];
            for (int j = 0; j < rows; j++)
            {
                Console.WriteLine($"enter row {j}:");
                string str_ = Console.ReadLine();
                double[] str_arr = new double[columns];
                string[] row = str_.Split(' ');
                for (int i = 0; i < columns; i++)
                {
                    if (!(row.Length == columns & double.TryParse(row[i], out str_arr[i])))
                    {
                        Console.WriteLine("input error");
                        flag = true;
                        double[,] mat = { };
                        return mat;
                    }
                    fin_matrix[j, i] = str_arr[i];
                }

            }
            return fin_matrix;
        }
        static void show_matrix(double[,] matrix, int rows, int columns, ref bool flag)
        {
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < columns; k++)
                {
                    Console.Write($"{matrix[i, k]} ");
                }
            }
        }

        static void swap(ref double[,] matrix, int x, int y, int cols)
        {
            double[] temp = new double[cols];
            for (int i=0; i<cols; i++)
            {
                temp[i] = matrix[x, i];
            }

            for (int i = 0; i < cols; i++)
            {
                matrix[x, i] = matrix[y, i];
            }

            for (int i = 0; i < cols; i++)
            {
                matrix[y, i] = temp[i];
            }
        }

        static double min(double[,] matrix, int row, int cols)
        {
            double min_val = Double.MaxValue;
            for (int i=0; i<cols; i++)
            {
                if (matrix[row, i] < min_val)
                {
                    min_val = matrix[row, i];
                }
            }
            return min_val;
        }
        static void bubble_sort(ref double[,] matrix, int cols, int rows, ref bool sorted)
        {
            while (!sorted)
            {
                bool temp_sorted = true;
                for (int i_row = 0; i_row < rows - 1; i_row++)
                {
                    if (min(matrix, i_row, cols) < min(matrix, i_row+1, cols))
                    {
                        temp_sorted = false;
                        swap(ref matrix, i_row, i_row + 1, cols);
                    }
                }
                sorted = temp_sorted;
            }
        }
        static void Main(string[] args)
        {
            bool flag = false;
            bool sorted = false;
            int cols = 3;
            int rows = 3;

            double[,] matrix = double_matrix(rows, cols, ref flag);
            show_matrix(matrix, rows, cols, ref flag);
            bubble_sort(ref matrix, cols, rows, ref sorted);
            show_matrix(matrix, rows, cols, ref flag);
        }
    }
}

