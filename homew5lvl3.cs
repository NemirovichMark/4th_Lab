using Microsoft.VisualBasic.FileIO;
using System;
using System.Globalization;

class hw5
{
    static int[] chetsort(int[] a, int m)
        {
        int partition<T>(T[] m, int a, int b) where T : IComparable<T>
        {
            int i = a;
            for (int j = a; j <= b; j++)
            {
                if (m[j].CompareTo(m[b]) >= 0)
                {
                    T t = m[i]; m[i] = m[j]; m[j] = t;
                    i++;
                }
            }
            return i - 1;
        }

        void quicksort<T>(T[] m, int a, int b) where T : IComparable<T>
        {
            if (a >= b) return;
            int c = partition(m, a, b);
            quicksort(m, a, c - 1);
            quicksort(m, c + 1, b);
        }
        quicksort(a, 0, m-1);
        return a;
    }
    static int[] nochetsort(int[] a, int m)
    {
        int partition<T>(T[] m, int a, int b) where T : IComparable<T>
        {
            int i = a;
            for (int j = a; j <=b; j++)
            {
                if (m[j].CompareTo(m[b]) <= 0)
                {
                    T t = m[i]; m[i] = m[j]; m[j] = t;
                    i++;
                }
            }
            return i - 1;
        }

        void quicksort<T>(T[] m, int a, int b) where T : IComparable<T>
        {
            if (a >= b) return;
            int c = partition(m, a, b);
            quicksort(m, a, c - 1);
            quicksort(m, c + 1, b);
        }
        quicksort(a, 0, m-1);
        return a;
    }

