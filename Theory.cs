using System;
using System.Diagnostics.Metrics;
// Nizamiev, Laboratorka N3
namespace Lesson
{
    class Program
    {
        public static void Main(string[] args)
        {
            ////LVL1, TSK 3
            //int[,] a = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            //int sum = 0;
            //int n = 4;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    sum += a[i, i];
            //}
            //Console.Write(sum);

            //LVL1, TSK 6
            //int[,] a = new int[4, 7] { { 4, 2, 3, 1, 5, 6, 7 }, { 12, 8, 9, 10, 11, 7, 13 }, { 20, 15, 16, 17, 18, 19, 14 }, { 21, 22, 23, 24, 25, 26, 27 } };
            //int n = 4;
            //int m = 7;
            //double[] b = new double[n];
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    double mina = a[i, 0];
            //    int min_ij = 0;
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (a[i, j] <= mina)
            //        {
            //            mina = a[i, j];
            //            min_ij = j;
            //        }
            //    }
            //    b[i] = min_ij;
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("{0:f0} ", b[i]);
            //}


            ////LVL1, TSK 12
            //int[,] a = new int[6, 7] { { 4, 2, 3, 1, 5, 6, 7 }, { 12, 8, 9, 10, 11, 7, 13 }, { 20, 15, 16, 17, 228, 19, 14 }, { 21, 22, 23, 24, 25, 26, 27 }, { 11, 23, 24, 41, 55, 66, 22 }, { 44, 22, 33, 11, 1, 5, 7 } };
            //int n = 6;
            //int m = 7;
            //int maxa = a[0, 0];
            //int imax = 0;
            //int jmax = 0;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (a[i, j] >= maxa)
            //        {
            //            maxa = a[i, j];
            //            imax = i;
            //            jmax = j;
            //        }
            //    }
            //}
            //n = n - 1;
            //for (int i = imax; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        a[i, j] = a[i + 1, j];
            //    }
            //}
            //m = m - 1;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = jmax; j < m; j++)
            //    {
            //        a[i, j] = a[i, j + 1];
            //    }
            //}
            //Console.Write("Matrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            ////LVL1, TSK 13
            //int[,] a = new int[5, 5] { { 4, 2, 3, 1, 5 }, { 12, 0, 9, 10, 11 }, { 20, 8, 228, 17, 12 }, { 21, 22, 23, 22, 25 }, { 11, 23, 24, 41, 21 } };
            //int n = 5;
            //int m = 5;
            //int amax = a[0, 0];
            //int imax = 0;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i, i] >= amax)
            //    {
            //        amax = a[i, i];
            //        imax = i;
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    int k = a[i, 3];
            //    a[i, 3] = a[i, imax];
            //    a[i, imax] = k;
            //}
            //Console.Write("Matrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}



            ////LVL1, TSK 17
            //int[,] a = new int[5, 6] { { 4, 2, 3, 1, 5, 0 }, { 12, 0, 9, 10, 11, 7 }, { 20, 8, 228, 17, 12, 11 }, { 21, 22, 23, 22, 25, 29 }, { 24, 23, 11, 41, 21, 22 } };
            //int n = 5;
            //int m = 6;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    int amin = a[i, 0];
            //    int imin = 0;
            //    int jmin = 0;
            //    int k = 0;
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (a[i, j] <= amin)
            //        {
            //            amin = a[i, j];
            //            imin = i;
            //            jmin = j;
            //        }
            //    }
            //    for (int d = jmin; d > 0; d--)
            //    {
            //        a[i, d] = a[i, d - 1];
            //    }
            //    a[i, 0] = amin;
            //}
            //Console.Write("Matrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            ////LVL1, TSK 29
            //int[,] a = new int[5, 7] { { 4, 2, 3, 1, 5, 0, 29 }, { 12, 0, 9, 10, 11, 7, 11 }, { 20, 8, 228, 17, 12, 11, 29 }, { 21, 22, 23, 22, 25, 29, 23 }, { 24, 23, 11, 41, 21, 22, 12 } };
            //int n = 5;
            //int m = 7;
            //int amin = a[2, 0];
            //int jmin = 0;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int j = 0; j < m; j++)
            //{
            //    if (Math.Abs(a[1, j]) <= amin)
            //    {
            //        amin = Math.Abs(a[1, j]);
            //        jmin = j;
            //    }
            //}
            //m -= 1;
            //int s = jmin + 1;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = s; j < m; j++)
            //    {
            //        a[i, j] = a[i, j + 1];
            //    }
            //}
            //Console.Write("Matrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            ////LVL1, TSK31
            //int[,] a = new int[5, 8] { { 4, 2, 3, 1, 5, 0, 29, 0 }, { 12, 0, 9, 10, 11, 7, 11, 0 }, { 20, 8, 228, 17, 12, 11, 29, 0 }, { 21, 22, 23, 22, 25, 29, 23, 0 }, { 25, 6, 13, 17, 83, 5, 29, 0 } };
            //int n = 5;
            //int m = 8;
            //int[] b = new int[5] { 1, 2, 3, 4, 5 };
            //int amin = a[4, 0];
            //int jmin = 0;
            //int k = 0;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int j = 0; j < m; j++)
            //{
            //    if (a[4, j] <= amin && j != 7)
            //    {
            //        amin = a[4, j];
            //        jmin = j;
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (j == 7)
            //        {
            //            a[i, j] = b[i];
            //        }
            //    }
            //    for (int d = jmin; d < m - 1; d++)
            //    {
            //        k = a[i, d];
            //        a[i, d] = a[i, d + 1];
            //        a[i, d + 1] = k;
            //    }
            //}
            //Console.Write("Matrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            ////////////////////////////////LVL2/////////////////////


            ////LVL2, TSK 7
            //int[,] a = new int[6, 6] { { 4, 2, 3, 1, 5, 0 }, { 12, 1, 9, 10, 11, 7 }, { 20, 8, 228, 17, 12, 11 }, { 21, 22, 23, 322, 25, 29 }, { 25, 6, 13, 17, 83, 5 }, { 12, 22, 54, 23, 65, 11 } };
            //int n = 6;
            //int amax = a[0, 0];
            //int imax = 0;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i, i] >= amax)
            //    {
            //        amax = a[i, i];
            //        imax = i;
            //    }
            //}
            //int k = imax;
            //for (int i = 0; i < k; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        a[i, j] = 0;
            //    }
            //}
            //Console.Write("Matrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            ////LVL2, TSK 8
            //int[,] a = { { 22, 11, 13, 16, 21, 43 }, { 22, 11, 13, 16, 21, 44 }, { 22, 11, 13, 16, 21, 45 }, { 22, 11, 13, 16, 21, 46 }, { 22, 11, 13, 16, 21, 47 }, { 22, 11, 13, 16, 21, 48 }, };
            //int amax = 0;
            //int bmax = 0;
            //int aIND = 0;
            //int bIND = 0;
            //int k;
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int z = 0; z <= 4; z = z + 2)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        if (amax < a[z, j])
            //        {
            //            amax = a[z, j];
            //            aIND = j;

