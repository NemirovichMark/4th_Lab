class Program
{
    static int ex3_1((int, double) a, (int, double) b)
    {
        if (a.Item2 < b.Item2)
        {
            return 1;
        }

        if (a.Item2 > b.Item2)
        {
            return -1;
        }
        return 0;
    }

    static int ex3_8((int, int) a, (int, int) b)
    {
        if (a.Item2 < b.Item2)
        {
            return 1;
        }

        if (a.Item2 > b.Item2)
        {
            return -1;
        }
        return 0;
    }

    static void Main(string[] args)
    {
        #region 1_3
        Console.WriteLine("1_3");
        int[,] A = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };
        int l = 0;
        int Sum = 0;
        for (int i = 0; i < 4; i++)
        {
            Sum = Sum + A[i, l];
            l++;
        }
        Console.WriteLine(Sum);
        #endregion
        #region 1_6
        Console.WriteLine("1_6");
        int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 }, { 5, 6, 2, 8 }, { 4, 1, 7, 8 }, { 9, 4, 2, 1 } };
        int[] b = new int[7];

        for (int i = 0; i < 7; i++)
        {
            int min = int.MaxValue;
            int index = 0;
            for (int j = 0; j < 4; j++)
            {
                if (a[i, j] < min)
                {
                    min = a[i, j];
                    index = j;
                }
            }

            b[i] = index;
        }
        for (int k = 0; k < 7; k++)
            Console.WriteLine("{0:d}", b[k]);
        Console.WriteLine();
        #endregion
        #region 1_12
        Console.WriteLine("1_12");
        {
            int n = 6, m = 7;
            double[,] A1 = new double[n, m];
            double[,] ans = new double[n - 1, m - 1];
            int i_max = 0, j_max = 0;

            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A1[i, j] = value;
                    if (value > A1[i_max, j_max])
                    {
                        i_max = i;
                        j_max = j;
                    }
                }
            }

            int ans_i = 0, ans_j = 0;
            for (int i = 0; i < n - 1; ++i)
            {
                if (ans_i == i_max)
                {
                    ans_i++;
                }
                ans_j = 0;
                for (int j = 0; j < m - 1; ++j)
                {
                    if (ans_j == j_max)
                    {
                        ans_j++;
                    }
                    ans[i, j] = A1[ans_i, ans_j];
                    ans_j++;
                }
                ans_i++;
            }

            for (int i = 0; i < n - 1; i++)
            {
                string answer = "";
                for (int j = 0; j < m - 1; j++)
                {
                    answer += ans[i, j].ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }
        }
        #endregion

        #region 1_13
        Console.WriteLine("1_13");
        {
            int n = 5, m = 5;
            int column_max = 0;
            double[,] A2 = new double[n, m];

            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A2[i, j] = value;
                }

                if (A2[i, i] > A2[column_max, column_max])
                {
                    column_max = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                (A2[i, 4], A2[i, column_max]) = (A2[i, column_max], A2[i, 4]);
            }

            for (int i = 0; i < n; i++)
            {
                string answer = "";
                for (int j = 0; j < m; j++)
                {
                    answer += A2[i, j].ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }
        }
        #endregion

        #region 1_17
        Console.WriteLine("1_17");
        {
            int n, m;

            Console.WriteLine("enter n");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 1)
                {
                    Console.WriteLine("incorrect format, try again");
                    continue;
                }
                break;
            }

            Console.WriteLine("enter m");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out m) || m <= 1)
                {
                    Console.WriteLine("incorrect format, try again");
                    continue;
                }
                break;
            }

            double[,] A3 = new double[n, m];

            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() < m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1, min_column = 0;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A3[i, j] = value;
                    if (value < A3[i, min_column])
                    {
                        min_column = j;
                    }
                }

                while (min_column != 0)
                {
                    (A3[i, min_column], A3[i, min_column - 1]) = (A3[i, min_column - 1], A3[i, min_column]);
                    min_column--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                string answer = "";
                for (int j = 0; j < m; j++)
                {
                    answer += A3[i, j].ToString();
                    answer += " ";
                }
                Console.WriteLine(answer);
            }

        }
        #endregion

        #region 1_29
        Console.WriteLine("1_29");
        {
            int n = 5, m = 7;
            double[,] A4 = new double[n, m];
            double[,] ans = new double[n, m - 1];
            int row_idx = 1;

            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1, min_column = 0;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A4[i, j] = value;
                }
            }

            int j_min = 0;
            for (int j = 0; j < m; j++)
            {
                if (Math.Abs(A4[row_idx, j]) < Math.Abs(A4[row_idx, j_min]))
                {
                    j_min = j;
                }
            }

            if (j_min == m - 1)
            {
                for (int i = 0; i < n; i++)
                {
                    string line = "";
                    for (int j = 0; j < m; j++)
                    {
                        line += A[i, j];
                        line += " ";
                    }
                    Console.WriteLine(line);
                }
            }
            else
            {
                j_min++;
                int ans_j = 0;

                for (int i = 0; i < n; i++)
                {
                    ans_j = 0;
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (ans_j == j_min)
                        {
                            ans_j++;
                        }
                        ans[i, j] = A4[i, ans_j];
                        ans_j++;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    string line = "";
                    for (int j = 0; j < m - 1; j++)
                    {
                        line += ans[i, j];
                        line += " ";
                    }
                    Console.WriteLine(line);
                }
            }
        }
        #endregion

        #region 1_31
        Console.WriteLine("1_31");
        {
            int row_idx = 4, n = 5, m = 7;
            double[,] A5 = new double[n, m];
            double[,] ans = new double[n, m + 1];
            int j_min = 0;

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() < m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A5[i, j] = value;
                }
            }

            for (int j = 0; j < m; j++)
            {
                if (A5[row_idx, j] < A5[row_idx, j_min])
                {
                    j_min = j;
                }
            }

            Console.WriteLine($"    enter {n} values in a row");

            double[] B = new double[n];
            int iter = 0;

            string[] row_b = Console.ReadLine().Split(" ");
            foreach (string elem in row_b)
            {
                double value;
                if (!double.TryParse(elem, out value))
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }
                B[iter] = value;
                iter++;
            }

            int ans_j = 0;
            j_min++;

            for (int i = 0; i < n; i++)
            {
                ans_j = 0;
                for (int j = 0; j < m + 1; ++j)
                {
                    if (j == j_min)
                    {
                        ans[i, j] = B[i];
                        continue;
                    }
                    ans[i, j] = A5[i, ans_j];
                    ans_j++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < m - 1; j++)
                {
                    line += ans[i, j];
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion
        #region 2_7
        Console.WriteLine("2_7");
        {
            int n = 6, m = 6;
            double[,] A6 = new double[n, m];
            int ii = 0;

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A6[i, j] = value;
                }

                if (A6[i, i] > A6[ii, ii])
                {
                    ii = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (i < ii)
                    {
                        A6[i, j] = 0;
                    }
                }
            }


            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < m; j++)
                {
                    line += A6[i, j];
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion

        #region 2_8
        Console.WriteLine("2_8");
        {
            int n = 6, m = 6;
            double[,] B = new double[n, m];
            int[] max_elems = new int[n];

            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                int j_max = 0;
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    B[i, j] = value;

                    if (value > B[i, j_max])
                    {
                        j_max = j;
                    }
                }
                max_elems[i] = j_max;
            }

            for (int i = 0; i < n; i += 2)
            {
                (B[i + 1, max_elems[i + 1]], B[i, max_elems[i]]) = (B[i, max_elems[i]], B[i + 1, max_elems[i + 1]]);
            }


            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < m - 1; j++)
                {
                    line += B[i, j];
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion

        #region 2_9
        Console.WriteLine("2_9");
        {
            int n = 6, m = 7;
            double[,] A7 = new double[n, m];


            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A7[i, m - j - 1] = value;
                }
            }

            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < m - 1; j++)
                {
                    line += A7[i, j];
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion
        #region 3_1
        Console.WriteLine("3_1");
        {
            int n = 7, m = 5;
            double[,] A8 = new double[n, m], B = new double[n, m];
            List<(int, double)> a1 = new List<(int, double)>();

            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j_min = 0;

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A8[i, j] = value;

                    if (value < A[i, j_min])
                    {
                        j_min = j;
                    }
                }
                a1.Add((i, A8[i, j_min]));
            }
            a1.Sort(ex3_1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    B[i, j] = A[a1[i].Item1, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < m; j++)
                {
                    line += B[i, j];
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion

        #region 3_2
        Console.WriteLine("3_2");
        {
            int n;

            Console.WriteLine("     enter n");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("     incorrect format, try again");
                    continue;
                }
                break;
            }

            double[,] A9 = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                (A9[i, 0], A9[0, i]) = (0, 0);
                (A9[n - 1, i], A9[i, n - 1]) = (0, 0);
            }

            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < n; j++)
                {
                    line += A9[i, j];
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion

        #region 3_3
        Console.WriteLine("3_3");
        {
            int n;

            Console.WriteLine("     enter n");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("     incorrect format, try again");
                    continue;
                }
                break;
            }

            double[,] A0 = new double[n, n];
            List<double> vector = new List<double>(2 * n - 1);

            Console.WriteLine($"    enter {n} rows {n} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != n)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A0[i, j] = value;
                }
            }

            for (int i = n - 1; i > -1; i--)
            {
                double sum = 0;
                for (int j = 0; j < n - i; j++)
                {
                    sum += A0[i + j, j];
                }
                vector.Add(sum);
            }

            for (int j = 1; j < n; j++)
            {
                double sum = 0;
                for (int i = 0; i < n - j; i++)
                {
                    sum += A0[i, i + j];
                }
                vector.Add(sum);
            }

            string answer = "   answer: ";

            foreach (double elem in vector)
            {
                answer += elem.ToString();
                answer += " ";
            }
            Console.WriteLine(answer);
        }
        #endregion

        #region 3_4
        Console.WriteLine("3_4");
        {
            int n;

            Console.WriteLine("     enter n");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("     incorrect format, try again");
                    continue;
                }
                break;
            }

            double[,] A11 = new double[n, n];

            Console.WriteLine($"    enter {n} rows {n} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != n)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A11[i, j] = value;
                }
            }

            for (int i = n / 2; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    A11[i, j] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < n; j++)
                {
                    line += A11[i, j].ToString();
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion

        #region 3_8
        Console.WriteLine("3_8");
        {
            int n = 7, m = 5;
            double[,] A22 = new double[n, m], B = new double[n, m];
            List<(int, int)> a2 = new List<(int, int)>();

            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int counter = 0;

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A22[i, j] = value;

                    if (value > 0)
                    {
                        counter++;
                    }
                }
                a2.Add((i, counter));
            }
            a2.Sort(ex3_8);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    B[i, j] = A22[a2[i].Item1, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < m; j++)
                {
                    line += B[i, j];
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion

        #region 3_10
        Console.WriteLine("3_10");
        {
            int n;

            Console.WriteLine("     enter n");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("     incorrect format, try again");
                    continue;
                }
                break;
            }

            int m;

            Console.WriteLine("     enter m");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
                {
                    Console.WriteLine("     incorrect format, try again");
                    continue;
                }
                break;
            }

            double[,] A33 = new double[n, m];

            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A33[i, j] = value;
                }
            }

            for (int j = 0; j < m; j++)
            {
                List<double> even = new List<double>(), odd = new List<double>();
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        even.Add(A33[i, j]);
                    }
                    else
                    {
                        odd.Add(A33[i, j]);
                    }
                }

                even.Sort();
                even.Reverse();
                odd.Sort();

                int idx_even = 0, idx_odd = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        A33[i, j] = even[idx_even];
                        idx_even++;
                    }
                    else
                    {
                        A33[i, j] = odd[idx_odd];
                        idx_odd++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < m; j++)
                {
                    line += A33[i, j];
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion

        #region 3_11
        Console.WriteLine("3_11");
        {
            int n;

            Console.WriteLine("     enter n");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("     incorrect format, try again");
                    continue;
                }
                break;
            }

            int m;

            Console.WriteLine("     enter m");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
                {
                    Console.WriteLine("     incorrect format, try again");
                    continue;
                }
                break;
            }
            double[,] A44 = new double[n, m];
            int counter = 0;
            Dictionary<int, bool> cache = new Dictionary<int, bool>();

            Console.WriteLine($"    enter {n} rows {m} columns");

            for (int i = 0; i < n; i++)
            {
                bool flag = false;

                string[] row_string = Console.ReadLine().Split(" ");

                if (row_string.Count() != m)
                {
                    Console.WriteLine("     incorrect format");
                    return;
                }

                int j = -1;
                foreach (string elem in row_string)
                {
                    double value;
                    if (!double.TryParse(elem, out value))
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }
                    j++;

                    A44[i, j] = value;
                    if (value == 0)
                    {
                        flag = true;
                    }
                }

                if (flag)
                {
                    counter++;
                    cache[i] = true;
                }
            }

            double[,] B = new double[n - counter, m];
            int ans_i = 0;

            for (int i = 0; i < n; i++)
            {
                if (cache.ContainsKey(i))
                {
                    continue;
                }
                for (int j = 0; j < m; j++)
                {
                    B[ans_i, j] = A[i, j];
                }
                ans_i++;
            }

            for (int i = 0; i < n - counter; i++)
            {
                string line = "";
                for (int j = 0; j < m; j++)
                {
                    line += B[i, j];
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }
    }
}
#endregion
