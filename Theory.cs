using System;
namespace laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1_3
            int n = 4, s = 0;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                    if (i == j)
                    {
                        s += a[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Answer: {s}");
            #endregion

            #region Task 1_6
            int n = 0;
            int[,] a = new int[4, 7];
            int[] b = new int[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int min;
            for (int i = 0; i < 4; i++)
            {
                min = a[i, 0];
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                    if (min >= a[i, j])
                    {
                        min = a[i, j];
                        n = j;
                    }
                }
                Console.WriteLine();
                b[i] = n;
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{b[i]} ");
            }
            #endregion

            #region Task 1_12
            int y = 0, x = 0, n = 6, m = 7;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int max = a[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                    if (max <= a[i, j])
                    {
                        max = a[i, j];
                        y = i;
                        x = j;
                    }
                }
                Console.WriteLine();
            }
            for (int i = y; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = a[i + 1, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = x; j < m - 1; j++)
                {
                    a[i, j] = a[i, j + 1];
                }
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Task 1_13
            int x = 0, n = 5, fir = 4, sec = 0;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int max = a[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                    if (i == j & max < a[i, j])
                    {
                        max = a[i, j];
                        sec = j;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                x = a[i, sec];
                a[i, sec] = a[i, 4];
                a[i, 4] = x;
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Task 1_17
            int n = 3, m = 4, index = 0, x;
            int[,] b = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", b[i, j]);
                }
                Console.WriteLine();
            }
            int min = b[0, 0];
            for (int i = 0; i < n; i++)
            {
                min = b[i, 0];
                index = 0;
                for (int j = 0; j < m; j++)
                {
                    if (min > b[i, j])
                    {
                        min = b[i, j];
                        index = j;
                    }
                }
                for (int j = index; j > 0; j--)
                {
                    x = b[i, j - 1];
                    b[i, j - 1] = b[i, j];
                    b[i, j] = x;
                }
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", b[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Task 1_29
            int n = 5, m = 7, index = 0, x;
            int[,] f = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    f[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", f[i, j]);

                }
                Console.WriteLine();
            }
            int min = f[2, 0];
            for (int j = 0; j < m; j++)
            {
                if (Math.Abs(min) > Math.Abs(f[2, j]))
                {
                    min = f[2, j];
                    index = j;
                }
            }
            if (index == m - 1)
            {
                Console.WriteLine("Error");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = index; j < m - 1; j++)
                {
                    f[i, j] = f[i, j + 1];
                }
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write("{0,5:d} ", f[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Task 1_31
            int n = 5, m = 8, index = 0, x;
            int[,] a = new int[n, m];
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the missing elements separated by a space: ");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            for (int i = 0; i < n; i++)
            {
                int.TryParse(c[i], out b[i]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);

                }
                Console.WriteLine();
            }
            int min = a[4, 0];
            for (int j = 0; j < m - 1; j++)
            {
                if (min > a[4, j])
                {
                    min = a[4, j];
                    index = j;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = m - 1; j > index + 1; j--)
                {
                    a[i, j] = a[i, j - 1];
                }
                a[i, index + 1] = b[i];
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Task 2_7
            int n = 6, index = 0;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);

                }
                Console.WriteLine();
            }
            int max = a[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == j) & (max < a[i, j]))
                    {
                        max = a[i, j];
                        index = i;
                    }
                }
            }
            for (int i = 0; i < index - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    a[i, j] = 0;
                }
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Task 2_8
            int n = 6, index_f = 0, index_s = 0;
            int[,] b = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", b[i, j]);

                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i += 2)
            {
                int max_f = b[i, 0];
                int max_s = b[i + 1, 0];
                for (int j = 0; j < n; j++)
                {
                    if (max_f < b[i, j])
                    {
                        max_f = b[i, j];
                        index_f = j;
                    }
                    if (max_s < b[i + 1, j])
                    {
                        max_s = b[i + 1, j];
                        index_s = j;
                    }
                }
                b[i, index_f] = max_s;
                b[i + 1, index_s] = max_f;
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", b[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Task 2_9
            int n = 6, m = 7, x;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);

                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= m / 2; j++)
                {
                    x = a[i, j];
                    a[i, j] = a[i, m - 1 - j];
                    a[i, m - 1 - j] = x;
                }
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Task 3_1
            int n = 7, m = 5, x;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n - 1; i++)
            {
                int min_f = a[i, 0];
                int min_s = a[i + 1, 0];
                for (int j = 0; j < m; j++)
                {
                    if (min_f > a[i, j])
                    {
                        min_f = a[i, j];
                    }
                    if (min_s > a[i + 1, j])
                    {
                        min_s = a[i + 1, j];
                    }
                }
                if (min_f == min_s)
                {
                    Console.WriteLine("Error");
                    return;
                }
                if (min_f < min_s)
                {
                    for (int j = 0; j < m; j++)
                    {
                        x = a[i, j];
                        a[i, j] = a[i + 1, j];
                        a[i + 1, j] = x;
                    }
                    i = -1;
                }
            }
            Console.WriteLine("The answer is output as a matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The answer is output as a one-dimensional sequence: ");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i, j]} ");
                }
            }
            #endregion

            #region Task 3_2
            int n;
            Console.WriteLine("Enter the size of the square matrix: ");
            string vvod = Console.ReadLine();
            if (int.TryParse(vvod, out n) & n > 0)
            {
                int.TryParse(vvod, out n);
            }
            else
            {
                Console.WriteLine("Enter an integer");
                return;
            }
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                a[0, i] = 0;
                a[n - 1, i] = 0;
                a[i, 0] = 0;
                a[i, n - 1] = 0;
            }
            Console.WriteLine("The answer is output as a matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The answer is output as a one-dimensional sequence: ");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i, j]} ");
                }
            }
            #endregion

            #region Task 3_3
            int n, sum_left = 0, sum_right = 0, x;
            Console.WriteLine("Enter the size of the square matrix: ");
            string vvod = Console.ReadLine();
            if (int.TryParse(vvod, out n) & n > 1)
            {
                int.TryParse(vvod, out n);
            }
            else
            {
                Console.WriteLine("Enter an integer > 1");
                return;
            }
            int[] b = new int[2 * n - 1];
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            x = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                int y = n - 1;
                for (int j = i; j >= 0; j--)
                {
                    sum_left += a[y, j];
                    y--;
                }
                b[x] = sum_left;
                sum_left = 0;
                x += 1;
            }
            for (int i = 1; i <= n - 1; i++)
            {
                int y = 0;
                for (int j = i; j <= n - 1; j++)
                {
                    sum_right += a[y, j];
                    y++;
                }
                b[x] = sum_right;
                sum_right = 0;
                x += 1;
            }
            Console.WriteLine("Answer: ");
            for (int j = 0; j < 2 * n - 1; j++)
            {
                Console.Write($"{b[j]} ");
            }
            #endregion

            #region Task 3_4
            int n, x;
            Console.WriteLine("Enter the size of the square matrix: ");
            string vvod = Console.ReadLine();
            if (int.TryParse(vvod, out n) & n > 1)
            {
                int.TryParse(vvod, out n);
            }
            else
            {
                Console.WriteLine("Enter an integer > 1");
                return;
            }
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            x = n - 1;
            for (int i = n - 1; i >= n / 2; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    a[x, j] = 1;
                }
                x--;
            }
            Console.WriteLine("The answer is output as a matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The answer is output as a one-dimensional sequence: ");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i, j]} ");
                }
            }
            #endregion

            #region Task 3_8
            int n = 7, m = 5, sum_f = 0, sum_s = 0, x;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > 0)
                    {
                        sum_f += 1;
                    }
                    if (a[i + 1, j] > 0)
                    {
                        sum_s += 1;
                    }
                }
                if (sum_f < sum_s)
                {
                    for (int j = 0; j < m; j++)
                    {
                        x = a[i, j];
                        a[i, j] = a[i + 1, j];
                        a[i + 1, j] = x;
                    }
                    i = -1;
                }
                sum_s = 0;
                sum_f = 0;
            }
            Console.WriteLine("The answer is output as a matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The answer is output as a one-dimensional sequence: ");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i, j]} ");
                }
            }
            #endregion

            #region Task 3_10
            int n, m, x;
            Console.WriteLine("Enter the size n of the matrix: ");
            string vvod1 = Console.ReadLine();
            if (int.TryParse(vvod1, out n) & n > 1)
            {
                int.TryParse(vvod1, out n);
            }
            else
            {
                Console.WriteLine("Enter an integer > 1");
                return;
            }
            Console.WriteLine("Enter the size m of the matrix: ");
            string vvod2 = Console.ReadLine();
            if (int.TryParse(vvod2, out m) & m > 1)
            {
                int.TryParse(vvod2, out m);
            }
            else
            {
                Console.WriteLine("Enter an integer > 1");
                return;
            }
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    if ((j % 2 == 0 & a[i, j] < a[i, j + 2]) || (j % 2 != 0 & a[i, j] > a[i, j + 2]))
                    {
                        x = a[i, j];
                        a[i, j] = a[i, j + 2];
                        a[i, j + 2] = x;
                        j = -1;
                    }
                }
            }
            Console.WriteLine("The answer is output as a matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The answer is output as a one-dimensional sequence: ");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i, j]} ");
                }
            }
            #endregion

            #region Task 3_11
            int n, m, index = 0;
            Console.WriteLine("Enter the size n of the matrix: ");
            string vvod1 = Console.ReadLine();
            if (int.TryParse(vvod1, out n) & n > 1)
            {
                int.TryParse(vvod1, out n);
            }
            else
            {
                Console.WriteLine("Enter an integer > 1");
                return;
            }
            Console.WriteLine("Enter the size m of the matrix: ");
            string vvod2 = Console.ReadLine();
            if (int.TryParse(vvod2, out m) & m > 1)
            {
                int.TryParse(vvod2, out m);
            }
            else
            {
                Console.WriteLine("Enter an integer > 1");
                return;
            }
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the element y: " + i + " x: " + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] == 0)
                    {
                        index += 1;
                        for (int k = i; k < n - 1; k++)
                        {
                            for (int s = 0; s < m; s++)
                            {
                                a[k, s] = a[k + 1, s];
                            }
                        }
                        i = -1;
                        n -= 1;
                        break;
                    }
                }
            }
            if (index == 0)
            {
                Console.WriteLine("There are no zero rows");
                return;
            }
            Console.WriteLine("The answer is output as a matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The answer is output as a one-dimensional sequence: ");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i, j]} ");
                }
            }
            #endregion
        }
    }
}
