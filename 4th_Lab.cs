using System;
using System.Collections.Generic;
using System.Linq;

namespace _4th_Lab
{
    class Program
    {
        static int exercise_3_1((int, double) a, (int, double) b)
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

        static int exercise_3_8((int, int) a, (int, int) b)
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

            #region level 1
            Console.WriteLine("level 1");

            #region task 3
            Console.WriteLine("task 3");
            {
                int n = 4, m = 4;
                double[,] A = new double[n, m];
                double ans = 0;

                Console.WriteLine($"    enter {n} rows {m} columns");

                for (int i = 0; i < n; i++)
                {
                    string[] row_string = Console.ReadLine().Split(" ");

                    if (row_string.Count() != m)
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    List<double> row = new List<double>();

                    foreach (string elem in row_string)
                    {
                        double value;
                        if (!double.TryParse(elem, out value))
                        {
                            Console.WriteLine("     incorrect format");
                            return;
                        }
                        row.Add(value);
                    }

                    for (int j = 0; j < m; j++)
                    {
                        double el = row[j];

                        A[i, j] = el;
                    }

                    ans += A[i, i];
                }

                Console.WriteLine($"    answer: {ans.ToString()}");
            }
            #endregion

            #region task 6
            Console.WriteLine("task 6");
            {
                int n = 4, m = 7;
                double[,] A = new double[n, m];
                double[] ans = new double[n];

                Console.WriteLine($"    enter {n} rows {m} columns");

                for (int i = 0; i < n; i++)
                {
                    string[] row_string = Console.ReadLine().Split(" ");

                    if (row_string.Count() != m)
                    {
                        Console.WriteLine("     incorrect format");
                        return;
                    }

                    double[] row = new double[m];

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
                        row[j] = value;

                    }

                    int min_idx = Array.IndexOf(row, row.Min());

                    ans[i] = min_idx;
                }

                Console.WriteLine($"    answer: {ans.ToString()}");
            }
            #endregion

            #region task 12
            Console.WriteLine("task 12");
            {
                int n = 6, m = 7;
                double[,] A = new double[n, m];
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

                        A[i, j] = value;
                        if (value > A[i_max, j_max])
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
                        ans[i, j] = A[ans_i, ans_j];
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

            #region task 13
            Console.WriteLine("task 13");
            {
                int n = 5, m = 5;
                int column_max = 0;
                double[,] A = new double[n, m];

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

                        A[i, j] = value;
                    }

                    if (A[i, i] > A[column_max, column_max])
                    {
                        column_max = i;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    (A[i, 4], A[i, column_max]) = (A[i, column_max], A[i, 4]);
                }

                for (int i = 0; i < n; i++)
                {
                    string answer = "";
                    for (int j = 0; j < m; j++)
                    {
                        answer += A[i, j].ToString();
                        answer += " ";
                    }
                    Console.WriteLine(answer);
                }
            }
            #endregion

            #region task 17
            Console.WriteLine("task 17");
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

                double[,] A = new double[n, m];

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

