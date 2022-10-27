using System;

namespace _4th_Lab
{
    class Programm
    {
        static void Main(string[] args)
        {
            #region 4.1.3

            int i = 0, j = 0, n;
            double s = 0;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n);
            while (n <= 0)
            {
                Console.WriteLine("n > 0! enter another n");
                int.TryParse(Console.ReadLine(), out n);
            }
            double[,] a = new double[n, n];
            Console.WriteLine($"enter {n * n} elements");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    double.TryParse(Console.ReadLine(), out a[i, j]);
                }
            }
            Console.WriteLine("array: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                s = a[i, i] + s;
            }
            Console.WriteLine($"matrix trace - {s}");

            #endregion

            #region 4.1.6

            int i_q = 0, j_q = 0, n_q = 4, m_q = 7, k_q = 0, imin_q = 0;
            double min_q;
            double[,] a_q = new double[n_q, m_q];
            int[] b_q = new int[n_q];
            Console.WriteLine($"enter {n_q * m_q} elements");
            for (i_q = 0; i_q < n_q; i_q++)
            {
                for (j_q = 0; j_q < m_q; j_q++)
                {
                    double.TryParse(Console.ReadLine(), out a_q[i_q, j_q]);
                }
            }
            Console.WriteLine("array: ");
            for (i_q = 0; i_q < n_q; i_q++)
            {
                for (j_q = 0; j_q < m_q; j_q++)
                {
                    Console.Write($"{a_q[i_q, j_q]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i_q = 0; i_q < n_q; i_q++)
            {
                min_q = a_q[i_q, 0];
                imin_q = k_q;
                for (j_q = 0; j_q < m_q; j_q++)
                {

                    if (a_q[i_q, j_q] < min_q)
                    {
                        min_q = a_q[i_q, j_q];
                        imin_q = k_q;
                    }
                    k_q++;
                }
                b_q[i_q] = imin_q;
            }
            Console.WriteLine($"array of imins: ");
            for (i_q = 0; i_q < n_q; i_q++)
            {
                Console.Write($"{b_q[i_q]} ");
            }
            Console.WriteLine();

            #endregion

            #region 4.1.12

            int i_w = 0, j_w = 0, n_w = 6, m_w = 7, imax_w = 0, jmax_w = 0;
            double max_w;
            double[,] a_w = new double[n_w, m_w];
            Console.WriteLine($"enter {n_w * m_w} elements");
            for (i_w = 0; i_w < n_w; i_w++)
            {
                for (j_w = 0; j_w < m_w; j_w++)
                {
                    double.TryParse(Console.ReadLine(), out a_w[i_w, j_w]);
                }
            }
            max_w = a_w[0, 0];
            Console.WriteLine("array: ");
            for (i_w = 0; i_w < n_w; i_w++)
            {
                for (j_w = 0; j_w < m_w; j_w++)
                {
                    Console.Write($"{a_w[i_w, j_w]} ");
                    if (a_w[i_w, j_w] > max_w)
                    {
                        max_w = a_w[i_w, j_w];
                        imax_w = i_w;
                        jmax_w = j_w;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i_w = imax_w; i_w < n_w - 1; i_w++)
            {
                for (j_w = 0; j_w < m_w; j_w++)
                {
                    a_w[i_w, j_w] = a_w[i_w + 1, j_w];
                }
            }
            for (i_w = 0; i_w < n_w - 1; i_w++)
            {
                for (j_w = jmax_w; j_w < m_w - 1; j_w++)
                {
                    a_w[i_w, j_w] = a_w[i_w, j_w + 1];
                }
            }
            Console.WriteLine($"new array: ");
            for (i_w = 0; i_w < n_w - 1; i_w++)
            {
                for (j_w = 0; j_w < m_w - 1; j_w++)
                {
                    Console.Write($"{a_w[i_w, j_w]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.1.13

            const int k_e = 4;
            int i_e = 0, j_e = 0, n_e = 5, m_e = 5, jmax_e = 0;
            double max_e, p_e;
            double[,] a_e = new double[n_e, m_e];
            Console.WriteLine($"enter {n_e * m_e} elements");
            for (i_e = 0; i_e < n_e; i_e++)
            {
                for (j_e = 0; j_e < m_e; j_e++)
                {
                    double.TryParse(Console.ReadLine(), out a_e[i_e, j_e]);
                }
            }
            max_e = a_e[0, 0];
            Console.WriteLine("array: ");
            for (i_e = 0; i_e < n_e; i_e++)
            {
                if (a_e[i_e, i_e] > max_e)
                {
                    max_e = a_e[i_e, i_e];
                    jmax_e = i_e;
                }
                for (j_e = 0; j_e < m_e; j_e++)
                {
                    Console.Write($"{a_e[i_e, j_e]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (jmax_e != k_e - 1)
            {
                for (i_e = 0; i_e < n_e; i_e++)
                {
                    p_e = a_e[i_e, k_e - 1];
                    a_e[i_e, k_e - 1] = a_e[i_e, jmax_e];
                    a_e[i_e, jmax_e] = p_e;
                }
            }
            Console.WriteLine($"new array: ");
            for (i_e = 0; i_e < n_e; i_e++)
            {
                for (j_e = 0; j_e < m_e; j_e++)
                {
                    Console.Write($"{a_e[i_e, j_e]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.1.17

            int i_r = 0, j_r = 0, n_r, m_r, jmin_r;
            double min_r;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_r);
            while (n_r <= 0)
            {
                Console.WriteLine("n>0! try another n");
                int.TryParse(Console.ReadLine(), out n_r);
            }
            Console.WriteLine("enter m");
            int.TryParse(Console.ReadLine(), out m_r);
            while (m_r <= 0)
            {
                Console.WriteLine("m>0! try another m");
                int.TryParse(Console.ReadLine(), out m_r);
            }
            double[,] B = new double[n_r, m_r];
            Console.WriteLine($"enter {n_r * m_r} elements");
            for (i_r = 0; i_r < n_r; i_r++)
            {
                for (j_r = 0; j_r < m_r; j_r++)
                {
                    double.TryParse(Console.ReadLine(), out B[i_r, j_r]);
                }
            }
            Console.WriteLine("array: ");
            for (i_r = 0; i_r < n_r; i_r++)
            {
                for (j_r = 0; j_r < m_r; j_r++)
                {
                    Console.Write($"{B[i_r, j_r]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i_r = 0; i_r < n_r; i_r++)
            {
                min_r = B[i_r, 0];
                jmin_r = 0;
                for (j_r = 1; j_r < m_r; j_r++)
                {
                    if (B[i_r, j_r] < min_r)
                    {
                        min_r = B[i_r, j_r];
                        jmin_r = j_r;
                    }
                }
                if (jmin_r != 0)
                {
                    for (j_r = jmin_r; j_r > 0; j_r--)
                    {
                        B[i_r, j_r] = B[i_r, j_r - 1];
                    }
                    B[i_r, 0] = min_r;
                }
            }
            Console.WriteLine($"new array: ");
            for (i_r = 0; i_r < n_r; i_r++)
            {
                for (j_r = 0; j_r < m_r; j_r++)
                {
                    Console.Write($"{B[i_r, j_r]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.1.29

            const int p_t = 2;
            int i_t = 0, j_t = 0, n_t = 5, m_t = 7, jmin_t;
            double min_t;
            double[,] F = new double[n_t, m_t];
            Console.WriteLine($"enter {n_t * m_t} elements");
            for (i_t = 0; i_t < n_t; i_t++)
            {
                for (j_t = 0; j_t < m_t; j_t++)
                {
                    double.TryParse(Console.ReadLine(), out F[i_t, j_t]);
                }
            }
            Console.WriteLine("array: ");
            for (i_t = 0; i_t < n_t; i_t++)
            {
                for (j_t = 0; j_t < m_t; j_t++)
                {
                    Console.Write($"{F[i_t, j_t]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            min_t = Math.Abs(F[p_t - 1, 0]);
            jmin_t = 0;
            for (j_t = 0; j_t < m_t; j_t++)
            {
                if (Math.Abs(F[p_t - 1, j_t]) < min_t)
                {
                    min_t = Math.Abs(F[p_t - 1, j_t]);
                    jmin_t = j_t;
                }
            }
            for (i_t = 0; i_t < n_t; i_t++)
            {
                for (j_t = jmin_t + 1; j_t < m_t - 1; j_t++)
                {
                    F[i_t, j_t] = F[i_t, j_t + 1];
                }
            }

            Console.WriteLine($"new array: ");
            for (i_t = 0; i_t < n_t; i_t++)
            {
                for (j_t = 0; j_t < m_t - 1; j_t++)
                {
                    Console.Write($"{F[i_t, j_t]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.1.31

            const int p_y = 5;
            int i_y = 0, j_y = 0, n_y = 5, m_y = 8, jmin_y;
            double min_y;
            double[,] A = new double[n_y, m_y];
            double[] BB = new double[n_y];
            Console.WriteLine($"enter {n_y} elements for B");
            for (i_y = 0; i_y < n_y; i_y++)
            {
                double.TryParse(Console.ReadLine(), out BB[i_y]);
            }
            Console.WriteLine($"enter {n_y * (m_y - 1)} elements for A");
            for (i_y = 0; i_y < n_y; i_y++)
            {
                for (j_y = 0; j_y < m_y - 1; j_y++)
                {
                    double.TryParse(Console.ReadLine(), out A[i_y, j_y]);
                }
            }
            Console.WriteLine("array B: ");
            for (i_y = 0; i_y < n_y; i_y++)
            {
                Console.Write($"{BB[i_y]} ");
            }
            Console.WriteLine();
            Console.WriteLine("array A: ");
            for (i_y = 0; i_y < n_y; i_y++)
            {
                for (j_y = 0; j_y < m_y - 1; j_y++)
                {
                    Console.Write($"{A[i_y, j_y]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            min_y = A[p_y - 1, 0];
            jmin_y = 0;
            for (j_y = 0; j_y < m_y - 1; j_y++)
            {
                if (A[p_y - 1, j_y] < min_y)
                {
                    min_y = A[p_y - 1, j_y];
                    jmin_y = j_y;
                }
            }
            for (i_y = 0; i_y < n_y; i_y++)
            {
                for (j_y = m_y - 1; j_y > jmin_y + 1; j_y--)
                {
                    A[i_y, j_y] = A[i_y, j_y - 1];
                }
            }
            for (i_y = 0; i_y < n_y; i_y++)
            {
                A[i_y, jmin_y + 1] = BB[i_y];
            }
            Console.WriteLine($"new array: ");
            for (i_y = 0; i_y < n_y; i_y++)
            {
                for (j_y = 0; j_y < m_y; j_y++)
                {
                    Console.Write($"{A[i_y, j_y]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.2.7

            int i_u = 0, j_u = 0, n_u = 6, m_u = 6, imax_u;
            double max_u;
            double[,] A_u = new double[n_u, m_u];
            Console.WriteLine($"enter {n_u * m_u} elements");
            for (i_u = 0; i_u < n_u; i_u++)
            {
                for (j_u = 0; j_u < m_u; j_u++)
                {
                    double.TryParse(Console.ReadLine(), out A_u[i_u, j_u]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("array A: ");
            max_u = A_u[0, 0];
            imax_u = 0;
            for (i_u = 0; i_u < n_u; i_u++)
            {
                if (A_u[i_u, i_u] > max_u)
                {
                    max_u = A_u[i_u, i_u];
                    imax_u = i_u;
                }
                for (j_u = 0; j_u < m_u; j_u++)
                {
                    Console.Write($"{A_u[i_u, j_u]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i_u = 0; i_u < imax_u; i_u++)
            {
                for (j_u = i_u + 1; j_u < m_u; j_u++)
                {
                    A_u[i_u, j_u] = 0;
                }
            }
            Console.WriteLine($"new array: ");
            for (i_u = 0; i_u < n_u; i_u++)
            {
                for (j_u = 0; j_u < m_u; j_u++)
                {
                    Console.Write($"{A_u[i_u, j_u]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.2.8

            int i_i = 0, j_i = 0, n_i = 6, m_i = 6, jmax_1, jmax_2;
            double max_1, max_2;
            double[,] B_i = new double[n_i, m_i];
            Console.WriteLine($"enter {n_i * m_i} elements");
            for (i_i = 0; i_i < n_i; i_i++)
            {
                for (j_i = 0; j_i < m_i; j_i++)
                {
                    double.TryParse(Console.ReadLine(), out B_i[i_i, j_i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("array B: ");
            for (i_i = 0; i_i < n_i; i_i++)
            {
                for (j_i = 0; j_i < m_i; j_i++)
                {
                    Console.Write($"{B_i[i_i, j_i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i_i = 0; i_i < n_i - 1; i_i = i_i + 2)
            {
                max_1 = B_i[i_i, 0];
                jmax_1 = 0;
                max_2 = B_i[i_i + 1, 0];
                jmax_2 = 0;
                for (j_i = 1; j_i < m_i; j_i++)
                {
                    if (B_i[i_i, j_i] > max_1)
                    {
                        max_1 = B_i[i_i, j_i];
                        jmax_1 = j_i;
                    }
                    if (B_i[i_i + 1, j_i] > max_2)
                    {
                        max_2 = B_i[i_i + 1, j_i];
                        jmax_2 = j_i;
                    }
                }
                B_i[i_i, jmax_1] = max_2;
                B_i[i_i + 1, jmax_2] = max_1;
            }
            Console.WriteLine($"new array: ");
            for (i_i = 0; i_i < n_i; i_i++)
            {
                for (j_i = 0; j_i < m_i; j_i++)
                {
                    Console.Write($"{B_i[i_i, j_i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.2.9

            int i_o = 0, j_o = 0, n_o = 6, m_o = 7, k_o;
            double p_o;
            double[,] A_o = new double[n_o, m_o];
            Console.WriteLine($"enter {n_o * m_o} elements");
            for (i_o = 0; i_o < n_o; i_o++)
            {
                for (j_o = 0; j_o < m_o; j_o++)
                {
                    double.TryParse(Console.ReadLine(), out A_o[i_o, j_o]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("array A: ");
            for (i_o = 0; i_o < n_o; i_o++)
            {
                for (j_o = 0; j_o < m_o; j_o++)
                {
                    Console.Write($"{A_o[i_o, j_o]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            k_o = m_o / 2;
            if (m_o % 2 == 1)
            {
                k_o = (m_o - 1) / 2;
            }
            for (i_o = 0; i_o < n_o; i_o++)
            {
                for (j_o = 0; j_o < k_o; j_o++)
                {
                    p_o = A_o[i_o, j_o];
                    A_o[i_o, j_o] = A_o[i_o, m_o - 1 - j_o];
                    A_o[i_o, m_o - 1 - j_o] = p_o;
                }
            }
            Console.WriteLine($"new array: ");
            for (i_o = 0; i_o < n_o; i_o++)
            {
                for (j_o = 0; j_o < m_o; j_o++)
                {
                    Console.Write($"{A_o[i_o, j_o]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.3.1

            int i_p = 0, j_p = 0, n_p = 7, m_p = 5, imin_p;
            double min_p, p_p;
            double[,] A_p = new double[n_p, m_p];
            Console.WriteLine($"enter {n_p * m_p} elements");
            for (i_p = 0; i_p < n_p; i_p++)
            {
                for (j_p = 0; j_p < m_p; j_p++)
                {
                    double.TryParse(Console.ReadLine(), out A_p[i_p, j_p]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("array A: ");
            min_p = A_p[0, 0];
            imin_p = 0;
            for (i_p = 0; i_p < n_p; i_p++)
            {
                for (j_p = 0; j_p < m_p; j_p++)
                {
                    Console.Write($"{A_p[i_p, j_p]} ");
                    if (A_p[i_p, j_p] < min_p)
                    {
                        min_p = A_p[i_p, j_p];
                        imin_p = i_p;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i_p = n_p - 1; i_p > 0; i_p--)
            {
                for (j_p = m_p - 1; j_p >= 0; j_p--)
                {
                    p_p = A_p[i_p, j_p];
                    A_p[i_p, j_p] = A_p[imin_p, j_p];
                    A_p[imin_p, j_p] = p_p;
                }
                min_p = A_p[i_p - 1, 0];
                imin_p = i_p - 1;
                for (int k_p = i_p - 1; k_p >= 0; k_p--)
                {
                    for (int y_p = m_p - 1; y_p >= 0; y_p--)
                    {
                        if (A_p[k_p, y_p] < min_p)
                        {
                            min_p = A_p[k_p, y_p];
                            imin_p = k_p;
                        }
                    }
                }
            }
            Console.WriteLine($"new array: ");
            for (i_p = 0; i_p < n_p; i_p++)
            {
                for (j_p = 0; j_p < m_p; j_p++)
                {
                    Console.Write($"{A_p[i_p, j_p]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.3.2

            int i_l = 0, j_l = 0, n_l, m_l;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_l);
            while (n_l <= 0)
            {
                Console.WriteLine("n>0! try another n");
                int.TryParse(Console.ReadLine(), out n_l);
            }
            Console.WriteLine("enter m");
            int.TryParse(Console.ReadLine(), out m_l);
            while (m_l <= 0)
            {
                Console.WriteLine("m>0! try another m");
                int.TryParse(Console.ReadLine(), out m_l);
            }
            double[,] A_l = new double[n_l, m_l];
            Console.WriteLine($"enter {n_l * m_l} elements");
            for (i_l = 0; i_l < n_l; i_l++)
            {
                for (j_l = 0; j_l < m_l; j_l++)
                {
                    double.TryParse(Console.ReadLine(), out A_l[i_l, j_l]);
                }
            }
            Console.WriteLine("array: ");
            for (i_l = 0; i_l < n_l; i_l++)
            {
                for (j_l = 0; j_l < m_l; j_l++)
                {
                    Console.Write($"{A_l[i_l, j_l]} ");
                    if (i_l == 0 || i_l == n_l - 1 || j_l == 0 || j_l == m_l - 1)
                    {
                        A_l[i_l, j_l] = 0;
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"new array: ");
            for (i_l = 0; i_l < n_l; i_l++)
            {
                for (j_l = 0; j_l < m_l; j_l++)
                {
                    Console.Write($"{A_l[i_l, j_l]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.3.3

            int i_k = 0, j_k = 0, n_k, p_k, d_k;
            double s1_k = 0, s2_k = 0;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_k);
            while (n_k <= 0)
            {
                Console.WriteLine("n>0! try another n");
                int.TryParse(Console.ReadLine(), out n_k);
            }
            double[] AA_k = new double[2 * n_k - 1];
            double[,] A_k = new double[n_k, n_k];
            Console.WriteLine($"enter {n_k * n_k} elements");
            for (i_k = 0; i_k < n_k; i_k++)
            {
                for (j_k = 0; j_k < n_k; j_k++)
                {
                    double.TryParse(Console.ReadLine(), out A_k[i_k, j_k]);
                }
            }
            Console.WriteLine("array: ");
            for (i_k = 0; i_k < n_k; i_k++)
            {
                for (j_k = 0; j_k < n_k; j_k++)
                {
                    Console.Write($"{A_k[i_k, j_k]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            d_k = 0;
            for (i_k = n_k - 1; i_k > 0; i_k--)
            {
                p_k = i_k;
                for (j_k = 0; j_k < n_k - i_k; j_k++)
                {
                    s1_k = s1_k + A_k[j_k, p_k];
                    s2_k = s2_k + A_k[p_k, j_k];
                    p_k++;
                }
                AA_k[d_k] = s1_k;
                AA_k[n_k * 2 - 2 - d_k] = s2_k;
                s1_k = 0;
                s2_k = 0;
                d_k++;
            }
            for (i_k = 0; i_k < n_k; i_k++)
            {
                s1_k = s1_k + A_k[i_k, i_k];
            }
            AA_k[n_k - 1] = s1_k;
            Console.WriteLine($"vector AA: ");
            for (i_k = 0; i_k < n_k * 2 - 1; i_k++)
            {
                Console.Write($"{AA_k[i_k]} ");
            }
            Console.WriteLine();

            #endregion

            #region 4.3.4

            int i_j = 0, j_j = 0, n_j;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_j);
            while (n_j <= 0)
            {
                Console.WriteLine("n>0! try another n");
                int.TryParse(Console.ReadLine(), out n_j);
            }
            double[,] A_j = new double[n_j, n_j];
            Console.WriteLine($"enter {n_j * n_j} elements");
            for (i_j = 0; i_j < n_j; i_j++)
            {
                for (j_j = 0; j_j < n_j; j_j++)
                {
                    double.TryParse(Console.ReadLine(), out A_j[i_j, j_j]);
                }
            }
            Console.WriteLine("array: ");
            for (i_j = 0; i_j < n_j; i_j++)
            {
                for (j_j = 0; j_j < n_j; j_j++)
                {
                    Console.Write($"{A_j[i_j, j_j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i_j = n_j / 2; i_j < n_j; i_j++)
            {
                for (j_j = 0; j_j <= i_j; j_j++)
                {
                    A_j[i_j, j_j] = 0;
                }
            }
            Console.WriteLine($"new array: ");
            for (i_j = 0; i_j < n_j; i_j++)
            {
                for (j_j = 0; j_j < n_j; j_j++)
                {
                    Console.Write($"{A_j[i_j, j_j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.3.8

            int i_h = 0, j_h = 0, n_h = 7, m_h = 5, s_h = 0, maxs = 0, imaxs = 0, ii_h;
            double p_h;
            double[,] A_h = new double[n_h, m_h];
            Console.WriteLine($"enter {n_h * m_h} elements");
            for (i_h = 0; i_h < n_h; i_h++)
            {
                for (j_h = 0; j_h < m_h; j_h++)
                {
                    double.TryParse(Console.ReadLine(), out A_h[i_h, j_h]);
                }
            }
            Console.WriteLine("array: ");
            for (i_h = 0; i_h < n_h; i_h++)
            {
                s_h = 0;
                for (j_h = 0; j_h < m_h; j_h++)
                {
                    Console.Write($"{A_h[i_h, j_h]} ");
                    if (A_h[i_h, j_h] > 0)
                    {
                        s_h++;
                    }
                }
                Console.WriteLine();
                if (s_h > maxs)
                {
                    maxs = s_h;
                    imaxs = i_h;
                }
            }
            Console.WriteLine();
            for (i_h = 0; i_h < n_h - 1; i_h++)
            {
                for (j_h = 0; j_h < m_h; j_h++)
                {
                    p_h = A_h[i_h, j_h];
                    A_h[i_h, j_h] = A_h[imaxs, j_h];
                    A_h[imaxs, j_h] = p_h;
                }
                maxs = 0;
                for (ii_h = i_h + 1; ii_h < n_h; ii_h++)
                {
                    s_h = 0;

                    for (j_h = 0; j_h < m_h; j_h++)
                    {
                        if (A_h[ii_h, j_h] > 0)
                        {
                            s_h++;
                        }

                    }
                    if (s_h > maxs)
                    {
                        maxs = s_h;
                        imaxs = ii_h;
                    }
                }
            }
            Console.WriteLine($"new array: ");
            for (i_h = 0; i_h < n_h; i_h++)
            {
                for (j_h = 0; j_h < m_h; j_h++)
                {
                    Console.Write($"{A_h[i_h, j_h]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.3.10

            int i_g = 0, j_g = 0, jmax_g = 0, jj_g, jmin_g = 0;
            const int n_g = 5, m_g = 6;
            double[,] A_g = new double[n_g, m_g] { { 1, 4, 3, 2, 5, 6 },
                                                   { 1, 2, 3, 4, 0, -1 },
                                                   { 1, 2, 7, 3, -1, 8 },
                                                   { -2, 1, 3, -1, 2, 7 },
                                                   { 9, 2, 1, 3, 5, 7 } };
            double max_g = A_g[0, 0], p_g, min_g = A_g[0, 1];
            Console.WriteLine("array: ");
            for (i_g = 0; i_g < n_g; i_g++)
            {
                for (j_g = 0; j_g < m_g; j_g++)
                {
                    Console.Write($"{A_g[i_g, j_g]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (i_g = 0; i_g < n_g; i_g++)
            {
                for (j_g = 0; j_g < m_g; j_g = j_g + 2)
                {
                    if (A_g[i_g, j_g] > max_g)
                    {
                        max_g = A_g[i_g, j_g];
                        jmax_g = j_g;
                    }
                }
                for (j_g = 0; j_g < m_g - 2; j_g = j_g + 2)
                {
                    p_g = A_g[i_g, j_g];
                    A_g[i_g, j_g] = A_g[i_g, jmax_g];
                    A_g[i_g, jmax_g] = p_g;

                    max_g = A_g[i_g, j_g + 2];
                    jmax_g = j_g + 2;
                    for (jj_g = j_g + 2; jj_g < m_g; jj_g = jj_g + 2)
                    {
                        if (A_g[i_g, jj_g] > max_g)
                        {
                            max_g = A_g[i_g, jj_g];
                            jmax_g = jj_g;
                        }

                    }
                }



                for (j_g = 1; j_g < m_g; j_g = j_g + 2)
                {
                    if (A_g[i_g, j_g] < min_g)
                    {
                        min_g = A_g[i_g, j_g];
                        jmin_g = j_g;
                    }
                }
                for (j_g = 1; j_g < m_g - 2; j_g = j_g + 2)
                {
                    p_g = A_g[i_g, j_g];
                    A_g[i_g, j_g] = A_g[i_g, jmin_g];
                    A_g[i_g, jmin_g] = p_g;

                    min_g = A_g[i_g, j_g + 2];
                    jmin_g = j_g + 2;
                    for (jj_g = j_g + 2; jj_g < m_g; jj_g = jj_g + 2)
                    {
                        if (A_g[i_g, jj_g] < min_g)
                        {
                            min_g = A_g[i_g, jj_g];
                            jmin_g = jj_g;
                        }

                    }
                }
            }
            Console.WriteLine($"new array: ");
            for (i_g = 0; i_g < n_g; i_g++)
            {
                for (j_g = 0; j_g < m_g; j_g++)
                {
                    Console.Write($"{A_g[i_g, j_g]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 4.3.11

            int i_m = 0, j_m = 0, s_m = 0, len_m = 0;
            const int n_m = 5, m_m = 6;
            double[,] A_m = new double[n_m + 1, m_m] { { 4, 1, 1, 7,3,2 },
                                                     { 8, 0, 3, 4,0,9 },
                                                     { 1, 1, 7, 3,-1,7 },
                                                     { -2, 1, 0, 0,1,7 },
                                                     { 9, 1, 1, 1, 5, 7 },
                                                     { 0, 0, 0, 0, 0, 0 } };
            Console.WriteLine("array: ");
            for (i_m = 0; i_m < n_m; i_m++)
            {
                for (j_m = 0; j_m < m_m; j_m++)
                {
                    Console.Write($"{A_m[i_m, j_m]} ");
                    if (A_m[i_m, j_m] == 0)
                    {
                        s_m++;
                    }
                }
                Console.WriteLine();
                if (s_m == 0)
                {
                    len_m++;
                }
                s_m = 0;
            }
            Console.WriteLine();

            for (i_m = 0; i_m < n_m; i_m++)
            {
                for (j_m = 0; j_m < m_m; j_m++)
                {
                    if (A_m[i_m, j_m] == 0)
                    {
                        s_m++;
                        break;
                    }
                }
                if (s_m > 0)
                {
                    for (j_m = 0; j_m < m_m; j_m++)
                    {
                        A_m[i_m, j_m] = A_m[i_m + 1, j_m];
                    }
                    s_m = 0;
                    for (int ii_m = i_m + 1; ii_m < n_m; ii_m++)
                    {
                        for (j_m = 0; j_m < m_m; j_m++)
                        {
                            if (A_m[ii_m, j_m] == 0)
                            {
                                s_m++;
                                break;
                            }
                        }
                        if (s_m == 0)
                        {
                            for (j_m = 0; j_m < m_m; j_m++)
                            {
                                A_m[i_m, j_m] = A_m[ii_m, j_m];
                            }
                            for (int iii_m = ii_m; iii_m < n_m; iii_m++)
                            {
                                for (j_m = 0; j_m < m_m; j_m++)
                                {
                                    A_m[ii_m, j_m] = A_m[iii_m, j_m];
                                }
                            }
                            break;
                        }
                        s_m = 0;

                    }
                }
                s_m = 0;
            }
            Console.WriteLine($"new array: ");
            for (i_m = 0; i_m < len_m; i_m++)
            {
                for (j_m = 0; j_m < m_m; j_m++)
                {
                    Console.Write($"{A_m[i_m, j_m]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion
        }
    }
}