            //        }
            //        if (bmax < a[z + 1, j])
            //        {
            //            bmax = a[z + 1, j];
            //            bIND = j;
            //        }


            //    }
            //    k = a[z, aIND];
            //    a[z, aIND] = a[z + 1, bIND];
            //    a[z + 1, bIND] = k;

            //    Console.WriteLine(amax);
            //    Console.WriteLine(bmax);
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);

            //    }
            //    Console.WriteLine();
            //}

            ////LVL2, TSK 9
            //int[,] a = new int[6, 7] { { 4, 2, 3, 1, 5, 0, 7 }, { 12, 1, 9, 10, 11, 7, 23 }, { 20, 8, 228, 17, 12, 11, 15 }, { 21, 22, 23, 322, 25, 29, 6 }, { 25, 6, 13, 17, 83, 5, 11 }, { 12, 22, 54, 23, 65, 11, 90 } };
            //int n = 6;
            //int m = 7;
            //int k = 0;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m / 2; j++)
            //    {
            //        k = a[i, j];
            //        a[i, j] = a[i, m - (j + 1)];
            //        a[i, m - (j + 1)] = k;
            //    }
            //}
            //Console.Write("Matrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            /////////////////////////////LVL3//////////////////////
            ///

            ////LVL3, TSK 1
            //int[,] a = new int[7, 5] { { 111, 21, 4, 6, 11 },
            //                           { 23, 3, 56, 67, 89 },
            //                           { 45, 14, 19, 21, 35 },
            //                           { 25, 44, 31, 98, 101 },
            //                           { 91, 85, 33, 21, 56 },
            //                           { 78, 65, 32, 60, 50 },
            //                           { 83, 94, 22, 3, 10 } };
            //int n = 7;
            //int m = 5;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n - 1; i > 0; i--)
            //{
            //    int min_a = a[i, 0];
            //    int k = 0;
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        for (int d = 0; d < m; d++)
            //        {
            //            if (a[j, d] < min_a)
            //            {
            //                min_a = a[j, d];
            //                k = j;
            //            }
            //        }
            //    }
            //    for (int t = 0; t < m; t++)
            //    {
            //        int l = a[k, t];
            //        a[k, t] = a[i, t];
            //        a[i, t] = l;
            //    }
            //}
            //Console.Write("\nMatrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            ////LVL3, TSK 2
            //int[,] a = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            //int n = 4;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    a[0, i] = 0;
            //    a[n - 1, i] = 0;
            //    a[i, 0] = 0;
            //    a[i, n - 1] = 0;
            //}
            //Console.Write("Matrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            ////LVL3, TSK 3
            //int[,] a = new int[5, 5] { { 1, 2, 3, 4, 5 },
            //                           { 6, 7, 8, 9, 10 },
            //                           { 11, 12, 13, 14, 15 },
            //                           { 16, 17, 18, 19, 20 },
            //                           { 21, 22, 23, 24, 25 } };
            //int n = 5;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int[] b = new int[2 * n - 1];
            //for (int i = 0; i < n; i++)
            //{
            //    int sum1 = 0;
            //    int sum2 = 0;
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        sum1 += a[j, j + i];
            //    }
            //    b[i] = sum1;
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        sum2 += a[j + i, j];
            //    }
            //    b[i + n - 1] = sum2;
            //}
            //Console.Write("\nsum of diagonals: ");
            //for (int i = 0; i < n * 2 - 1; i++)
            //{
            //    Console.Write("{0:f0} ", b[i]);
            //}


