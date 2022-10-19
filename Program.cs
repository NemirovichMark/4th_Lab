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
                    for (int j = 0; j < m; j++)
                    {
                        if (k == j)
                        {
                            if (matrix_in_use[k, j] > biggest_value)
                            {
                                biggest_value = matrix_in_use[k, j];
                                row = k;
                                column = j;
                            }
                        }
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
                    for (int i = column; i >0; i--)
                    {
                        matrix_in_use[k,i] = matrix_in_use[k, i-1];
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
                m -= 1;
                for (int i = column+1; i < m; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matrix_in_use[k, i] = matrix_in_use[k, i + 1];
                    }
                }
                show_matrix(matrix_in_use, n, m, ref flag);

            }
            static void task_1_31()
            {
                bool flag = false;
                int n = 5;
                int m = 8;
                Console.WriteLine("enter b(5):");
                string str_ =Console.ReadLine();
                double[] arr_in_use = double_array(str_, 5, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }//i use for 8th elem in row elem that is already in this row, but this elem is not the smallest(it is important for the 5th row)
                double[,] matrix_in_use = { { 1, 2, 3, 4, 5, 6, 7,7 }, { 1, 2, 3, 4, 5, 6, 7,7 }, { 1, 2, 3, 4, 5, 6, 7,7 }, { 1, 2, 3, 4, 5, 6, 7,7 }, { 1, 2, 3, 0, 5, 6, 7,7 } };
                show_matrix(matrix_in_use, n, m-1, ref flag);
                double smallest_value = matrix_in_use[4, 0];
                int row = 0;
                int column = 0;
                for (int k = 1; k < m-1; k++)
                {
                    if (matrix_in_use[4, k] < smallest_value)
                    {
                        smallest_value = matrix_in_use[4, k];
                        column = k;
                    }
                }
                for (int i = m-2; i >column; i--)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matrix_in_use[k, i+1] = matrix_in_use[k, i];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    matrix_in_use[i, column + 1] = arr_in_use[i];
                }
                show_matrix(matrix_in_use, n, m, ref flag);

            }
            

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
                    for (int i = 0; i < m/2; i++)
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
                    for (int j = 0; j < m; j++)
                    {
                        if (k == j)
                        {
                            if (matrix_in_use[k, j] > biggest_value)
                            {
                                biggest_value = matrix_in_use[k, j];
                                row = k;
                            }
                        }
                    }
                }
                for (int k = 0; k < n; k++)
                {
                    if (k == row) break;
                    for (int j = 0; j < m; j++)
                    {
                        if (k == j)
                        {
                            for (int i = 0; i < m-j-1; i++)
                            {
                                matrix_in_use[k, j + 1+i] = 0;
                            }
                        }
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

                
                double smallest11 = 0;
                int smallest_row11 = 0;

                for (int t = 0; t < n; t++)
                {
                    double smallest1 = matrix_in_use[t, 0];
                    double smallest_row1 = t;
                    for (int k = 0; k < m; k++)
                    {
                        if (matrix_in_use[t,k] < smallest1)
                        {
                            smallest1 = matrix_in_use[t, k];
                        }
                        
                    }
                    smallest11 = smallest1;
                    smallest_row11 = t;
                    for (int i = 1; i < n; i++)
                    {
                        double smallest2 = matrix_in_use[i, 0];
                        int smallest_row2 = i;
                        for (int k = 0; k < m; k++)
                        {
                            if (matrix_in_use[i, k] < smallest2)
                            {
                                smallest2 = matrix_in_use[i, k];
                            }

                        }
                        if (smallest2 > smallest11 & smallest_row2 > smallest_row11)
                        {
                            double[] p = new double[m];
                            for (int j = 0; j < m; j++)
                            {
                                p[j] = matrix_in_use[smallest_row11, j];

                            }
                            for (int h = 0; h < m; h++)
                            {
                                matrix_in_use[smallest_row11, h] = matrix_in_use[smallest_row2, h];
                            }
                            for (int f = 0; f < m; f++)
                            {
                                matrix_in_use[smallest_row2, f] = p[f];
                            }
                        }
                    }
                }
                
                show_matrix(matrix_in_use, n, m, ref flag);



            }
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
                        if(i==0 || i == n - 1)
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
                if (!(res & n > 0 )) return;
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
                            vector[n-1 + Math.Abs(k - i)] += matrix_in_use[i, k];
                            continue;
                        }
                        vector[k - i] += matrix_in_use[i, k];
                    }
                }
                foreach(double elem in vector)
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
                int i=1;
                int x = n / 2;
                for (int k = 0; k < n; k++)
                {
                    if (k == x||k>x)
                    {
                        for (int j = 0; j < n/2+i ; j++)
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


                for (int t = 0; t < n; t++)
                {
                    int quality1 = 0;
                    int row_1 = t;
                    for (int k = 0; k < m; k++)
                    {
                        if (matrix_in_use[t, k] >0)
                        {
                            quality1++;
                        }

                    }
                    for (int i = 1; i < n; i++)
                    {
                        int quality2 = 0;
                        int row_2 = i;
                        for (int k = 0; k < m; k++)
                        {
                            if (matrix_in_use[i, k] >0)
                            {
                                quality2++;
                            }

                        }
                        if (quality2 > quality1 & row_2 > row_1)
                        {
                            double[] p = new double[m];
                            for (int j = 0; j < m; j++)
                            {
                                p[j] = matrix_in_use[row_1, j];

                            }
                            for (int h = 0; h < m; h++)
                            {
                                matrix_in_use[row_1, h] = matrix_in_use[row_2, h];
                            }
                            for (int f = 0; f < m; f++)
                            {
                                matrix_in_use[row_2, f] = p[f];
                            }
                        }
                    }
                }

                show_matrix(matrix_in_use, n, m, ref flag);



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
                            row_array[j]=matrix_in_use[i, j];                          
                        }
                        Array.Sort(row_array);
                        Array.Reverse(row_array);
                        for (int j = 0; j < m; j++)
                        {
                            matrix_in_use[i, j]= row_array[j];
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
                for (int k = 0; k < n; k++)
                {
                    for (int i = 0; i < m; i++)
                    {
                        if (matrix_in_use[k, i] == 0)
                        {
                            n -= 1;
                            for (int j = k; j < n; j++)
                            {
                                for (int h = 0; h < m; h++)
                                {
                                    matrix_in_use[j, h] = matrix_in_use[j + 1, h];
                                }

                            }
                            k = -1;
                            break;
                        }
                    }
                }
                show_matrix(matrix_in_use, n, m, ref flag);



            }
            }
       }
}
