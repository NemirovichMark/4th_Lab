using System;
using System.Reflection;

namespace _4nd_Lab
{
    class Program
    {
        static int FromHighToLow((int, double) x, (int, double) y)
        {
            if (x.Item2 < y.Item2)
            {
                return 1;
            }
            if (x.Item2 > y.Item2)
            {
                return -1;
            }

            return 0;
        }
        
        static void Main(string[] args)
        {
            #region task 1.3
            Console.WriteLine("Level 1 Task 3");
            int n = 4, m = 4;
            double s = 0;
            double[,] a = new double[n, m];

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double b))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = b;
                }
                s += a[i, i];
            }
            Console.WriteLine($"     Answer: {s}");
            #endregion
                
            #region task 1.6
            Console.WriteLine("Level 1 Task 6");
            int n = 4, m = 7;
            double[,] a = new double[n, m];
            int[] b = new int[n];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (f < a[i, index]) index = j;
                }
                b[i] = index;
            }
            Console.WriteLine("     Answer: ");
            foreach (double k in b)
            {
                Console.Write($"{k} ");
            }
            #endregion
                
            #region task 1.12
            Console.WriteLine("Level 1 Task 12");
            int n = 6, m = 7;
            double[,] a = new double[n, m];
            double[,] a_new = new double[n - 1, m - 1];
            int ii = 0;
            int jj = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (f > a[ii, jj])
                    {
                        ii = i;
                        jj = j;
                    }
                }
            }
            int inew = 0, jnew = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if(i == ii)
                {
                    inew++;
                }
                jnew = 0;
                for (int j = 0; j < m - 1; j++)
                {
                    if (j == jj)
                    {
                        jnew++;
                    }
                    a_new[i, j] = a[inew, jnew];
                    jnew++;
                }
                inew++;
            }
            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write($"{a_new[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 1.13
            Console.WriteLine("Level 1 Task 13");
            int n = 5, m = 5;
            double[,] a = new double[n, m];
            int max_i = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (a[i, i] > a[max_i, max_i]) max_i = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                 (a[i, max_i], a[i, 4]) = (a[i, 4], a[i, max_i]);
            }
            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m ; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 1.17
            Console.WriteLine("Level 1 Task 17");
            int n = 5, m = 5;
            double[,] a = new double[n, m];
            int min_i = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (f < a[i, min_i]) min_i = j;
                }
                while (min_i >= 1)
                {
                    (a[i, min_i], a[i, min_i - 1]) = (a[i, min_i - 1], a[i, min_i]);
                    min_i--;
                } 
            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 1.29
            Console.WriteLine("Level 1 Task 29");
            int n = 5, m = 7;
            double[,] a = new double[n, m];
            double[,] a_new = new double[n, m - 1];
            int min_j = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (i == 2 && Math.Abs(f) < Math.Abs(a[2, min_j]))
                    {
                        min_j = j;
                    }
                }  
            }

            if (min_j < m - 1)
            {
                for (int i = 0; i < n; i++)
                {
                    int jnew = 0;
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (j == min_j + 1)
                        {
                            jnew++;
                        }
                        a_new[i, j] = a[i, jnew];
                        jnew++;
                    }
                }
            }
            else
            {
                a_new = a;
            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a_new[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 1.31
            Console.WriteLine("Level 1 Task 31");
            int n = 5, m = 8;
            double[,] a = new double[n, m - 1];
            double[,] a_new = new double[n, m];
            double[] b = new double[5];
            int min_j = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (i == 5 && f < a[5, min_j])
                    {
                        min_j = j;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"    Please enter {i} number");
                if (!double.TryParse(Console.ReadLine(), out double d))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    return;
                }
                b[i] = d;
            }

            for (int i = 0; i < n; i++)
            {
                int jnew = 0;
                for (int j = 0; j < m; j++)
                {
                    if (j == min_j + 1)
                    {
                        a_new[i, j] = b[i];
                    }
                    else
                    {
                        a_new[i, j] = a[i, jnew];
                        jnew++;
                    }
                }
            }
            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a_new[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 2.7
            Console.WriteLine("Level 2 Task 7");
            int n = 6, m = 6;
            double[,] a = new double[n, m];
            //double[,] a_new = new double[n, m];
            int max_ind = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (i == j && f > a[max_ind, max_ind])
                    {
                        max_ind = i;
                    }
                }
            }

            if (max_ind != 0)
            {
                for (int i = 0; i < max_ind; i++)
                {
                    for (int j = i + 1; j < m; j++)
                    {
                        a[i, j] = 0;
                    }
                }
                
            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 2.8
            Console.WriteLine("Level 2 Task 8");
            int n = 6, m = 6;
            double[,] a = new double[n, m];
            int[] b = new int[n];
            //double[,] a_new = new double[n, m];
            int max_j = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (f > a[i, max_j])
                    {
                        max_j = j;
                    }
                }
                b[i] = max_j;
            }


            for (int i = 0; i < n; i += 2)
            {
                (a[i, b[i]], a[i + 1, b[i + 1]]) = (a[i + 1, b[i + 1]], a[i, b[i]]);
            }


            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 2.9
            Console.WriteLine("Level 2 Task 9");
            int n = 6, m = 7;
            double[,] a = new double[n, m], a_new = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    a_new[i, m - j - 1] = f;
                }
            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a_new[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 3.1
            Console.WriteLine("Level 3 Task 1");
            int n = 7, m = 5;
            double[,] a = new double[n, m], b = new double[n, m];
            List<(int, double)> values = new List<(int, double)>();

            for (int i = 0; i < n; i++)
            {
                int min_j = 0;
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (f < a[i, min_j])
                    {
                        min_j = j;
                    }
                }
                values.Add((i, a[i, min_j]));
            }

            values.Sort(FromHighToLow);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = a[values[i].Item1, j];
                }
            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 3.2
            Console.WriteLine("Level 3 Task 2");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            double[,] a = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                }
            }

            for (int i = 0; i < n; i++)
            {
                a[n - 1, i] = 0;
                a[0, i] = 0;
                a[i, 0] = 0;
                a[i, n - 1] = 0;
            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 3.3
            Console.WriteLine("Level 3 Task 3");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            double[,] a = new double[n, n];
            List<double> b = new List<double>(2 * n - 1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                }
            }

            for (int j = 0; j < n; j++)
            {
                double s = 0;
                for (int i = 0; i < n - j; i++)
                {
                    s += a[i, i + j];
                }
                b.Add(s);
                s = 0;
                for (int k = 1; k < n - j; k++)
                {
                    s += a[j + k, k - 1];
                }
                b.Add(s);
            }

            /*for (int j = 1; j < n; j++)
            {
                double s = 0;
                for (int i = 0; i < n - j; i++)
                {
                    s += a[i, i + j];
                }
                b.Add(s);
            }*/

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.Write($"{b[i]} ");
            }
            #endregion
                
            #region task 3.4
            Console.WriteLine("Level 3 Task 4");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            double[,] a = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                }
            } 

            for (int i = n/2; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    a[i, j] = 1;
                }
            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 3.8
            Console.WriteLine("Level 3 Task 8");
            int n = 4, m = 4;
            double[,] a = new double[n, m];
            int[,] quantities = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (f > 0)
                    {
                        counter++;
                    }
                }
                quantities[i, 0] = i;
                quantities[i, 1] = counter;
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (quantities[j, 1] < quantities[j + 1, 1])
                    {
                        (quantities[j, 0], quantities[j + 1, 0]) = (quantities[j + 1, 0], quantities[j, 0]);
                        (quantities[j, 1], quantities[j + 1, 1]) = (quantities[j + 1, 1], quantities[j, 1]);
                    }
                }
            }

            List<(List<double>, int)> rows = new List<(List<double>, int)>();

            for (int i = 0; i < n; i++)
            {
                if (i < quantities[i, 0])
                {
                    List<double> row = new List<double>();
                    for (int j = 0; j < m; j++)
                    {
                        row.Add(a[i, j]);
                        a[i, j] = a[quantities[i, 0], j];
                    }
                    rows.Add((row, i));
                }
                else if (i > quantities[i, 0])
                {
                    List<double> row = new List<double>();
                    for (int j = 0; j < m; j++)
                    {
                        row.Add(a[i, j]);
                    }
                    rows.Add((row, i));

                    row = new List<double>();
                    for (int k = 0; k < rows.Count; k++)
                    {
                        if (rows[k].Item2 == quantities[i, 0]) row = rows[k].Item1;
                    }
                    for (int j = 0; j < m; j++)
                    {
                        a[i, j] = row[j];
                    }
                }
            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 3.10
            Console.WriteLine("Level 3 Task 10");
            int n, m;

            while (true)
            {
                Console.WriteLine("    Please enter n:");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                Console.WriteLine("    Please enter m:");
                if ((!int.TryParse(Console.ReadLine(), out m)) || (m <= 0))
                {
                    Console.WriteLine("    Wrong p, please try again");
                    continue;
                }
                break;
            }

            double[,] a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                }
            }

            for (int i = 0; i < n; i++)
            {
                List<double> even = new List<double>(), odd = new List<double>();
                if (i % 2 == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        even.Add(a[i, j]);
                    }
                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        odd.Add(a[i, j]);
                    }
                }

                even.Sort();
                even.Reverse();
                odd.Sort();

                int counter_even = 0, counter_odd = 0;
                for (int j = 0; j < m; j++)
                {
                    if (i % 2 == 0)
                    {
                        a[i, j] = even[counter_even];
                        counter_even++;
                    }
                    else
                    {
                        a[i, j] = odd[counter_odd];
                        counter_odd++;
                    }
                }
                    
                    

            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion
                
            #region task 3.11
            Console.WriteLine("Level 3 Task 11");
            int n, m;

            while (true)
            {
                Console.WriteLine("    Please enter n:");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                Console.WriteLine("    Please enter m:");
                if ((!int.TryParse(Console.ReadLine(), out m)) || (m <= 0))
                {
                    Console.WriteLine("    Wrong p, please try again");
                    continue;
                }
                break;
            }

            double[,] a = new double[n, m];
            List<int> c = new List<int>();
            int flag = 0, counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"    Please enter {i}, {j} number");
                    if (!double.TryParse(Console.ReadLine(), out double f))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        return;
                    }
                    a[i, j] = f;
                    if (f == 0) flag = 1;
                }
                if (flag == 1)
                {
                    counter++;
                    c.Add(i);
                }
                flag = 0;
            }

            int nn = n - counter;
            var b = new double[nn, m];
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (k < c.Count)
                {
                    if (c[k] != i)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            b[i - k, j] = a[i, j];
                        }
                    }
                    else
                    {
                        k++;
                    }
                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        b[i - k, j] = a[i, j];
                    }
                }
            }

            Console.WriteLine("     Answer: ");
            for (int i = 0; i < nn; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            #endregion    
        }
    }
}
