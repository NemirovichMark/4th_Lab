using System;
namespace laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
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
            int min = f[1, 0];
            for (int j = 0; j < m; j++)
            {
                if (Math.Abs(min) > Math.Abs(f[1, j]))
                {
                    min = f[1, j];
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
                for (int j = index + 1; j < m - 1; j++)
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
            
            #region Task 3_11
            int n, m, index_i = 0, x = 0, index_j = 0;
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
            int[] p = new int[n];
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
                        p[i] = -1;
                        index_i += 1;
                        break;
                    }
                }
            }
            if (index_i == 0)
            {
                Console.WriteLine("There are no zero rows");
                return;
            }
            if (index_i == n)
            {
                Console.WriteLine("All lines contain zero");
                return;
            }
            int[,] b = new int[n - index_i, m];
            for (int i = 0; i < n; i++)
            {
                if (p[i] != -1)
                {
                    for (int j = 0; j < m; j++)
                    {
                        b[x, j] = a[i, j];
                    }
                    x++;
                }

            }
            Console.WriteLine("The answer is output as a matrix: ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5:d} ", b[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The answer is output as a one-dimensional sequence: ");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write($"{b[i, j]} ");
                }
            }
            #endregion
        }
    }
}
