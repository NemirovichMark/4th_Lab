using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace _4th_Lab
{
    class Program
    {
        static void Main(string[] args)
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
            static double[] double_array(string str_, int size, ref bool flag)
            {

                double[] fin_arr = new double[size];
                string[] array_1 = str_.Split(' ');
                for (int i = 0; i < size; i++)
                {
                    if (!(array_1.Length == size & double.TryParse(array_1[i], out fin_arr[i])))
                    {
                        Console.WriteLine("input error");
                        flag = true;
                        double[] arr = { };
                        return arr;
                    }
                }
                return fin_arr;
            }
            


            static void task_1_3()
            {
                bool flag = false;
                int n = 4;
                int m = 4;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);
                double s = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (i == j)
                        {
                            s += matrix_in_use[i, j];
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"result:{s}");
            }
            static void task_1_6()
            {
                bool flag = false;
                int n = 4;
                int m = 7;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);
                double[] res_ar = new double[n];
                double smallest_value = matrix_in_use[0, 0];
                for (int k = 0; k < n; k++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix_in_use[k, j] < smallest_value)
                        {
                            smallest_value = matrix_in_use[k, j];
                        }
                    }
                    res_ar[k] = smallest_value;
                    if (k == n - 1) break;
                    smallest_value = matrix_in_use[k + 1, 0];
                }
                Console.WriteLine();
                Console.WriteLine($"result:");
                foreach (double elem in res_ar)
                {
                    Console.Write($"{elem}\t");
                }
            }
            static void task_1_12()
            {
                bool flag = false;
                int n;
                int m;
                Console.WriteLine("enter rows:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("enter columns:");
                bool res2 = int.TryParse(Console.ReadLine(), out m);
                if (!(res & n > 0 & res2 & m > 0)) return;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);

                double biggest_value = matrix_in_use[0, 0];
                int row = 0;
                int column = 0;
                for (int k = 0; k < n; k++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix_in_use[k, j] > biggest_value)
                        {
                            biggest_value = matrix_in_use[k, j];
                            row = k;
                            column = j;
                        }
                    }
                }
                n -= 1;
                for (int i = row; i < n; i++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        matrix_in_use[i, k] = matrix_in_use[i + 1, k];
                    }
                }
                m -= 1;
                for (int i = column; i < m; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matrix_in_use[k, i] = matrix_in_use[k, i + 1];
                    }
                }
                show_matrix(matrix_in_use, n, m, ref flag);


            }
            static void task_1_13()
            {
                bool flag = false;
                int n = 5;
                int m = 5;
                double p = 0;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);

                double biggest_value = matrix_in_use[0, 0];
                int row = 0;
                int column = 0;
                for (int k = 0; k < n; k++)
                {
                    if (matrix_in_use[k, k] > biggest_value)
                    {
                        biggest_value = matrix_in_use[k, k];
                        row = k;
                        column = k;
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    p = matrix_in_use[i, 3];
                    matrix_in_use[i, 3] = matrix_in_use[i, column];
                    matrix_in_use[i, column] = p;
                }
                show_matrix(matrix_in_use, n, m, ref flag);

            }
            static void task_1_17()
            {
                bool flag = false;
                int n;
                int m;
                int column = 0;
                Console.WriteLine("enter rows:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("enter columns:");
                bool res2 = int.TryParse(Console.ReadLine(), out m);
                if (!(res & n > 0 & res2 & m > 0)) return;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);
                double smallest_value = matrix_in_use[0, 0];
                for (int k = 0; k < n; k++)
                {
                    smallest_value = matrix_in_use[k, 0];
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix_in_use[k, j] < smallest_value)
                        {
                            smallest_value = matrix_in_use[k, j];
                            column = j;
                        }
                    }
                    for (int i = column; i > 0; i--)
                    {
                        matrix_in_use[k, i] = matrix_in_use[k, i - 1];
                    }
                    matrix_in_use[k, 0] = smallest_value;
                }
                show_matrix(matrix_in_use, n, m, ref flag);
            }
            static void task_1_29()
            {
                bool flag = false;
                int n = 5;
                int m = 7;
                double p = 0;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);

                double smallest_value = Math.Abs(matrix_in_use[1, 0]);
                int row = 0;
                int column = 0;
                for (int k = 1; k < m; k++)
                {
                    if (Math.Abs(matrix_in_use[1, k]) < Math.Abs(smallest_value))
                    {
                        smallest_value = matrix_in_use[1, k];
                        column = k;
                    }
                }
                if (column != m - 1)
                {


                    m -= 1;
                    for (int i = column + 1; i < m; i++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            matrix_in_use[k, i] = matrix_in_use[k, i + 1];
                        }
                    }
                    show_matrix(matrix_in_use, n, m, ref flag);
                    
                }
                else
                {

                    show_matrix(matrix_in_use, n, m, ref flag);
                }

            }//fixed3
            static void task_1_31()
            {
                bool flag = false;
                int n = 5;
                int m = 8;
                Console.WriteLine("enter b(5):");
                string str_ = Console.ReadLine();
                double[] arr_in_use = double_array(str_, 5, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }//i use for 8th elem in row elem that is already in this row, but this elem is not the smallest(it is important for the 5th row)
                double[,] matrix_in_use = { { 1, 2, 3, 4, 5, 6, 7, 7 }, { 1, 2, 3, 4, 5, 6, 7, 7 }, { 1, 2, 3, 4, 5, 6, 7, 7 }, { 1, 2, 3, 4, 5, 6, 7, 7 }, { 1, 2, 3, 0, 5, 6, 7, 7 } };
                show_matrix(matrix_in_use, n, m - 1, ref flag);
                double smallest_value = matrix_in_use[4, 0];
                int row = 0;
                int column = 0;
                for (int k = 1; k < m - 1; k++)
                {
                    if (matrix_in_use[4, k] < smallest_value)
                    {
                        smallest_value = matrix_in_use[4, k];
                        column = k;
                    }
                }
                for (int i = m - 2; i > column; i--)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matrix_in_use[k, i + 1] = matrix_in_use[k, i];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    matrix_in_use[i, column + 1] = arr_in_use[i];
                }
                show_matrix(matrix_in_use, n, m, ref flag);

            }
            task_3_11();

            static void task_2_8()
            {
                bool flag = false;
                int n = 6;
                int m = 6;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);
                double[] biggest_values_array = new double[n];
                int prev_index_column = 0;
                for (int k = 0; k < n; k++)
                {
                    double biggest_value = matrix_in_use[k, 0];
                    int index_column = 0;
                    if (k % 2 == 0) prev_index_column = 0;
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix_in_use[k, j] > biggest_value)
                        {
                            biggest_value = matrix_in_use[k, j];
                            index_column = j;
                            if (k % 2 == 0)
                            {
                                prev_index_column = index_column;
                            }
                        }
                    }
                    biggest_values_array[k] = biggest_value;

                    if (k % 2 == 1)
                    {
                        double p = biggest_values_array[k];
                        matrix_in_use[k, index_column] = matrix_in_use[k - 1, prev_index_column];
                        matrix_in_use[k - 1, prev_index_column] = p;
                    }


                }
                show_matrix(matrix_in_use, n, m, ref flag);
            }
            static void task_2_9()
            {
                bool flag = false;
                int n = 6;
                int m = 7;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);
                for (int k = 0; k < n; k++)
                {
                    for (int i = 0; i < m / 2; i++)
                    {
                        double p = matrix_in_use[k, i];
                        matrix_in_use[k, i] = matrix_in_use[k, m - 1 - i];
                        matrix_in_use[k, m - 1 - i] = p;
                    }
                }

                show_matrix(matrix_in_use, n, m, ref flag);

            }
            static void task_2_7()
            {
                bool flag = false;
                int n = 6;
                int m = 6;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);

                double biggest_value = matrix_in_use[0, 0];
                int row = 0;
                for (int k = 0; k < n; k++)
                {
                    if (matrix_in_use[k, k] > biggest_value)
                    {
                        biggest_value = matrix_in_use[k, k];
                        row = k;
                    }
                }
                for (int k = 0; k < n; k++)
                {
                    if (k == row) break;

                    for (int i = 0; i < m - k - 1; i++)
                    {
                        matrix_in_use[k, k + 1 + i] = 0;
                    }


                }
                show_matrix(matrix_in_use, n, m, ref flag);

            } 

            static void task_3_1()
            {
                bool flag = false;
                int n = 7;
                int m = 5;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);
                Console.WriteLine();
                double[,] mat_in_use2 = new double[n,2];
                for (int k = 0; k < n; k++)
                {
                    double smallest_value = matrix_in_use[k,0];
                    for (int i = 1; i < m; i++)
                    {
                        if (matrix_in_use[k,i] < smallest_value)
                        {
                            smallest_value = matrix_in_use[k, i];
                        }
                    }

                    mat_in_use2[k,0] =k ;
                    mat_in_use2[k,1] =smallest_value;

                }
                foreach (double elem in mat_in_use2) Console.Write($"{elem}   ");
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    double big = mat_in_use2[i, 1];
                    int row = i;
                    for (int k = 1+i; k < n; k++)
                    {
                        if (mat_in_use2[k, 1] > big)
                        {
                            big = mat_in_use2[k, 1];
                            row = k;
                        }

                    }

                    double help1 = mat_in_use2[i, 0];
                    mat_in_use2[i, 0] = row;
                    mat_in_use2[row, 0] = help1;
                    double help2 = mat_in_use2[i, 1];
                    mat_in_use2[i, 1] = big;
                    mat_in_use2[row, 1] = help2;
                }
                double[,] res_mat = new double[n, m];
                for (int i = 0; i < n; i++)
                {
                    int row = (int)mat_in_use2[i, 0];
                    for (int k = 0; k < m; k++)
                    {
                        
                        res_mat[i,k] =matrix_in_use[row,k];
                    }
                }


                foreach (double elem in mat_in_use2) Console.Write($"{elem}   ");

                show_matrix(res_mat, n, m, ref flag);



            }//it works on my pc
            static void task_3_2()
            {
                bool flag = false;
                int n;
                int m;
                Console.WriteLine("enter rows:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("enter columns:");
                bool res2 = int.TryParse(Console.ReadLine(), out m);
                if (!(res & n > 0 & res2 & m > 0)) return;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);

                for (int i = 0; i < n; i++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        if (i == 0 || i == n - 1)
                        {
                            matrix_in_use[i, k] = 0;
                            continue;
                        }
                        matrix_in_use[i, 0] = 0;
                        matrix_in_use[i, m - 1] = 0;
                        break;
                    }
                }
                show_matrix(matrix_in_use, n, m, ref flag);
            }
            static void task_3_3()
            {
                bool flag = false;
                int n;
                // dificult but it is true just math
                Console.WriteLine("enter rows:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                double[] vector = new double[2 * n - 1];
                int j = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (k - i < 0)
                        {
                            vector[n - 1 + Math.Abs(k - i)] += matrix_in_use[i, k];
                            continue;
                        }
                        vector[k - i] += matrix_in_use[i, k];
                    }
                }
                foreach (double elem in vector)
                {
                    Console.WriteLine($"{elem}\t");
                }

            }
            static void task_3_4()
            {
                bool flag = false;
                int n;
                int m;
                Console.WriteLine("enter rows:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("enter columns:");
                bool res2 = int.TryParse(Console.ReadLine(), out m);
                if (!(res & n > 0 & res2 & m > 0)) return;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                int i = 1;
                int x = n / 2;
                for (int k = 0; k < n; k++)
                {
                    if (k == x || k > x)
                    {
                        for (int j = 0; j < n / 2 + i; j++)
                        {

                            matrix_in_use[k, j] = 1;

                        }
                        i++;
                    }

                }
                show_matrix(matrix_in_use, n, m, ref flag);
            }



            static void task_3_8()
            {
                bool flag = false;
                int n = 3;
                int m = 4;
                Console.WriteLine("enter array data:");
                double[,] matrix_in_use = double_matrix(n, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                show_matrix(matrix_in_use, n, m, ref flag);
                Console.WriteLine();
                double[,] mat_in_use2 = new double[n, 2];
                int quality = 0;
                for (int k = 0; k < n; k++)
                {
                    
                    for (int i = 0; i < m; i++)
                    {
                        if (matrix_in_use[k, i] >0)
                        {
                            quality++;
                        }
                    }

                    mat_in_use2[k, 0] = k;
                    mat_in_use2[k, 1] = quality;
                    quality = 0;

                }
                foreach (double elem in mat_in_use2) Console.Write($"{elem}   ");
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    double big = mat_in_use2[i, 1];
                    int row = i;
                    for (int k = 1 + i; k < n; k++)
                    {
                        if (mat_in_use2[k, 1] > big)
                        {
                            big = mat_in_use2[k, 1];
                            row = k;
                        }

                    }

                    double help1 = mat_in_use2[i, 0];
                    mat_in_use2[i, 0] = row;
                    mat_in_use2[row, 0] = help1;
                    double help2 = mat_in_use2[i, 1];
                    mat_in_use2[i, 1] = big;
                    mat_in_use2[row, 1] = help2;
                }
                double[,] res_mat = new double[n, m];
                for (int i = 0; i < n; i++)
                {
                    int row = (int)mat_in_use2[i, 0];
                    for (int k = 0; k < m; k++)
                    {

                        res_mat[i, k] = matrix_in_use[row, k];
                    }
                }


                foreach (double elem in mat_in_use2) Console.Write($"{elem}   ");




                show_matrix(res_mat, n, m, ref flag);
            }

            static void task_3_10()
                {
                    bool flag = false;
                    int n;
                    int m;
                    Console.WriteLine("enter rows:");
                    bool res = int.TryParse(Console.ReadLine(), out n);
                    Console.WriteLine("enter columns:");
                    bool res2 = int.TryParse(Console.ReadLine(), out m);
                    if (!(res & n > 0 & res2 & m > 0)) return;
                    Console.WriteLine("enter array data:");
                    double[,] matrix_in_use = double_matrix(n, m, ref flag);
                    if (flag)
                    {
                        Console.WriteLine("input error");
                        return;
                    }
                    show_matrix(matrix_in_use, n, m, ref flag);

                    for (int i = 0; i < n; i++)
                    {
                        double[] row_array = new double[m];
                        if (i % 2 == 0)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                row_array[j] = matrix_in_use[i, j];
                            }
                            Array.Sort(row_array);
                            Array.Reverse(row_array);
                            for (int j = 0; j < m; j++)
                            {
                                matrix_in_use[i, j] = row_array[j];
                            }
                        }
                        if (i % 2 != 0)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                row_array[j] = matrix_in_use[i, j];
                            }
                            Array.Sort(row_array);
                            for (int j = 0; j < m; j++)
                            {
                                matrix_in_use[i, j] = row_array[j];
                            }
                        }
                    }
                    show_matrix(matrix_in_use, n, m, ref flag);
                }
            static void task_3_11()
                {
                    bool flag = false;
                    int n;
                    int m;
                    Console.WriteLine("enter rows:");
                    bool res = int.TryParse(Console.ReadLine(), out n);
                    Console.WriteLine("enter columns:");
                    bool res2 = int.TryParse(Console.ReadLine(), out m);
                    if (!(res & n > 0 & res2 & m > 0)) return;
                    Console.WriteLine("enter array data:");
                    double[,] matrix_in_use = double_matrix(n, m, ref flag);
                    if (flag)
                    {
                        Console.WriteLine("input error");
                        return;
                    }
                    Console.WriteLine("you entered:");
                    show_matrix(matrix_in_use, n, m, ref flag);
                    int q = 0;
                    for (int k = 0; k < n; k++)
                    {
                        for (int i = 0; i < m; i++)
                        {
                            if (matrix_in_use[k, i] == 0)
                            {
                            q++;
                            }
                        }
                    }
                if (q <n)
                {
                    double[,] res_mat = new double[n-q, m];
                    bool res1 = true;
                    int j = 0;
                    for (int k = 0; k < n; k++)
                    {
                        for (int i = 0; i < m; i++)
                        {
                            if (matrix_in_use[k, i] == 0)
                            {
                                res1 = false;
                            }
                        }
                        if (res1)
                        {

                            for (int i = 0; i < m; i++)
                            {
                                res_mat[j, i] = matrix_in_use[k, i];
                            }
                            j++;
                        }
                        res1 = true;
                    }

                    show_matrix(res_mat, n-q, m, ref flag);
                }
                }//fixed3

                
            
        }
    }
}