                        A[i, j] = value;
                        if (value < A[i, min_column])
                        {
                            min_column = j;
                        }
                    }

                    while (min_column != 0)
                    {
                        (A[i, min_column], A[i, min_column - 1]) = (A[i, min_column - 1], A[i, min_column]);
                        min_column--;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    string answer = "";
                    for (int j = 0; j < m; j++)
                    {
                        answer += A[i, j].ToString();
                        answer += " ";
                    }
                    Console.WriteLine(answer);
                }

            }
            #endregion

            #region task 29
            Console.WriteLine("task 29");
            {
                int n = 5, m = 7;
                double[,] A = new double[n, m];
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

                        A[i, j] = value;
                    }
                }

                int j_min = 0;
                for (int j = 0; j < m; j++)
                {
                    if (Math.Abs(A[row_idx, j]) < Math.Abs(A[row_idx, j_min]))
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
                            ans[i, j] = A[i, ans_j];
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

            #region task 31
            Console.WriteLine("task 31");
            {
                int row_idx = 4, n = 5, m = 7;
                double[,] A = new double[n, m];
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

                        A[i, j] = value;
                    }
                }

                for (int j = 0; j < m; j++)
                {
                    if (A[row_idx, j] < A[row_idx, j_min])
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
                        ans[i, j] = A[i, ans_j];
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

            #endregion

            #region level 2
            Console.WriteLine("level 2");

            #region task 7
            Console.WriteLine("task 7");
            {
                int n = 6, m = 6;
                double[,] A = new double[n, m];
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

                        A[i, j] = value;
                    }

                    if (A[i, i] > A[ii, ii])
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
                            A[i, j] = 0;
                        }
                    }
                }


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
            #endregion

            #region task 8
            Console.WriteLine("task 8");
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

            #region task 9
            Console.WriteLine("task 9");
            {
                int n = 6, m = 7;
                double[,] A = new double[n, m];


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

                        A[i, m - j - 1] = value;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    string line = "";
                    for (int j = 0; j < m - 1; j++)
                    {
                        line += A[i, j];
                        line += " ";
                    }
                    Console.WriteLine(line);
                }
            }
            #endregion

            #endregion

            #region level 3
            Console.WriteLine("level 3");

            #region task 1
            Console.WriteLine("task 1");
            {
                int n = 7, m = 5;
                double[,] A = new double[n, m], B = new double[n, m];
                List<(int, double)> a = new List<(int, double)>();

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

                        A[i, j] = value;

                        if (value < A[i, j_min])
                        {
                            j_min = j;
                        }
                    }
                    a.Add((i, A[i, j_min]));
                }
                a.Sort(exercise_3_1);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        B[i, j] = A[a[i].Item1, j];
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

            #region task 2
            Console.WriteLine("task 2");
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

                double[,] A = new double[n, n];

                for (int i = 0; i < n; i++)
                {
                    (A[i, 0], A[0, i]) = (0, 0);
                    (A[n - 1, i], A[i, n - 1]) = (0, 0);
                }

                for (int i = 0; i < n; i++)
                {
                    string line = "";
                    for (int j = 0; j < n; j++)
                    {
                        line += A[i, j];
                        line += " ";
                    }
                    Console.WriteLine(line);
                }
            }
            #endregion

            #region task 3
            Console.WriteLine("task 3");
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

                double[,] A = new double[n, n];
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

                        A[i, j] = value;
                    }
                }

                for (int i = n - 1; i > -1; i--)
                {
                    double sum = 0;
                    for (int j = 0; j < n - i; j++)
                    {
                        sum += A[i + j, j];
                    }
                    vector.Add(sum);
                }

                for (int j = 1; j < n; j++)
                {
                    double sum = 0;
                    for (int i = 0; i < n - j; i++)
                    {
                        sum += A[i, i + j];
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

            #region task 4
            Console.WriteLine("task 4");
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

                double[,] A = new double[n, n];

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

                        A[i, j] = value;
                    }
                }

                for (int i = n / 2; i < n; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        A[i, j] = 1;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    string line = "";
                    for (int j = 0; j < n; j++)
                    {
                        line += A[i, j].ToString();
                        line += " ";
                    }
                    Console.WriteLine(line);
                }
            }
            #endregion

            #region task 8
            Console.WriteLine("task 8");
            {
                int n = 7, m = 5;
                double[,] A = new double[n, m], B = new double[n, m];
                List<(int, int)> a = new List<(int, int)>();

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

                        A[i, j] = value;

                        if (value > 0)
                        {
                            counter++;
                        }
                    }
                    a.Add((i, counter));
                }
                a.Sort(exercise_3_8);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        B[i, j] = A[a[i].Item1, j];
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

            #region task 10
            Console.WriteLine("task 10");
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

                double[,] A = new double[n, m];

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

                        A[i, j] = value;
                    }
                }

                for (int j = 0; j < m; j++)
                {
                    List<double> even = new List<double>(), odd = new List<double>();
                    for (int i = 0; i < n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            even.Add(A[i, j]);
                        }
                        else
                        {
                            odd.Add(A[i, j]);
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
                            A[i, j] = even[idx_even];
                            idx_even++;
                        }
                        else
                        {
                            A[i, j] = odd[idx_odd];
                            idx_odd++;
                        }
                    }
                }

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
            #endregion

            #region task 11
            Console.WriteLine("task 11");
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
                double[,] A = new double[n, m];
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

                        A[i, j] = value;
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
            #endregion

            #endregion
        }
    }
}