    static void Main()
    {
        Console.WriteLine("введите номер задания (1-4,8,10,11)");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb == 2)
        {
            #region Level3task2
            Console.WriteLine("введите размер квадратной матрицы m");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m > 0)
            {
                int n = m;
                int[,] a3 = new int[m, n];
                Console.WriteLine("введите массив");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        string s = Console.ReadLine();
                        bool boo = int.TryParse(s, out int xx);
                        if (boo == true)
                        {
                            a3[i, j] = xx;
                        }
                        else
                        {

                            Console.WriteLine("введите заново");
                            break;
                        }
                    }
                }
                for (int i2 = 0; i2 < m; i2++)
                {
                    for (int j2 = 0; j2 < n; j2++)
                    {
                        if ((i2 == 0) || (i2 == (m - 1)) || (j2 == 0) || (j2 == (n - 1)))
                        {
                            a3[i2, j2] = 0;
                        }

                    }
                }
                for (int i1 = 0; i1 < m; i1++)
                {
                    for (int j1 = 0; j1 < n; j1++)
                    {
                        Console.Write(a3[i1, j1]);
                        Console.Write(' ');
                    }
                    Console.WriteLine();

                }
            }
            else Console.WriteLine("введите m>0");

            #endregion

        }
        else if (numb == 4)
        {
            #region Level3task4
            Console.WriteLine("введите размер квадратной матрицы n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int m = n;
                int[,] a3 = new int[m, n];
                Console.WriteLine("введите массив");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        string s = Console.ReadLine();
                        bool boo = int.TryParse(s, out int xx);
                        if (boo == true)
                        {
                            a3[i, j] = xx;
                        }
                        else
                        {

                            Console.WriteLine("введите заново");
                            break;
                        }
                    }
                }
                for (int i1 = 0; i1 < m; i1++)
                {
                    for (int j1 = 0; j1 < n; j1++)
                    {
                        Console.Write(a3[i1, j1]);
                        Console.Write(' ');
                    }
                    Console.WriteLine();

                }
                int c1 = m / 2;

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (((i >= c1)) && (i >= j))
                            a3[i, j] = 1;

                    }
                }
                for (int i1 = 0; i1 < m; i1++)
                {
                    for (int j1 = 0; j1 < n; j1++)
                    {
                        Console.Write(a3[i1, j1]);
                        Console.Write(' ');
                    }
                    Console.WriteLine();

                }

            }
            #endregion
        }
        else if (numb == 1)
        {
            #region Level3task1
            int m = 7;
            int n = 5;
            int[,] a3 = new int[m, n];
            Console.WriteLine("введите массив");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string s = Console.ReadLine();
                    bool boo = int.TryParse(s, out int xx);
                    if (boo == true)
                    {
                        a3[i, j] = xx;
                    }
                    else
                    {

                        Console.WriteLine("введите заново");
                        break;
                    }
                }
            }
            //          for (int i1 = 0; i1 < m; i1++)
            //        {
            //          for (int j1 = 0; j1 < n; j1++)
            //        {
            //          Console.Write(a3[i1, j1]);
            //        Console.Write(' ');
            //  }
            //             Console.WriteLine();

            //         }
            int[,] b = new int[m, 2]; // массив где первое число - минимальный элемент, второе - индекс строки
            for (int i = 0; i < m; i++)
            {
                int min = 1000000;
                for (int j = 0; j < n; j++)
                {
                    if (min > a3[i, j])
                    {
                        min = a3[i, j]; //запоминаем минимальный элемент
                    }
                }
                b[i, 0] = min; // в массив вводим значения
                b[i, 1] = i;
            }
            int l = 0,
                r = m - 1;
            int c = 0;

            while (l < r) //coctail sort
            {
                for (int i = l; i < r; i++)
                {
                    c++;

                    if (b[i, 0] < b[i + 1, 0])
                    {
                        int t = b[i, 0];
                        int ind = b[i, 1];
                        b[i, 0] = b[i + 1, 0];
                        b[i, 1] = b[i + 1, 1];
                        b[i + 1, 0] = t;
                        b[i + 1, 1] = ind;
                    }
                }
                r--;
                for (int i = r; i > l; i--)
                {
                    c++;
                    if (b[i, 0] > b[i - 1, 0])
                    {
                        int t = b[i, 0];
                        int ind = b[i, 1];
                        b[i, 0] = b[i - 1, 0];
                        b[i, 1] = b[i - 1, 1];
                        b[i - 1, 0] = t;
                        b[i - 1, 1] = ind;

                    }
                }
                l++;
            }
            //          Console.WriteLine(c);
            //        for (int i1 = 0; i1 < m; i1++)
            //      {
            //        for (int j1 = 0; j1 < 2; j1++)
            //      {
            //        Console.Write(b[i1, j1]);
            //      Console.Write(' ');
            //          }
            //        Console.WriteLine();

            //  }
            int[,] res = new int[m, n];
            for (int i = 0; i < (m); i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i, j] = a3[b[i, 1], j];
                }
            }
            for (int i1 = 0; i1 < m; i1++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    Console.Write(res[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

            #endregion
        }
        else if (numb == 3)
        {
            #region Level3task3
            Console.WriteLine("введите n>0");
            bool boo = int.TryParse(Console.ReadLine(), out int m);
            if ((boo == true) && (m > 0))
            {

                int n = m;
                int[,] a3 = new int[m, n];
                Console.WriteLine("введите массив");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        string s = Console.ReadLine();
                        bool boo1 = int.TryParse(s, out int xx);
                        if (boo1 == true)
                        {
                            a3[i, j] = xx;
                        }
                        else
                        {

                            Console.WriteLine("введите заново");
                            break;
                        }
                    }
                }
                //     for (int i1 = 0; i1 < m; i1++)
                //   {
                //   for (int j1 = 0; j1 < n; j1++)
                //     {
                //     Console.Write(a3[i1, j1]);
                //   Console.Write(' ');
                //        }
                //      Console.WriteLine();

                //}
                int[] a = new int[2 * m - 1];
                for (int i = 0; i < m; i++)
                {
                    int s1 = 0, s2 = 0;

                    for (int j = 0; j <= i; j++)
                    {
                        s1 += a3[m - 1 - i + j, j];
                        s2 += a3[j, m - 1 - j];

                    }
                    a[i] = s1;
                    a[a.Length - 1 - i] = s2;
                }
                Console.WriteLine("Суммы: {0}", string.Join(", ", a));
            }
            else
            {

                Console.WriteLine("введите n > 0");


            }
            #endregion
        }
        else if (numb == 8)
        {
            #region Level3task8
            int m = 7;
            int n = 5;
            int[,] a3 = new int[m, n];
            Console.WriteLine("введите массив");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string s = Console.ReadLine();
                    bool boo = int.TryParse(s, out int xx);
                    if (boo == true)
                    {
                        a3[i, j] = xx;
                    }
                    else
                    {

                        Console.WriteLine("введите заново");
                        break;
                    }
                }
            }
            //   for (int i1 = 0; i1 < m; i1++)
            // {
            //   for (int j1 = 0; j1 < n; j1++)
            // {
            //   Console.Write(a3[i1, j1]);
            // Console.Write(' ');
            //         }
            //       Console.WriteLine();

            // }
            int[,] b = new int[m, 2]; // массив где первое число - количество положительных элементов, второе - индекс строки
            for (int i = 0; i < m; i++)
            {
                int cx = 0;
                for (int j = 0; j < n; j++)
                {

                    if (a3[i, j] > 0)
                    {
                        cx++; // считаем количество положительных элементов в строке
                    }
                }
                b[i, 0] = cx; // в массив вводим значения
                b[i, 1] = i;
            }
            int l = 0,
                r = m - 1;
            int c = 0;

            while (l < r) //coctail sort
            {
                for (int i = l; i < r; i++)
                {
                    c++;

                    if (b[i, 0] < b[i + 1, 0])
                    {
                        int t = b[i, 0];
                        int ind = b[i, 1];
                        b[i, 0] = b[i + 1, 0];
                        b[i, 1] = b[i + 1, 1];
                        b[i + 1, 0] = t;
                        b[i + 1, 1] = ind;
                    }
                }
                r--;
                for (int i = r; i > l; i--)
                {
                    c++;
                    if (b[i, 0] > b[i - 1, 0])
                    {
                        int t = b[i, 0];
                        int ind = b[i, 1];
                        b[i, 0] = b[i - 1, 0];
                        b[i, 1] = b[i - 1, 1];
                        b[i - 1, 0] = t;
                        b[i - 1, 1] = ind;

                    }
                }
                l++;
            }
            //  Console.WriteLine(c);
            //for (int i1 = 0; i1 < m; i1++)
            //  {
            //    for (int j1 = 0; j1 < 2; j1++)
            //  {
            //    Console.Write(b[i1, j1]);
            //  Console.Write(' ');
            //         }
            //       Console.WriteLine();

            //   }
            int[,] res = new int[m, n];
            for (int i = 0; i < (m); i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i, j] = a3[b[i, 1], j];
                }
            }
            for (int i1 = 0; i1 < m; i1++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    Console.Write(res[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

            #endregion
        }
        else if (numb == 10)
        {
            #region Level3task10
            int n = 0, m = 0;
            try
            {
                Console.WriteLine("введите n>0");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите m>0");
                m = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("введите заново");
            }
            if ((n > 0) && (m > 0))
            {
                int[,] a = new int[m, n];
                Console.WriteLine("введите массив");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        string s = Console.ReadLine();
                        bool boo1 = int.TryParse(s, out int xx);
                        if (boo1 == true)
                        {
                            a[i, j] = xx;
                        }
                        else
                        {

                            Console.WriteLine("введите заново");
                            break;
                        }
                    }
                }
                for (int i1 = 0; i1 < m; i1++)
                {
                    for (int j1 = 0; j1 < n; j1++)
                    {
                        Console.Write(a[i1, j1]);
                        Console.Write(' ');
                    }
                    Console.WriteLine();

                }
                int[] temp = new int[n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        temp[j]=a[i, j];                        

                    }
                    if (i % 2 == 0)
                    {
                        temp = chetsort(temp, n);
                    }
                    else
                        temp = nochetsort(temp, n);
                    for (int j = 0; j < n; j++)
                        a[i, j] = temp[j];

                }
                for (int i1 = 0; i1 < m; i1++)
                {
                    for (int j1 = 0; j1 < n; j1++)
                    {
                        Console.Write(a[i1, j1]);
                        Console.Write(' ');
                    }
                    Console.WriteLine();

                }
            }
        else Console.WriteLine("введите положительные числа");
            #endregion
        }
        else if (numb == 11)
        {
            #region Level3task11
            int n = 0, m = 0;
            try
            {
                Console.WriteLine("введите n>0");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите m>0");
                m = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("введите заново");
            }
            if ((n > 0) && (m > 0))
            {
                int[,] a = new int[m, n];
                Console.WriteLine("введите массив");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        string s = Console.ReadLine();
                        bool boo = int.TryParse(s, out int xx);
                        if (boo == true)
                        {
                            a[i, j] = xx;
                        }
                        else
                        {

                            Console.WriteLine("введите заново");
                            break;
                        }
                    }
                }
                
                int[] ind = new int[m];
                int x = 0;
                for (int i = 0; i<m;i++)
                    {
                        int c = 0;
                        for (int j = 0; j<n;j++)
                        {
                            if (a[i, j] == 0)
                                c++;
                        }
                        if (c>0)
                        {
                            ind[x] = i;
                            x++;
                        }
                    }
                int d = 0;
                while (d!=x)
                {
                    for (int i = ind[d]; i<(m-1-d);i++)
                    {
                        for (int j = 0; j < n; j++)
                            a[i, j] = a[i + 1, j];
                    }

                    d++;
                }
                
                for (int i1 = 0; i1 < (m-x); i1++)
                {
                    for (int j1 = 0; j1 < n; j1++)
                    {
                        Console.Write(a[i1, j1]);
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("write CORRECTLY");
            #endregion
        }
        else Console.WriteLine("введите n>0");

    } 
}