            ////LVL3, TSK 4
            //int[,] a = new int[5, 5] { { 11, 22, 33, 44, 55 }, { 12, 23, 17, 56, 43 }, { 87, 10, 24, 15, 75 }, { 13, 41, 55, 16, 71 }, { 27, 33, 41, 34, 87 } };
            //int n = 5;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n / 2; i < n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        a[i, j] = 1;
            //    }
            //}
            //Console.Write("Matrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            ////LVL3, TSK 8
            //int[,] a = new int[7, 5] { { 111, 21, 4, 6, 11 },
            //                           { 23, 3, -56, -67, 89 },
            //                           { -45, 14, 19, -21, 35 },
            //                           { 25, 44, 31, -98, 101 },
            //                           { 91, -85, 33, 21, -56 },
            //                           { 78, 65, 32, -60, 50 },
            //                           { 83, -94, -22, -3, 10 } };
            //int n = 7;
            //int m = 5;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n - 1; i > 0; i--)
            //{
            //    int k = 0;
            //    int count = 0;
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        int s = 0;
            //        for (int d = 0; d < m; d++)
            //        {
            //            if (a[j, d] < 0)
            //            {
            //                s += 1;
            //            }
            //            if (s >= count)
            //            {
            //                count = s;
            //                k = j;
            //            }
            //        }
            //    }
            //    for (int t = 0; t < m; t++)
            //    {
            //        int l = a[k, t];
            //        a[k, t] = a[i, t];
            //        a[i, t] = l;
            //    }
            //}
            //Console.Write("\nMatrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            ////LVL3, TSK 10
            //int[,] a = new int[4, 5] { { 11, 10, 5, 24, 8 },
            //                           { 101, 22, 38, 1, -9 },
            //                           { -11, 122, 33, 44, 15 },
            //                           { 66, 17, -18, 19, 20 } };
            //int n = 4;
            //int m = 5;
            //Console.Write("Original matrix: ");
            //Console.WriteLine("");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m - 2; j += 2)
            //    {
            //        int k = 0;
            //        if (a[i, j] <= a[i, j + 2])
            //        {
            //            k = a[i, j];
            //            a[i, j] = a[i, j + 2];
            //            a[i, j + 2] = k;
            //        }
            //    }
            //    for (int j = 1; j < m - 2; j += 2)
            //    {
            //        int k = 0;
            //        if (a[i, j] >= a[i, j + 2])
            //        {
            //            k = a[i, j];
            //            a[i, j] = a[i, j + 2];
            //            a[i, j + 2] = k;
            //        }
            //    }
            //}
            //Console.Write("\nMatrix: ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0:d} ", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}



            //LVL3, TSK 11
            int[,] a = new int[4, 5] { { 0, 22, 1, 1, 55 }, { 12, 38, 1, 56, 43 }, { 87, 38, 21, 15, 75 }, { 11, 1, 5, 11, 0 } };
            int n = 4;
            int m = 5;
            Console.Write("Original matrix: ");
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] == 0)
                    {
                        k += 1;
                        break;
                    }
                    else
                    {
                        a[i - k, j] = a[i, j];
                    }
                }
            }
            Console.Write("Matrix: ");
            Console.WriteLine();
            for (int i = 0; i < n - k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
