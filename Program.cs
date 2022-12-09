using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            #region I|3
            Console.WriteLine("I|3");

            const int n = 4;
            double answ = 0;
            double[,] matrix = new double[n, n] { {4, 5, 6, 7 },
                                                  {1, 7, 2, 0 },
                                                  {9, 4, 3, 6 },
                                                  {2, 4, 7, 1 } };

            for (int i = 0; i < n; i++) answ += matrix[i, i] + matrix[i, n-i-1];

            Console.WriteLine(answ);

            Console.WriteLine("-----------------------");
            #endregion

            #region I|6
            Console.WriteLine("I|6");

            matrix = new double[4, 7] { {4, 5, 6, 7, 5, 6, 7 },
                                        {1, 7, 2, 0, 7, 2, 0 },
                                        {9, 4, 3, 6, 4, 3, 6 },
                                        {2, 4, 7, 1, 4, 7, 1 } };
            int row = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / row;
            double min;
            int min_ind1, min_ind2;
            double[] array = new double[row];

            for (int i = 0; i < row; i++)
            {
                min = matrix[i, 0];
                min_ind1 = i;
                min_ind2 = 0;
                for (int j = 0; j < col; j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        min_ind1 = i;
                        min_ind2 = j;
                    }
                }
                array[i] = min_ind2;
            }    


            foreach(double i in array) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("-----------------------");
            #endregion

            #region I|12
            Console.WriteLine("I|12");

            matrix = new double[6, 7] { {4, 5, 6, 7, 5, 6, 7 },
                                        {1, 7, 2, 0, 7, 2, 0 },
                                        {9, 4, 3, 6, 4, 3, 6 },
                                        {2, 4, 7, 1, 4, 7, 1 },
                                        {7, 1, 3, 9, 2, 1, 5 },
                                        {9, 4, 2, 7, 6, 2, 2 } };
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            double[,] matrix_answ = new double[row - 1, col - 1];
            double max = matrix[0, 0];
            int max_ind1 = 0, max_ind2 = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        max_ind1 = i;
                        max_ind2 = j;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                if (i < max_ind1) for (int j = 0; j < col; j++)
                {
                    if (j < max_ind2) matrix_answ[i, j] = matrix[i, j];
                    else if (j > max_ind2) matrix_answ[i, j - 1] = matrix[i, j];
                    }
                else if (i > max_ind1) for (int j = 0; j < col; j++)
                {
                    if (j < max_ind2) matrix_answ[i - 1, j] = matrix[i, j];
                    else if (j > max_ind2) matrix_answ[i - 1, j - 1] = matrix[i, j];
                }
            }

            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++) Console.Write("{0,3} ", matrix_answ[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region I|13
            Console.WriteLine("I|13");

            matrix = new double[5, 5] { {4, 5, 6, 7, 5 },
                                        {1, 7, 2, 0, 7 },
                                        {9, 4, 3, 6, 4 },
                                        {2, 4, 7, 1, 4 },
                                        {7, 1, 3, 9, 2 } };
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            max = matrix[0, 0];
            max_ind1 = 0;
            max_ind2 = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        max_ind1 = i;
                        max_ind2 = j;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                answ = matrix[i, 3];
                matrix[i, 3] = matrix[i, max_ind2];
                matrix[i, max_ind2] = answ;
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region I|17
            Console.WriteLine("I|17");

            const int m = 5;
            matrix = new double[n, m] { {4, 5, 6, 7, 5 },
                                        {1, 7, 2, 0, 7 },
                                        {9, 4, 3, 6, 4 },
                                        {2, 4, 7, 1, 4 }};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;

            for (int i = 0; i < row; i++)
            {
                min = matrix[i, 0];
                min_ind1 = i;
                min_ind2 = 0;

                for (int j = 0; j < col; j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        min_ind1 = i;
                        min_ind2 = j;
                    }
                }

                for (int j = min_ind2; j > 0; j--) matrix[i, j] = matrix[i, j - 1];
                matrix[i, 0] = min;
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region I|29
            Console.WriteLine("I|29");

            matrix = new double[5, 7] { {4, 5, 6, 7, 5, 6, 7 },
                                        {1, 7, 2, 0, -7, 2, 0 },
                                        {9, 4, 3, 6, 4, 3, 6 },
                                        {2, 4, 7, 1, 4, 7, 1 },
                                        {7, 1, 3, 9, 2, 0, 2 }};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            matrix_answ = new double[row, col - 1];
            min = matrix[1, 0];
            min_ind2 = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (min > Math.Abs(matrix[i, j]))
                    {
                        min = Math.Abs(matrix[i, j]);
                        min_ind2 = j + 1;
                    }
                }
            }

            if (min_ind2 == col) min_ind2 = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j < min_ind2) matrix_answ[i, j] = matrix[i, j];
                    else if (j > min_ind2) matrix_answ[i, j-1] = matrix[i, j];
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col-1; j++) Console.Write("{0,3} ", matrix_answ[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region I|31
            Console.WriteLine("I|31");

            matrix = new double[5, 8] { {4, 5, 6, 7, 5, 6, 7, 0 },
                                        {1, -7, 2, 0, -7, 2, 0, 0 },
                                        {9, 4, 3, 6, 4, 3, 6, 0 },
                                        {2, 4, -7, 1, 4, 7, 1, 0 },
                                        {7, -1, 3, 9, -2, 0, -2, 0 }};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            min = matrix[4, 0];
            min_ind2 = 0;
            array = new double[5] { -2, 6, 10, 2, -99 };

            for (int i = 0; i < col - 1; i++)
            {
                if (min > matrix[4, i])
                {
                    min = matrix[4, i];
                    min_ind2 = i + 1;
                }
            }

            if (min_ind2 == col) min_ind2 = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == min_ind2)
                    {
                        min = matrix[i, j];
                        matrix[i, j] = array[i];
                    }
                    else if (j >= min_ind2)
                    {
                        max = matrix[i, j];
                        matrix[i, j] = min;
                        min = max;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region II|7
            Console.WriteLine("II|7");

            answ = 0;
            matrix = new double[6, 6] { {4, 5, 6, 7, 5, 6, },
                                        {1, -7, 2, 0, -7, 2 },
                                        {9, 4, 3, 6, 4, 3},
                                        {2, 4, -7, 5, 4, 7 },
                                        {7, -1, 3, 9, -2, 0 },
                                        {3, 5, 1, -2, -9, 9 } };
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            max = matrix[0, 0];
            max_ind1 = 0;
            max_ind2 = 0;

            for (int i = 0; i < row; i++)
            {
                if (max < matrix[i, i])
                {
                    max = matrix[i, i];
                    max_ind1 = i;
                    max_ind2 = i;
                }
            }

            for (int i = 0; i < max_ind1; i++)
            {
                for (int j = i+1; j < col; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region II|8
            Console.WriteLine("II|8");

            matrix = new double[6, 6] { {4, 5, 6, 7, 5, 6, },
                                        {1, -7, 2, 0, -7, 2 },
                                        {9, 4, 3, 6, 4, 3 },
                                        {2, 4, -7, 5, 4, 7 },
                                        {7, -1, 3, 9, -2, 0 },
                                        {3, 5, 1, -2, -9, 9 }};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            max = matrix[0, 0];
            max_ind1 = 0;
            max_ind2 = 0;


            for (int i = 0; i < row; i++)
            {
                max = matrix[i, 0];
                for (int j = 0; j < col; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (max < matrix[i, j])
                        {
                            max = matrix[i, j];
                            max_ind1 = j;
                        }
                    }
                    else if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        max_ind2 = j;
                    }
                }
                if (i % 2 != 0)
                {
                    answ = matrix[i, max_ind2];
                    matrix[i, max_ind2] = matrix[i - 1, max_ind1];
                    matrix[i - 1, max_ind1] = answ;
                    max_ind1 = 0;
                    max_ind2 = 0;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region II|9
            Console.WriteLine("II|9");

            matrix = new double[6, 7] { {4, 5, 6, 7, 5, 6, 2},
                                        {1, -7, 2, 0, -7, 2, 6},
                                        {9, 4, 3, 6, 4, 3, 9},
                                        {2, 4, -7, 5, 4, 7, -1 },
                                        {7, -1, 3, 9, -2, 0, 4},
                                        {3, 5, 1, -2, -9, 9, 1}};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            int cnt = 0;
            array = new double[col];
            
            for (int i = 0; i < row; i++)
            {
                cnt = col - 1;
                for (int j = 0; j < col; j++)
                {
                    array[cnt] = matrix[i, j];
                    cnt--;
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

            #region III|1
            Console.WriteLine("III|1");

            matrix = new double[7, 5] { {4, 5, 6, 7, 5},
                                        {1, -7, 2, 0, -7},
                                        {9, 4, 3, 6, 4},
                                        {2, 4, -7, 5, 4},
                                        {7, -1, 3, 9, -2},
                                        {3, 5, 1, -2, -9},
                                        {5, 2, -10, 4, 2}};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            min = matrix[0, 0];
            matrix_answ = new double[row, 2];
            double[,] matrix_answ2 = new double[row, col];
            array = new double[2];

            for (int i = 0; i < row; i++)
            {
                min = matrix[i, 0];
                for (int j = 0; j < col; j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        matrix_answ[i, 0] = matrix[i, j];
                        matrix_answ[i, 1] = i;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row - i - 1; j++)
                {
                    if (matrix_answ[j, 0] < matrix_answ[j + 1, 0])
                    {
                        array[0] = matrix_answ[j, 0];
                        array[1] = matrix_answ[j, 1];
                        matrix_answ[j, 0] = matrix_answ[j + 1, 0];
                        matrix_answ[j, 1] = matrix_answ[j + 1, 1];
                        matrix_answ[j + 1, 0] = array[0];
                        matrix_answ[j + 1, 1] = array[1];
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix_answ2[i, j] = matrix[(int)matrix_answ[i, 1], j];
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix_answ2[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region III|2
            Console.WriteLine("III|2");

            matrix = new double[n, n] { {4, 5, 6, 7},
                                        {1, -7, 2, 0},
                                        {9, 4, 3, 6},
                                        {2, 4, -7, 5}};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;

            for (int i = 0; i < row; i++)
            {
                matrix[0, i] = 0;
                matrix[i, 0] = 0;
                matrix[row - 1, i] = 0;
                matrix[i, col - 1] = 0;
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region III|3
            Console.WriteLine("III|3");

            matrix = new double[n, n] { {4, 5, 6, 7},
                                        {1, -7, 2, 0},
                                        {9, 4, 3, 6},
                                        {2, 4, -7, 5}};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            array = new double[2 * n - 1];

            for (int i = 0; i < 2 * n - 1; i++)
            {
                if (n - 1 - i < 0) 
                {
                    cnt = 0;
                    for (int j = i + 1 - n; j < n; j++)
                    {
                        array[i] += matrix[cnt, j];
                        cnt++;
                    }
                }
                else
                {
                    cnt = 0;
                    for (int j = n - i - 1; j < n; j++)
                    {
                        array[i] += matrix[j, cnt];
                        cnt++;
                    }
                }
            }

            foreach (double i in array) Console.Write("{0,3} ", i);
            Console.WriteLine();

            Console.WriteLine("-----------------------");
            #endregion

            #region III|4
            Console.WriteLine("III|4");

            matrix = new double[n+1, n+1] { {4, 5, 6, 7, 5},
                                            {9, -7, 2, 0, 1},
                                            {9, 4, 3, 6, -5},
                                            {2, 4, -7, 5, -4},
                                            {0, -2, -9, -2, 1}};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;

            for (int i = row - 1; i >= row / 2; i--)
            {
                for (int j = 0; j < row; j++)
                {
                    if (i < j) break;
                    else
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region III|8
            Console.WriteLine("III|8");

            matrix = new double[7, 5] { {4, 5, 6, 7, 5},
                                        {1, -7, 2, 0, -7},
                                        {9, 4, 3, 6, 4},
                                        {2, 4, -7, 5, 4},
                                        {7, -1, 3, 9, -2},
                                        {3, 5, 1, -2, -9},
                                        {5, 2, -10, 4, 2}};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            array = new double[row];
            max = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        array[i]++;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        for (int p = 0; p < col; p ++)
                        {
                            max = matrix[j, p];
                            matrix[j, p] = matrix[j+1, p];
                            matrix[j+1, p] = max;
                        }
                        max = array[j];
                        array[j] = array[j+1];
                        array[j+1] = max;
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
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
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            array = new double[row];
            max = 0;

            for (int k = 0; k < row; k++)
            {
                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < col - i - 2; j++)
                    {
                        if (j % 2 == 0)
                        {
                            if (matrix[k, j] < matrix[k, j + 2])
                            {
                                max = matrix[k, j];
                                matrix[k, j] = matrix[k, j + 2];
                                matrix[k, j + 2] = max;
                            }
                        }
                        else
                        {
                            if (matrix[k, j] > matrix[k, j + 2])
                            {
                                max = matrix[k, j];
                                matrix[k, j] = matrix[k, j + 2];
                                matrix[k, j + 2] = max;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion

            #region III|11
            Console.WriteLine("III|11");

            matrix = new double[7, 5] { {4, 5, 6, 7, 5},
                                        {1, -7, 2, 0, -7},
                                        {9, 4, 3, 6, 4},
                                        {2, 4, -7, 5, 4},
                                        {7, -1, 3, 9, -2},
                                        {3, 5, 1, -2, -9},
                                        {5, 2, -10, 4, 2}};
            row = matrix.GetUpperBound(0) + 1;
            col = matrix.Length / row;
            array = new double[row];
            cnt = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        array[i] = -1;
                        cnt++;
                        break;
                    }
                }
            }

            matrix_answ = new double[row - cnt, col];
            cnt = 0;

            for (int i = 0; i < row; i++)
            {
                if (array[i] == -1)
                {
                    cnt++;
                }
                else
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrix_answ[i - cnt, j] = matrix[i, j];
                    }
                }
            }

            for (int i = 0; i < row - cnt; i++)
            {
                for (int j = 0; j < col; j++) Console.Write("{0,3} ", matrix_answ[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            #endregion
        }
    }
}