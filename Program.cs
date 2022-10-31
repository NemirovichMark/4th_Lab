using System;

namespace _4th_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task3
            {
                int y = 4, x = 4;
                double[,] a = new double[x, y];
                double s = 0;
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.WriteLine($"Enter y: {i} x: {j}");
                        double el;
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < x; i++)
                {
                    s += a[i, i];
                    Console.WriteLine(a[i, i]);
                    Console.WriteLine();
                }
                Console.WriteLine(s);
            }
            #endregion
            #region Task6
            {
                int x = 7, y = 4;
                double[,] a = new double[4, 7];
                int[] index= new int[4];
                for(int i=0;i<y;i++)
                {
                    for(int j=0;j<x;j++)
                    {
                        Console.WriteLine($"Enter y: {i} , x: {j} ");
                        double el;
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for(int i=0;i<y;i++)
                {
                    int mnind = 0;
                    double mn = a[i,0] ;
                    for(int j=0;j<x;j++)
                    {
                        if (a[i,j]<mn)
                        {
                            mn = a[i, j];
                            mnind = j;
                        }
                    }
                    index[i] = mnind;
                }
                foreach (int l in index)
                    Console.Write("{0:} ", l);
                Console.WriteLine();
            }
            #endregion
            #region Task 12
            {
                int x = 7, y = 6;
                double[,] a = new double[y, x];
                int m = x - 1, n = y - 1;
                double[,] b = new double[n, m];
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.WriteLine($"Enter y: {i} x: {j} ");
                        double el;
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + " \t");
                    }
                    Console.WriteLine();
                }
                int ymx = 0;
                int xmx = 0;
                double mx = a[0, 0];
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        if (a[i, j] > mx)
                        {
                            mx = a[i, j];
                            ymx = i;
                            xmx = j;
                        }
                    }
                }
                y -= 1;
                for (int i = ymx; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        a[i, j] = a[i + 1, j];
                    }
                }
                x -= 1;
                for (int i = 0; i < y; i++)
                {
                    for (int j = xmx; j < x; j++)
                        a[i, j] = a[i, j + 1];
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        b[i, j] = a[i, j];
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region Task13
            {
                int x = 5, y = 5;
                double[,] a = new double[y, x];
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.WriteLine($"Enter y: {i} x: {j} ");
                        double el;
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                int k = 3;
                double p = 0;
                int xmx = 0;
                double mx = a[0, 0];
                for (int i = 0; i < y; i++)
                {
                    if (a[i, i] > mx)
                    {
                        mx = a[i, i];
                        xmx = i;
                    }
                }
                for (int j = 0; j < x; j++)
                {
                    p = a[j, k]; a[j, k] = a[j, xmx]; a[j, xmx] = p;
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region Task17
            {
                int m, n;
                Console.WriteLine("Enter n");
                int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("Enter m");
                int.TryParse(Console.ReadLine(), out m);
                double[,] b = new double[n, m];
                int[] index = new int[n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y {j} : x {i} : ");
                        double.TryParse(Console.ReadLine(), out el);
                        b[i, j] = el;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    double mn = b[i, 0];
                    int xmn = 0;
                    for (int j = 0; j < m; j++)
                    {
                        if (b[i, j] < mn)
                        {
                            xmn = j;
                            mn = b[i, j];
                        }
                    }
                    index[i] = xmn;
                }
                foreach (int x in index)
                    Console.Write("{0:} ", x);
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    double p = b[i, index[i]];
                    for (int j = index[i] - 1; j >= 0; j--)
                    {
                        b[i, j + 1] = b[i, j];
                    }
                    b[i, 0] = p;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region Task 29
            {
                int y = 5, x = 7;
                double[,] f = new double[5, 7];
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y {i} : x {j} :");
                        double.TryParse(Console.ReadLine(), out el);
                        f[i, j] = el;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(f[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                double mn = Math.Abs(f[1, 0]);
                int xmn = 0;
                for (int j = 0; j < x; j++)
                {
                    if (Math.Abs(f[1, j]) < mn)
                    {
                        mn = f[1, j];
                        xmn = j;
                    }
                }
                Console.WriteLine(xmn);
                Console.WriteLine();
                x = x - 1;
                if (xmn < x)
                {
                    for (int j = xmn + 1; j < x; j++)
                    {
                        for (int i = 0; i < y; i++)
                        {
                            f[i, j] = f[i, j + 1];
                        }
                    }
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            Console.Write(f[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                else
                    Console.WriteLine("This element is the last");
            }
            #endregion
            #region Task 31
            {
                int y = 5, x = 8;
                double[,] a = new double[y, x];
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x - 1; j++)
                    {
                        Console.WriteLine($"Enter y {i}: x {j} : ");
                        double el;
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                int n = 5;
                double[] b = new double[n];
                for (int i = 0; i < n; i++)
                {
                    double el;
                    Console.WriteLine($"Enter {i} element");
                    double.TryParse(Console.ReadLine(), out el);
                    b[i] = el;
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                foreach (int cx in b)
                    Console.Write("{0:} ", cx);
                Console.WriteLine();
                double mn = a[4, 0];
                int xmn = 0;
                for (int j = 0; j < x - 1; j++)
                {
                    if (a[4, j] < mn)
                    {
                        mn = a[4, j];
                        xmn = j;
                    }
                }
                Console.WriteLine(xmn);
                if (xmn < x - 2)
                {
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = x - 2; j >= xmn + 1; j--)
                        {
                            a[i, j + 1] = a[i, j];
                        }
                    }
                    for (int i = 0; i < y; i++)
                    {
                        a[i, xmn + 1] = b[i];
                    }
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            Console.Write(a[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                else
                    Console.WriteLine("The last column has the smallest element");
            }
            #endregion
            #region Task 2.7
            {
                int n = 6;
                double[,] a = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                double mx = a[0, 0];
                int imx = 0;
                for (int i = 0; i < n; i++)
                {
                    if (a[i, i] > mx)
                    {
                        mx = a[i, i];
                        imx = i;
                    }
                }
                for (int i = 0; i < imx; i++)
                {
                    for (int j = i + 1; j < n; j++)
                        a[i, j] = 0;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region Task 2.8
            {
                int n = 6;
                double[,] b = new double[n, n];
                int[] index = new int[n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        b[i, j] = el;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    double mx = b[i, 0];
                    int imx = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (b[i, j] > mx)
                        {
                            mx = b[i, j];
                            imx = j;
                        }
                    }
                    index[i] = imx;
                }
                for (int i = 0; i < n; i += 2)
                {
                    double p = b[i, index[i]];
                    b[i, index[i]] = b[i + 1, index[i + 1]];
                    b[i + 1, index[i + 1]] = p;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            #region Task2.9
            {
                int y = 6, x = 7;
                double[,] a = new double[y, x];
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0, k = x - 1; j < k; j++, k--)
                    {
                        double p = a[i, j];
                        a[i, j] = a[i, k];
                        a[i, k] = p;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
            #region Task 3.1
            {
                int y = 7;
                int x = 5;
                double[,] a = new double[y, x];
                int[,] c = new int[y, 2];
                double[,] b = new double[y, x];
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < y; i++)
                {
                    double mn = a[i, 0];
                    for (int j = 0; j < x; j++)
                    {
                        if (a[i, j] < mn)
                        {
                            mn = a[i, j];
                        }
                    }
                    c[i, 0] = i;
                    int r = Convert.ToInt32(mn);
                    c[i, 1] = r;
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                int index;
                int zn;
                for (int k = 0; k < y - 1; k++)
                {
                    for (int i = k + 1; i < y; i++)
                    {
                        if (c[i, 1] > c[k, 1])
                        {
                            zn = c[k, 1];
                            index = c[k, 0];
                            c[k, 1] = c[i, 1];
                            c[k, 0] = c[i, 0];
                            c[i, 1] = zn;
                            c[i, 0] = index;
                        }
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        b[i, j] = a[c[i, 0], j];
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
            #region Task 3.2
            {
                Console.WriteLine("Enter size of matrix");
                int n;
                int.TryParse(Console.ReadLine(), out n);
                double[,] a = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0 || i == n - 1)
                        {
                            a[i, j] = 0;
                        }
                        a[i, 0] = 0;
                        a[i, n - 1] = 0;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
            #region Task 3.3
            {
                Console.WriteLine("Enter size of matrix");
                int n;
                int.TryParse(Console.ReadLine(), out n);
                double[,] a = new double[n, n];
                double[] b = new double[2 * n - 1];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int k = 0; k < n; k++)
                {
                    double s = 0;
                    for (int i = k; i < n; i++)
                    {
                        s += a[i, i - k];
                        b[k] = s;
                    }
                    s = 0;
                    for (int j = k; j < n; j++)
                    {
                        s += a[j - k, j];
                        b[k + n - 1] = s;
                    }
                }
                foreach (double cx in b)
                    Console.Write("{0:} ", cx);
                Console.WriteLine();
            }
            #endregion
            #region Task 3.4
            {
                Console.WriteLine("Enter size of matrix");
                int n;
                int.TryParse(Console.ReadLine(), out n);
                double[,] a = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                int p = 1;
                int l = n / 2;
                Console.WriteLine(l);
                Console.WriteLine();
                for (int i = l; i < n; i++)
                {
                    for (int j = 0; j < n / 2 + p; j++)
                    {
                        a[i, j] = 1;
                    }
                    p++;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
            #region Task 3.8
            {
                int y = 7;
                int x = 5;
                double[,] a = new double[y, x];
                int[,] c = new int[y, 2];
                double[,] b = new double[y, x];
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < y; i++)
                {
                    int counter = 0;
                    for (int j = 0; j < x; j++)
                    {
                        if (a[i, j] > 0)
                        {
                            counter++;
                        }
                    }
                    c[i, 0] = i;
                    c[i, 1] = counter;
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                int index;
                int zn;
                for (int k = 0; k < y - 1; k++)
                {
                    for (int i = k + 1; i < y; i++)
                    {
                        if (c[i, 1] > c[k, 1])
                        {
                            zn = c[k, 1];
                            index = c[k, 0];
                            c[k, 1] = c[i, 1];
                            c[k, 0] = c[i, 0];
                            c[i, 1] = zn;
                            c[i, 0] = index;
                        }
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        b[i, j] = a[c[i, 0], j];
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
            #region Task 3.10
            {
                Console.WriteLine("Enter y of matrix");
                int y;
                int.TryParse(Console.ReadLine(), out y);
                int x;
                Console.WriteLine("Enter x of matrix");
                int.TryParse(Console.ReadLine(), out x);
                double[,] a = new double[y, x];
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x - 1; j++)
                    {
                        double extrem = a[i, j];
                        int xextrem = j;
                        for (int k = j + 1; k < x; k++)
                        {
                            if (i % 2 == 0)
                            {
                                if (a[i, k] > extrem)
                                {
                                    extrem = a[i, k];
                                    xextrem = k;
                                }
                            }
                            if (i % 2 != 0)
                            {
                                if (a[i, k] < extrem)
                                {
                                    extrem = a[i, k];
                                    xextrem = k;
                                }
                            }
                        }
                        a[i, xextrem] = a[i, j];
                        a[i, j] = extrem;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
            #region Task 3.11
            {
                bool flag = true;
                int co = 0;
                Console.WriteLine("Enter y of matrix");
                int y;
                int.TryParse(Console.ReadLine(), out y);
                Console.WriteLine("Enter x of matrix");
                int x;
                int.TryParse(Console.ReadLine(), out x);
                double[,] a = new double[y, x];
                int n = 0;
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        double el;
                        Console.WriteLine($"Enter y{i}: x{j}: ");
                        double.TryParse(Console.ReadLine(), out el);
                        a[i, j] = el;
                    }
                }
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        if (a[i, j] == 0)
                        {
                            co++;
                            break;
                        }
                    }
                }
                if (co < y)
                {
                    double[,] b = new double[y - co, x];
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            if (a[i, j] == 0)
                            {
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            for (int k = 0; k < x; k++)
                            {
                                b[n, k] = a[i, k];
                            }
                            n++;
                        }
                        flag = true;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            Console.Write(b[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("No strings without 0");
            }
            #endregion
        }
    }
}
