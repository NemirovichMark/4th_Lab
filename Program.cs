using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;

namespace _4th_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lvl_1
            
            #region Num_3
            {
                double sum = 0;
                double[,] matrix = new double[4, 4];
                Console.WriteLine("Write matrix (4x4): ");
                for (int i = 0; i < 4; ++i)
                {
                    for (int j = 0; j < 4; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                            if (i == j || i + j == 3)
                            {
                                sum += digit;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                Console.WriteLine($"sum_diagonals = {sum}");
            }
            #endregion
            
            #region Num_6
            {
                double[,] matrix = new double[4, 7];
                double[] arr = new double[4];
                Console.WriteLine("Write matrix (4x7): ");
                for (int i = 0; i < 4; ++i)
                {
                    for (int j = 0; j < 7; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j]= digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                double min_ = matrix[0, 0];
                int min_i = 0;
                for (int i = 0; i < 4; ++i)
                {
                    for (int j = 0; j < 7; ++j)
                    {
                        if (min_ > matrix[i, j])
                        {
                            min_ = matrix[i, j];
                            min_i = j;
                        }
                    }
                    arr[i] = min_i;
                }
                for (int p = 0; p < arr.Length; ++p)
                {
                    Console.WriteLine($"{arr[p]} ");
                }

            }
            #endregion
            
            #region Num_12
            {
                int n = 6, m = 7;
                double[,] matrix = new double[n, m];
                Console.WriteLine("Write matrix (6x7): ");
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                double max_ = matrix[0, 0];
                int str = 0, col = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (max_ < matrix[i, j])
                        {
                            max_ = matrix[i, j];
                            str = i;
                            col = j;
                        }   
                    }
                }
                n = n - 1;
                for (int i = str; i < n; ++i)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        matrix[i, j] = matrix[i + 1, j];
                    }
                }
                m = m - 1;
                for (int i = 0; i < n; ++i)
                {
                    for (int j = col; j < m; ++j)
                    {
                        matrix[i, j] = matrix[i, j + 1];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("{0,1} ",matrix[i, j]);
                    }
                    Console.WriteLine();
                }

            }
            #endregion
            
            #region Num_13
            {
                double[,] matrix = new double[5, 5];
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                double max_ = matrix[0, 0];
                int max_j = 0;
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        if (i == j && max_ < matrix[i, j])
                        {
                            max_ = matrix[i, j];
                            max_j = j;
                        }
                    }
                }
                for (int i = 0; i < 5; ++i)
                {
                    (matrix[i, max_j], matrix[i, 3]) = (matrix[i, 3], matrix[i, max_j]);
                }
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            
            #region Num_17
            {
                double p = 0;
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                }
                else
                {
                    Console.WriteLine("Error");
                }
                if (int.TryParse(Console.ReadLine(), out int m))
                {
                }
                else
                {
                    Console.WriteLine("Error");
                }
                double[,] matrix = new double[n, m];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                for (int i = 0; i < n; ++i)
                {
                    double min_ = matrix[i, 0];
                    int min_i = 0;
                    for (int j = 0; j < m; ++j)
                    {
                        if (min_ > matrix[i, j])
                        {
                            min_ = matrix[i, j];
                            min_i = j;
                        }
                    }
                    for (int j = min_i; j > 0; --j)
                    {
                        p = matrix[i, j - 1]; matrix[i, j - 1] = matrix[i, j]; matrix[i, j] = p;
                    }
                }
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }

            }
            #endregion
            
            #region Num_29
            {
                double[,] matrix = new double[5, 7];
                int i_min = 0;
                double min_ = 0;
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 7; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                            if (i == 1)
                            {
                                if (j == 0)
                                {
                                    min_ = Math.Abs(digit);
                                }
                                if (min_ > Math.Abs(digit))
                                {
                                    min_ = Math.Abs(digit);
                                    i_min = j;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                if (i_min != 6)
                {
                    ++i_min;
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = i_min; j < 6; j++)
                        {
                            matrix[i, j] = matrix[i, j + 1];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Complete");
                }
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 6; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion

            #region Num_31
            {
                double[,] matrix = new double[5, 7];
                double min_ = 0;
                int i_min = 0;
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 7; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                            if (i == 4)
                            {
                                if (j == 0)
                                {
                                    min_ = digit;
                                }
                                if (min_ > digit)
                                {
                                    min_ = digit;
                                    i_min = j;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                double[] arr = new double[5];
                for (int i = 0; i < 5; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double x))
                    {
                        arr[i] = x;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                double[,] matrix2 = new double[5, 8];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < i_min + 1; ++j)
                    {
                        matrix2[i, j] = matrix[i, j];
                    }
                    matrix2[i, i_min + 1] = arr[i];
                    for (int j = i_min + 2; j < 8; j++)
                    {
                        matrix2[i, j] = matrix[i, j - 1];
                    }
                }
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 8; ++j)
                    {
                        Console.Write("{0,1} ", matrix2[i, j]);
                    }
                    Console.WriteLine();
                }
            }
                #endregion
                #endregion
            
            #region Lvl_2

            #region Num_7
            {
                double[,] matrix = new double[6, 6];
                double min_ = 0;
                int min_i = 0;
                for (int i = 0; i < 6; ++i)
                {
                    for (int j = 0; j < 6; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                            if (i == 0 && j == 0)
                            {
                                min_ = matrix[0, 0];
                            }
                            if (i == j && min_ < matrix[i, j])
                            {
                                min_ = matrix[i, j];
                                min_i = i;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                for (int i = 0; i < min_i; ++i)
                {
                    for (int j = i + 1; j < 6; ++j)
                    {
                        matrix[i, j] = 0; 
                    }
                }
                for (int i = 0; i < 6; ++i)
                {
                    for (int j = 0; j < 6; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            
            #region Num_8
            {
                double[,] matrix = new double[6, 6];
                double max_1 = 0;
                double max_2 = 0;
                int max_i_1 = 0;
                int max_i_2 = 0;
                for (int i = 0; i < 6; ++i)
                {
                    for (int j = 0; j < 6; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                for (int i = 0; i < 6; i += 2)
                {
                    max_1 = matrix[i, 0];
                    max_2 = matrix[i + 1, 0];
                    for (int j = 0; j < 6; ++j)
                    {
                        if (max_1 < matrix[i, j])
                        {
                            max_1 = matrix[i, j];
                            max_i_1 = j;
                        }
                        if (max_2 < matrix[i + 1, j])
                        {
                            max_2 = matrix[i + 1, j];
                            max_i_2 = j;
                        }
                    }
                    matrix[i, max_i_1] = max_2;
                    matrix[i + 1, max_i_2] = max_1;
                }
                for (int i = 0; i < 6; ++i)
                {
                    for (int j = 0; j < 6; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            
            #region Num_9
            {
                double[,] matrix = new double[6, 7];
                for (int i = 0; i < 6; ++i)
                {
                    for (int j = 0; j < 7; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                double symp = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        symp = matrix[i, j];
                        matrix[i, j] = matrix[i, 6 - j];
                        matrix[i, 6 - j] = symp;
                    }
                }
                for (int i = 0; i < 6; ++i)
                {
                    for (int j = 0; j < 7; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion

            #endregion
            
            #region Lvl_3
            
            #region Num_1
            {
                #region Num_1
            {
                int n = 7;
                int g = 5;
                double[,] matrix = new double[n, g];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < g; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                double[] arr = new double[n];
                double min_ = 0;
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < g; ++j)
                    {
                        if (j == 0)
                        {
                            min_ = matrix[i, 0];
                        }
                        if (matrix[i, j] <= min_)
                        {
                            min_ = matrix[i, j];
                            arr[i] = min_;
                        }
                    }
                }
                int aux = 0;
                while (aux < arr.Length - 1)
                {
                    if (arr[aux] < arr[aux + 1])
                    {
                        double empty = arr[aux];
                        arr[aux] = arr[aux + 1];
                        arr[aux + 1] = empty;
                        for (int i = 0; i < g; i++)
                        {
                            double free = matrix[aux, i];
                            matrix[aux, i] = matrix[aux + 1, i];
                            matrix[aux + 1, i] = free;
                        }
                        if (aux > 0)
                        {
                            --aux;
                        }
                    }
                    else
                    {
                        ++aux;
                    }

                }
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < g; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < arr.Length; ++i)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            #endregion
            
            #region Num_2
            {
                int n = 0;
                if (Int32.TryParse(Console.ReadLine(), out Int32 x))
                {
                    n = x;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                double[,] matrix = new double[n, n];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                for (int i = 0; i < x; i++)
                {
                    matrix[i, 0] = 0;
                    matrix[0, i] = 0;
                    matrix[n - 1, i] = 0;
                    matrix[i, n - 1] = 0;
                }
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            
            #region Num_3
            {
                int arr_i = 0;
                int n = 0;
                if ((Int32.TryParse(Console.ReadLine(), out Int32 x)) && (x > 0))
                {
                    n = x;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                double[,] matrix = new double[n, n];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                double[] arr = new double[2 * n - 1];
                for (int i = n - 1; i > 0; --i)
                {
                    double sum = 0;
                    for (int j = 0; j + i < n; ++j)
                    {
                        sum += matrix[i + j, j];
                    }
                    arr[arr_i] = sum;
                    ++arr_i; 
                }
                for (int i = n - 1; i >= 0; --i)
                {
                    double sum = 0;
                    for (int j = 0; j + i < n; ++j)
                    {
                        sum += matrix[j, i + j];
                    }
                    arr[arr_i] = sum;
                    ++arr_i;
                }
                for (int i = 0; i < arr.Length; ++i)
                {
                    Console.WriteLine(arr[i]);
                }

            }
            #endregion
            
            #region Num_4
            {
                int n = 0;
                if ((Int32.TryParse(Console.ReadLine(), out Int32 x)) && (x > 0))
                {
                    n = x;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                double[,] matrix = new double[n, n];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                for (int i = n / 2; i != n; ++i)
                {
                    for (int j = 0; j != n; ++j)
                    {
                        if (i == j || i > j)
                        {
                            matrix[i, j] = 1;
                        }
                    }
                }
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            
            
            #region Num_8
            {
                int n = 7;
                int g = 5;
                double[,] matrix = new double[n, g];
                double[] arr = new double[n];
                int p = 0;
                for (int i = 0; i < n; ++i)
                {
                    p = 0;
                    for (int j = 0; j < g; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                            if (digit > 0)
                            {
                                ++p;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    arr[i] = p;
                }
                int aux = 0;
                while (aux < arr.Length - 1)
                {
                    if (arr[aux] < arr[aux + 1])
                    {
                        double empty = arr[aux];
                        arr[aux] = arr[aux + 1];
                        arr[aux + 1] = empty;
                        for (int i = 0; i < g; i++)
                        {
                            double free = matrix[aux, i];
                            matrix[aux, i] = matrix[aux + 1, i];
                            matrix[aux + 1, i] = free;
                        }
                        if (aux > 0)
                        {
                            --aux;
                        }
                    }
                    else
                    {
                        ++aux;
                    }

                }
                for (int i = 0; i < 7; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            
            #region Num_10
            {
                int n = 0;
                if ((Int32.TryParse(Console.ReadLine(), out Int32 x)) && (x > 0))
                {
                    n = x;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                int g = 0;
                if ((Int32.TryParse(Console.ReadLine(), out Int32 y)) && (y > 0))
                {
                    g = y;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                double[,] matrix = new double[n, g];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < g; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                for (int i = 0; i < n; ++i)
                {
                    int aux = 0;
                    if (i % 2 != 0)
                    {
                        while (aux < g)
                        {
                            if (aux == 0 || matrix[i, aux - 1] <= matrix[i, aux])
                            {
                                ++aux;
                            }
                            else
                            {
                                double empty = matrix[i, aux];
                                matrix[i, aux] = matrix[i, aux - 1];
                                matrix[i, aux - 1] = empty;
                                --aux;
                            }
                        }
                    }
                    else
                    {
                        while (aux < g)
                        {
                            if (aux == 0 || matrix[i, aux - 1] >= matrix[i, aux])
                            {
                                ++aux;
                            }
                            else
                            {
                                double temp = matrix[i, aux];
                                matrix[i, aux] = matrix[i, aux - 1];
                                matrix[i, aux - 1] = temp;
                                --aux;
                            }
                        }
                    }
                }
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < g; ++j)
                    {
                        Console.Write("{0,1} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            
            #region Num_11
            {
                int n = 0;
                if ((Int32.TryParse(Console.ReadLine(), out Int32 x)) && (x > 0))
                {
                    n = x;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                int g = 0;
                if ((Int32.TryParse(Console.ReadLine(), out Int32 y)) && (y > 0))
                {
                    g = y;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                double[,] matrix = new double[n, g];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < g; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            matrix[i, j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
                bool[] arr = new bool[n];
                int k = 0;
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < g; ++j)
                    {
                        if (matrix[i, j] == 0)
                        {
                            arr[i] = true;
                            ++k;
                            break;
                        }
                    }
                }
                double[,] matrix2 = new double[n - k, g];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < g; ++j)
                    {
                        if (arr[i] == false)
                        {
                            matrix2[i, j] = matrix[i, j];
                        }
                    }
                }
                for (int i = 0; i < n - k; ++i)
                {
                    for (int j = 0; j < g; ++j)
                    {
                        Console.Write("{0,1} ", matrix2[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion

            #endregion
        }
    }
}
