using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

class hw5
{
    static void Main()
    {
        Console.WriteLine("введите номер задания (3,6,12,13,17,29,31)");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb == 3)
        {
            #region Level1task3
            int m = 4;
            int n = 4;
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
            int sum = 0;
            for (int i2 = 0; i2 < m; i2++)
                for (int j2 = 0; j2 < n; j2++)
                {
                    if ((i2 == j2) || (j2 == n - i2 - 1))
                        sum += a3[i2, j2];
                }
            //for (int i1 = 0; i1 < m; i1++)
            //{
            //  for (int j1 = 0; j1 < n; j1++)
            //{
            //  Console.Write(a3[i1, j1]);
            //Console.Write(' ');
            // }
            //Console.WriteLine();

            //  }
            Console.WriteLine(sum);
            #endregion

        }
        else if (numb == 6)
        {
            #region Level1task6
            int m = 4;
            int n = 7;
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


            int[] ma = new int[m];

            for (int i2 = 0; i2 < m; i2++)
            {
                int min = 10000000;
                for (int j2 = 0; j2 < n; j2++)
                {
                    if (min > a[i2, j2])
                    {
                        min = a[i2, j2];
                    }
                }
                ma[i2] = min;
            }
            for (int ix = 0; ix < m; ix++)
                Console.WriteLine(ma[ix]);
            for (int i1 = 0; i1 < m; i1++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    Console.Write(a[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }
            #endregion
        }
        else if (numb == 12)
        {
            #region Level1task12
            int m = 6;
            int n = 7;
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


            int max = -1000000;
            int imax = 0;
            int jmax = 0;

            for (int i2 = 0; i2 < m; i2++)
            {

                for (int j2 = 0; j2 < n; j2++)
                {
                    if (max < a[i2, j2])
                    {
                        max = a[i2, j2];
                        imax = i2;
                        jmax = j2;
                    }
                }

            }
            
            for (int i1 = imax; i1 < (m - 1); i1++)
            {
                for (int j1 = jmax; j1 < (n - 1); j1++)
                {
                    a[i1, j1] = a[i1 + 1, j1 + 1];
                }

            }

            for (int i1 = 0; i1 < (m - 1); i1++)
            {
                for (int j1 = 0; j1 < (n - 1); j1++)
                {
                    Console.Write(a[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }
            #endregion
        }
        else if (numb == 13)
        {
            #region Level1task13
            int m = 5;
            int n = 5;
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


            int[] ma = new int[m];
            int max = -100000;
            int jmax = 0;

            for (int i2 = 0; i2 < m; i2++)
            {
                if ((a[i2,i2] > max))
                {
                    max = a[i2,i2];
                    jmax = i2;
                }
                if ((a[i2,n-i2-1] > max))
                {
                    max = a[i2, n - i2-1];
                    jmax = n - i2-1;
                }

            }
            // for (int i1 = 0; i1 < m; i1++)
            // {
            //   for (int j1 = 0; j1 < n; j1++)
            // {
            //   Console.Write(a[i1, j1]);
            // Console.Write(' ');
            //}
            //Console.WriteLine();

            //            }
            //Console.WriteLine("=========");
            //Console.WriteLine($"jmax = > {jmax}");
            for (int ix = 0; ix < m; ix++)
            {
                int t = a[ix, 3];
                a[ix, 3] = a[ix, jmax];
                a[ix, jmax] = t;
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
            #endregion
        }
        else if (numb == 17)
        {
            #region Level1task17
            Console.WriteLine("введите размер матрицы n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("введите размер матрицы m");
                int m = Convert.ToInt32(Console.ReadLine());

                if (m > 0)
                {
                    int[,] a = new int[n, m];
                    Console.WriteLine("введите массив");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
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

                    //   for (int i1 = 0; i1 < n; i1++)
                    //  {
                    //    for (int j1 = 0; j1 < m; j1++)
                    //  {
                    //    Console.Write(a[i1, j1]);
                    //  Console.Write(' ');
                    //  }
                    // Console.WriteLine();

                    //  }
                    for (int i2 = 0; i2 < n; i2++)
                    {
                        int min = 10000000;
                        int jmin = 0;
                        for (int j2 = 0; j2 < m; j2++)
                        {
                            if (min > a[i2, j2])
                            {
                                min = a[i2, j2];
                                jmin = j2;
                            }
                        }
                        while (jmin >= 1)
                        {
                            (a[i2, jmin], a[i2, jmin - 1]) = (a[i2, jmin - 1], a[i2, jmin]);
                            jmin--;
                        }

                    }

                    for (int i1 = 0; i1 < n; i1++)
                    {
                        for (int j1 = 0; j1 < m; j1++)
                        {
                            Console.Write(a[i1, j1]);
                            Console.Write(' ');
                        }
                        Console.WriteLine();

                    }
                }
                else Console.WriteLine("введите m>0");
            }
            else Console.WriteLine("введите n>0");
            #endregion
        }
        else if (numb == 29)
        {
            #region Level1task29
            int n = 5;
            int m = 7;
            int[,] a = new int[n, m];
            Console.WriteLine("введите массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
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
            int min = 10000000;
            int jmin = 0;
            for (int j = 0; j < m; j++)
            {
                if (min > Math.Abs(a[1, j])) // находим минимальный по модулю элементы во второй строке
                {
                    jmin = j;
                    min = a[1, j];
                }
            }
            //  for (int i1 = 0; i1 < n; i1++)
            //{
            //  for (int j1 = 0; j1 < m; j1++)
            //{
            //  Console.Write(a[i1, j1]);
            //Console.Write(' ');
            //  }
            //  Console.WriteLine();

            // }
            if (jmin != (m - 1))
            {
                for (int i2 = 0; i2 < n; i2++)
                    for (int j2 = jmin + 1; j2 < (m - 1); j2++)
                        a[i2, j2] = a[i2, j2 + 1];
                m = m - 1;

            }

            for (int i1 = 0; i1 < n; i1++)
            {
                for (int j1 = 0; j1 < m; j1++)
                {
                    Console.Write(a[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }
            #endregion

        }
        else if (numb == 31)
        {
            #region Level1task31
            int n = 5;
            int m = 8;
            int[,] a = new int[n, m];
            Console.WriteLine("введите массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (m - 1); j++)
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
            Console.WriteLine("введите вектор размером 5");
            int[] ma = new int[5];
            string[] temp1 = (Console.ReadLine()).Split(' ');
            bool u = true;
            for (int i = 0; i < 5; i++)
            {
                u = int.TryParse(temp1[i], out int xx);
                if (u == true)
                {
                    ma[i] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }

            }
            int min = 10000000;
            int jmin = 0;
            for (int j = 0; j < (m - 1); j++)
            {
                if (min > a[4, j]) // находим минимальный элемент в пятой строке
                {
                    jmin = j;
                    min = a[4, j];
                }
            }

            //    for (int i1 = 0; i1 < n; i1++)
            //    {
            //      for (int j1 = 0; j1 < m; j1++)
            //    {
            //      Console.Write(a[i1, j1]);
            //    Console.Write(' ');
            //         }
            //       Console.WriteLine();

            //   }
            for (int i = 0; i < n; i++)
            {
                for (int j = (m - 1); j >= jmin + 1; j--)
                {
                    if (j == jmin + 1)
                    {
                        a[i, j] = ma[i];
                    }
                    else
                    {
                        a[i, j] = a[i, j - 1];
                    }
                }
            }
            for (int i1 = 0; i1 < n; i1++)
            {
                for (int j1 = 0; j1 < m; j1++)
                {
                    Console.Write(a[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }
            #endregion
        }
        else Console.WriteLine("выберите из списка");
    }
}

