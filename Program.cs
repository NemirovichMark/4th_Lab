using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ERROR = "Input incorrect!";

            #region Task_1_3
            Console.WriteLine("Task 1.3");
            double sum = 0;
            double[,] M = new double[4, 4];
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < 4; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                    if (i == j || i + j == 3)
                    {
                        sum += x;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Trace = {sum}\n");
            #endregion

            #region Task_1_6
            Console.WriteLine("Task 1.6");
            M = new double[4, 7];
            string str = "";
            List<string> lst = new List<string>(4);
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < 7; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                }
            }
            Console.WriteLine();
            double max = M[0, 0];
            int maxi = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (M[i, j] > max)
                    {
                        max = M[i, j];
                        maxi = j;
                    }
                }
                str = "[" + i + "," + maxi + "]";
                lst.Add(str);
            }
            foreach (string i in lst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Task_1_12
            Console.WriteLine("Task 1.12");
            M = new double[6, 7] {{1, 2, 4, 5, 6, 7, 8},
                                  {2, 4, 5, 90, 6,7, 8},
                                  {2, 7, 8, 9, 1, 6, 7},
                                  {2, 7, 8, 9, 1, 6, 7},
                                  {2, 7, 8, 9, 1, 6, 7},
                                  {2, 7, 8, 9, 1, 6, 7}};
            max = M[0, 0];
            maxi = 0;
            int maxj = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (M[i, j] > max)
                    {
                        max = M[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }
            }
            for (int i = maxi; i < 5; i++)
                for (int j = 0; j < 7; j++)
                    M[i, j] = M[i + 1, j];
            for (int i = 0; i < 5; i++)
                for (int j = maxj; j < 6; j++)
                    M[i, j] = M[i, j + 1];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_1_13
            Console.WriteLine("Task 1.13");
            M = new double[5, 5] {{1, 2, 4, 5, 6},
                                  {2, 90, 5, 90, 6},
                                  {2, 7, 8, 9, 1},
                                  {2, 7, 8, 9, 1},
                                  {2, 7, 8, 9, 1}};
            max = M[0, 0];
            maxj = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (M[i, j] > max && i == j)
                    {
                        max = M[i, j];
                        maxj = j;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
                (M[i, maxj], M[i, 3]) = (M[i, 3], M[i, maxj]);
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_1_17
            Console.WriteLine("Task 1.17");
            Console.Write("Write n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write m: ");
            if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[n, m];
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < m; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                }
            }
            Console.WriteLine();
            double min = double.MaxValue;
            int minj = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > M[i, j])
                    {
                        min = M[i, j];
                        minj = j;
                    }
                }
                for (int j = minj; j != 0; j--)
                {
                    double a = M[i, j - 1];
                    M[i, j - 1] = M[i, j];
                    M[i, j] = a;
                }
                min = double.MaxValue;
                minj = -1;
                for (int j = 0; j < m; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_1_29
            Console.WriteLine("Task 1.29");
            M = new double[5, 7];
            min = double.MaxValue;
            minj = -1;
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < 7; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                    if (i == 1)
                        if (min > Math.Abs(M[1, j]))
                        {
                            min = Math.Abs(M[1, j]);
                            minj = j;
                        }
                }
            }
            if (minj == 6) minj = -1;
            minj += 1;
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
                for (int j = minj; j < 6; j++)
                    M[i, j] = M[i, j + 1];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_1_31
            Console.WriteLine("Task 1.31");
            M = new double[5, 8];
            double[] B = new double[5];
            min = double.MaxValue;
            minj = -1;
            Console.WriteLine("Write vector B: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Write {i} element: ");
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                B[i] = x;
            }
            Console.WriteLine();
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < 7; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                    if (i == 4)
                        if (min > M[4, j])
                        {
                            min = M[4, j];
                            minj = j;
                        }
                }
            }
            if (minj == 6) minj = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 6; j > minj; j--)
                    M[i, j + 1] = M[i, j];
            for (int i = 0; i < 5; i++)
                M[i, minj + 1] = B[i];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_2_7
            Console.WriteLine("Task 2.7");
            M = new double[6, 6];
            max = double.MinValue;
            maxi = -1;
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < 6; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                    if (i == j)
                        if (max < M[i, j])
                        {
                            max = M[i, j];
                            maxi = i;
                        }
                }
            }
            for (int i = maxi - 1; i >= 0; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    M[i, j] = 0;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_2_8
            Console.WriteLine("Task 2.8");
            M = new double[6, 6];
            max = double.MinValue;
            maxj = -1;
            List<int> numbers = new List<int>();
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < 6; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                    if (max == M[i, j])
                        max = M[i, j];
                    maxj = j;
                }
                numbers.Add(maxj);
            }
            for (int i = 0; i < 6; i += 2)
                (M[i, numbers[i]], M[i + 1, numbers[i + 1]]) = (M[i + 1, numbers[i + 1]], M[i, numbers[i]]);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_2_9
            Console.WriteLine("Task 2.9");
            M = new double[6, 7];
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < 7; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                }
            }
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 7 / 2; j++)
                    (M[i, j], M[i, 7 - j - 1]) = (M[i, 7 - j - 1], M[i, j]);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_3_1
            Console.WriteLine("Task 3.1");
            M = new double[5, 6] { { 10,-120, 2, 3, 4 ,-2},
                                 { 5.1, 6, -100,-3.1, 8 ,32},
                                 { 9,10, 13, 10, -101,42 },
                                 { -10,13, 14, 15,-103, 3.9 },
                                 {10, 5, 6, 7, 90, -10}};
            //M = new double[4, 1] { {10}, { 0 }, { -13 }, { 22 } };
            List<double> duble = new List<double>();
            static double Minimum(double[,] M, int m)
            {
                double mn = double.MaxValue;
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (mn > M[m, j])
                    {
                        mn = M[m, j];
                    }
                }
                return mn;
            }
            for (int i = 0; i < M.GetLength(0); i++)
            {
                duble.Add(Minimum(M, i));
            }
            List<double> duble2 = new List<double>(duble);
            duble.Sort();

            double[,] MM = new double[5, 6];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                int OOO = duble2.IndexOf(duble[i]);
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    MM[i, j] = M[OOO, j];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(MM[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_3_2
            Console.WriteLine("Task 3.2");
            Console.Write("Write n: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[n, n];
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < n; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                    if ((i == 0) || (j == 0) || (i == (n - 1)) || (j == (n - 1)))
                        M[i, j] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_3_3
            Console.WriteLine("Task 3.3");
            Console.Write("Write n: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[n, n];
            B = new double[2 * n - 1];
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < n; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            int k = 0;
            for (int i = n - 1; i > 0; i--)
            {
                double s = 0;
                for (int j = 0; j + i < n; j++)
                {
                    s += M[i + j, j];
                }
                B[k] = s;
                k++;
            }
            for (int i = n - 1; i >= 0; i--)
            {
                double s = 0;
                for (int j = 0; j + i < n; j++)
                {
                    s += M[j, i + j];
                }
                B[k] = s;
                k++;
            }
            foreach (double i in B)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion

            #region Task_3_4
            Console.WriteLine("Task 3.4");
            Console.Write("Write n: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[n, n];
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < n; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                }
            }
            Console.WriteLine();
            for (int i = n / 2; i != n; i++)
            {
                for (int j = 0; j != n; j++)
                {
                    if (i == j | i > j)
                        M[i, j] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Task_3_8
            Console.WriteLine("Task 3.8");
            Console.Write("Write n: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write m: ");
            if (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[n, m];
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < m; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                }
            }
            Console.WriteLine();
            duble = new List<double>();
            static double Counter(double[,] M, int mmm)
            {
                int k = 0;
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[mmm, j] >= 0)
                    {
                        k += 1; ;
                    }
                }
                return k;
            }
            for (int i = 0; i < n; i++)
            {
                duble.Add(Counter(M, i));
            }
            MM = new double[n, m];
            for (int i = 0; i < duble.Count - 1; i++)
            {
                for (int j = 0; j < duble.Count - 1 - i; j++)
                {
                    if (duble[j] < duble[j + 1])
                    {
                        (duble[j], duble[j + 1]) = (duble[j + 1], duble[j]);
                        double[] N = new double[m];
                        for (int o = 0; o < m; o++)
                            N[o] = M[j, o];
                        for (int o = 0; o < m; o++)
                        {
                            M[j, o] = M[j + 1, o];
                            M[j + 1, o] = N[o];
                        }

                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        #endregion

            #region Task_3_10
            Console.WriteLine("Task 3.10");
            Console.Write("Write n: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write m: ");
            if (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[n, m];
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < m; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    double[] N = new double[m];
                    for (int j = 0; j < m; j++)
                    {
                        N[j] = M[i, j];
                    }
                    Array.Sort(N);
                    Array.Reverse(N);
                    for (int j = 0; j < m; j++)
                    {
                        M[i, j] = N[j];
                    }
                }
                else
                {

                    double[] N = new double[m];
                    for (int j = 0; j < m; j++)
                    {
                        N[j] = M[i, j];
                    }
                    Array.Sort(N);
                    for (int j = 0; j < m; j++)
                    {
                        M[i, j] = N[j];
                    }

                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        #endregion

            #region Task_3_11
            Console.WriteLine("Task 3.11");
            Console.Write("Write n: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write m: ");
            if (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[n, m];
            Console.WriteLine("Write massive: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Write numbers of {i} string: ");
                for (int j = 0; j < m; j++)
                {
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine(ERROR);
                        return;
                    }
                    M[i, j] = x;
                }
            }
            Console.WriteLine();
            int[] C = new int[n];
            k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    if (M[i, j] == 0)
                    {
                        C[i] = 1;
                        k++;
                        break;
                    }
                }
            }
            double[,] MMM = new double[k, m];
            int K = 0;
            for (int i = 0; i < n; i++)
            {
                if (C[i] == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        MMM[K, j] = M[i, j];
                    }
                    K++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(MMM[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion
        }
    }
}
