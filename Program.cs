using System;

namespace Task
{

    class Program
    {
        static string ListToString(List<double> L)
        {
            string s = "";
            foreach (double v in L)
            {
                s += v.ToString();
                s += " ";
            }
            return s;
        }
        static string ArrayToString(double[] L)
        {
            string s = "";
            foreach (double v in L)
            {
                s += v.ToString();
                s += " ";
            }
            return s;
        }
        static string[] ArrayToString(double[,] L)
        {
            int n = L.GetLength(0),m = L.GetLength(1);
            string[] S = new string[n]; 
            for(int i = 0; i < n; i++)
            {
                string s = "";
                for(int j = 0; j < m; j++)
                {
                    s += L[i, j].ToString();
                    s += " ";
                }
                S[i] = s;
            }
            return S;
        }
        static int Compare((double, int) x, (double, int) y)
        {
            if(x.Item1 < y.Item1)
            {
                return 1;
            }

            if (x.Item1 > y.Item1)
            {
                return -1;
            }

            return 0;
        }

        static void exercise_1_3()
        {
            string error = "ошибка 1_3";
            int n = 4, m = 4;
            double[,] A = new double[n, m];
            double ans = 0;
            Console.WriteLine($"ведите {n} строк {m} столбца ");

            for (int i = 0; i < n; ++i)
            {
                int minI = 0;
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j] ;

                    A[i, j] = a;
                }
                ans += A[i,i];
            }

            string s = "ans : ";

            s += ans.ToString();
            Console.WriteLine(s);
        }
        static void exercise_1_6()
        {
            string error = "ошибка 1_6";
            int n = 4, m = 7;
            double[,] A = new double[n, m];
            double[] ans = new double[n];
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                int minI = 0;
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;

                    if (a < A[i, minI])
                    {
                        minI = j;
                    }
                }
                ans[i] = minI;
            }
            string s = "ans : ";

            s += ArrayToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_1_12()
        {
            string error = "ошибка 1_12";
            int n = 6, m = 7;
            double[,] A = new double[n, m];
            double[,] ans = new double[n - 1, m - 1];
            int maxI = 0, maxJ = 0;
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;

                    if (a > A[maxI, maxJ])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
            int shi = 0, shj = 0;
            for(int i = 0; i < n - 1; ++i)
            {
                if(shi == maxI)
                {
                    shi++;
                }
                shj = 0;
                for (int j = 0; j < m - 1; ++j)
                {
                    if (shj == maxJ)
                    {
                        shj++;
                    }
                    ans[i, j] = A[shi, shj];
                    shj++;
                }
                shi++;
            }

            string s = "ans : ";
            Console.WriteLine(s);
            string[] S = new string[n]; 
            S = ArrayToString(ans);
            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_1_13()
        {
            string error = "ошибка 1_13";
            int n = 5, m = 5, k = 4;
            double[,] A = new double[n, m];
            int maxJ = 0;
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }

                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;
                }

                if (A[i, i] > A[maxJ, maxJ])
                {
                    maxJ = i;
                }

            }

            for (int i = 0; i < n; ++i) 
            {
                (A[i, k], A[i, maxJ]) = (A[i, maxJ], A[i, k]);
            }

            string s = "ans : ";
            Console.WriteLine(s);
            string[] S = new string[n];
            S = ArrayToString(A);
            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_1_17()
        {
            string error = "ошибка 1_17";
            int n = 5, m = 5;
            Console.WriteLine("ведите n(n >= 0)");
            if(!Input.CheckRead(out n, error))
            {
                return;
            }
            if(n < 0)
            {
                Console.WriteLine(error);
                return;
            }

            Console.WriteLine("ведите m(m >= 0)");
            if (!Input.CheckRead(out m, error))
            {
                return;
            }
            if (m < 0)
            {
                Console.WriteLine(error);
                return;
            }

            double[,] A = new double[n, m];
            Console.WriteLine($"ведите {n} строк {m} столбца ");

            for (int i = 0; i < n; ++i)
            {
                int minJ = 0;

                if (!Input.CheckSplitRead(out List<double> L, error, m)) 
                {
                    return;
                }

                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;

                    if(a < A[i, minJ])
                    {
                        minJ = j;
                    }
                }

                while(minJ > 0)
                {
                    (A[i, minJ], A[i, minJ - 1]) = (A[i, minJ - 1], A[i, minJ]);
                    minJ--;
                }

            }

            string s = "ans : ";
            Console.WriteLine(s);
            string[] S = new string[n];
            S = ArrayToString(A);
            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_1_29()
        {
            string error = "ошибка 1_29";
            int n = 5, m = 3;
            double[,] A = new double[n, m];
            double[,] ans = new double[n , m - 1];
            int maxI = 2, minJ = 0;
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;

                    if (i == 2 && Math.Abs(a) < Math.Abs(A[maxI, minJ]))
                    {
                        minJ = j;
                    }
                }
            }

            string[] S = new string[n];
            
            if (minJ < m - 1)
            {
                int  shj = 0;
                minJ++;
                for (int i = 0; i < n ; ++i)
                {
                    shj = 0;
                    for (int j = 0; j < m - 1; ++j)
                    {
                        if (shj == minJ)
                        {
                            shj++;
                        }
                        ans[i, j] = A[i, shj];
                        shj++;
                    }

                }

                S = ArrayToString(ans);
            }
            else
            {
                S = ArrayToString(A);
            }

            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_1_31()
        {
            string error = "ошибка 1_31";
            int n = 5, m = 7;
            double[,] A = new double[n, m];
            double[,] ans = new double[n, m + 1];
            int maxI = 5, minJ = 0;
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;

                    if (i == 5 && a < A[maxI, minJ])
                    {
                        minJ = j;
                    }
                }
            }
            Console.WriteLine($"ведите {n} значений в строку ");
            if (!Input.CheckSplitRead(out List<double> l, error, n))
            {
                return;
            }

            string[] S = new string[n];
            
            int shj = 0;
            minJ++;
            for (int i = 0; i < n; ++i)
            {
                shj = 0;
                for (int j = 0; j < m + 1; ++j)
                {
                    if (j == minJ)
                    {
                        ans[i, j] = l[i];
                        continue;
                    }
                    ans[i, j] = A[i, shj];
                    shj++;
                }

            }

            S = ArrayToString(ans);

            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }

        static void exercise_2_7()
        {
            string error = "ошибка 2_7";
            int n = 6, m = 6;
            double[,] A = new double[n, m];
            int maxI = 0, maxJ = 0;
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;


                }
                if (A[i, i] > A[maxI, maxJ])
                {
                    maxI = i;
                    maxJ = i;
                }
            }

            for(int i = 0; i < n; ++i)
            {
                for (int j = i + 1; j < m; ++j)
                {
                    if(i < maxI)
                    {
                        A[i, j] = 0;
                    }
                }
            }

            string[] S;
            S = ArrayToString(A);
            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_2_8()
        {
            string error = "ошибка 2_8";
            int n = 6, m = 6;
            double[,] A = new double[n, m];
            int[] B = new int[n];
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                int maxJ = 0;
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;
                    if(a > A[i, maxJ])
                    {
                        maxJ = j;
                    }
                }
                B[i] = maxJ;

            }

            for(int i = 0; i < n; i += 2)
            {
                (A[i, B[i]], A[i + 1, B[i + 1]]) = (A[i + 1, B[i + 1]], A[i, B[i]]);
            }

            string[] S;
            S = ArrayToString(A);
            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_2_9()
        {
            string error = "ошибка 2_9";
            int n = 6, m = 7;
            double[,] A = new double[n, m], B = new double[n, m];

            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                int maxJ = 0;
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;

                }

            }

            for(int i = 0; i < n; ++i)
            {
                for(int j =0; j < m; ++j)
                {
                    B[i, j] = A[n - i - 1, m - j - 1]; 
                }
            }

            string[] S;
            S = ArrayToString(B);
            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }

        static void exercise_3_1()
        {
            string error = "ошибка 3_1";
            int n = 7, m = 5;
            double[,] A = new double[n, m], B = new double[n, m];
            List<(double, int)> l = new List<(double, int)>();
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                int minJ = 0;
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;
                    if (a < A[i, minJ])
                    {
                        minJ = j;
                    }
                }
                l.Add((A[i, minJ], i));

            }
            l.Sort(Compare);
            //Console.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                var to = l[i];
                //Console.WriteLine(to.Item1.ToString() + " " + to.Item2.ToString());
                for (int j = 0; j < m; ++j)
                {
                    B[i, j] = A[to.Item2, j];
                }
            }

            string[] S;
            S = ArrayToString(B);
            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_3_2()
        {
            string error = "ошибка 3_2";
            int n;
            Console.WriteLine("ведите n(n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine(error);
                return;
            }

            double[,] A = new double[n, n];

            Console.WriteLine($"ведите {n} строк {n} столбца ");
            for (int i = 0; i < n; ++i)
            {
                int minJ = 0;
                if (!Input.CheckSplitRead(out List<double> L, error, n))
                {
                    return;
                }
                for (int j = 0; j < n; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;
                }

            }

            for(int i = 0; i < n; ++i)
            {
                A[i, n-1] = 0;
                A[n-1, i] = 0;
                A[0,i] = 0;
                A[i,0] = 0;
            }

            string[] S;
            S = ArrayToString(A);
            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_3_3()
        {
            string error = "ошибка 3_3";
            int n;
            Console.WriteLine("ведите n(n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine(error);
                return;
            }

            double[,] A = new double[n, n];
            List<double> ans = new List<double>(2 * n - 1);
            Console.WriteLine($"ведите {n} строк {n} столбца ");
            for (int i = 0; i < n; ++i)
            {
                int minJ = 0;
                if (!Input.CheckSplitRead(out List<double> L, error, n))
                {
                    return;
                }
                for (int j = 0; j < n; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;
                }

            }
            for (int i = n - 1; i >= 0; --i) 
            {
                double sum = 0;
                for (int j = 0; j + i< n; ++j)
                {
                    sum += A[i + j, j];
                }
                ans.Add(sum);
            }

            for (int j = 1; j < n; ++j) 
            {
                double sum = 0;
                for (int i = 0; i + j < n; ++i)
                {
                    sum += A[i , j + i];
                }
                ans.Add(sum);
            }

            string S;
            S = ListToString(ans);
            Console.WriteLine("ans : " + S);
        }
        static void exercise_3_4()
        {
            string error = "ошибка 3_4";
            int n;
            Console.WriteLine("ведите n(n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine(error);
                return;
            }

            double[,] A = new double[n, n];
            
            Console.WriteLine($"ведите {n} строк {n} столбца ");

            for (int i = 0; i < n; ++i)
            {

                if (!Input.CheckSplitRead(out List<double> L, error, n))
                {
                    return;
                }
                for (int j = 0; j < n; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;
                }

            }

            for (int i = n / 2; i < n; ++i) 
            {
                for (int j = 0; j < i; ++j) 
                {
                    A[i, j] = 0;
                }
            }

            string[] S;
            S = ArrayToString(A);
            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_3_8()
        {
            string error = "ошибка 3_8";
            int n = 7, m = 5;
            double[,] A = new double[n, m], B = new double[n, m];
            List<(double, int)> l = new List<(double, int)>();
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            for (int i = 0; i < n; ++i)
            {
                double kol = 0;
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;

                    if(a > 0)
                    {
                        kol++;
                    }
                }

                l.Add((kol, i));

            }

            l.Sort(Compare);
            //Console.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                var to = l[i];
                //Console.WriteLine(to.Item1.ToString() + " " + to.Item2.ToString());
                for (int j = 0; j < m; ++j)
                {
                    B[i, j] = A[to.Item2, j];
                }
            }

            string[] S;
            S = ArrayToString(B);
            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_3_10()
        {
            string error = "ошибка 3_10";
            int n, m;
            Console.WriteLine("ведите n(n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine(error);
                return;
            }

            Console.WriteLine("ведите m(m >= 0)");
            if (!Input.CheckRead(out m, error))
            {
                return;
            }
            if (m < 0)
            {
                Console.WriteLine(error);
                return;
            }
            double[,] A = new double[n, m];
            Console.WriteLine($"ведите {n} строк {m} столбца ");

            for (int i = 0; i < n; ++i)
            {
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;

                }
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = j; k < m; k++)
                    {
                        if (A[i, j] > A[i, k] && i % 2 == 1) 
                        {
                            (A[i, k], A[i, j]) = (A[i, j], A[i, k]);
                        }

                        if (A[i, j] < A[i, k] && i % 2 == 0)
                        {
                            (A[i, k], A[i, j]) = (A[i, j], A[i, k]);
                        }
                    }
                }
            }

            string[] S;
            S = ArrayToString(A);
            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_3_11()
        {
            string error = "ошибка 3_11";
            int n, m;
            Console.WriteLine("ведите n(n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine(error);
                return;
            }

            Console.WriteLine("ведите m(m >= 0)");
            if (!Input.CheckRead(out m, error))
            {
                return;
            }
            if (m < 0)
            {
                Console.WriteLine(error);
                return;
            }
            int kolDel = 0;
            double[,] A = new double[n, m];
            Console.WriteLine($"ведите {n} строк {m} столбца ");
            Dictionary<int,bool> map = new Dictionary<int,bool>();
            for (int i = 0; i < n; ++i)
            {
                bool fl = true;
                if (!Input.CheckSplitRead(out List<double> L, error, m))
                {
                    return;
                }
                for (int j = 0; j < m; ++j)
                {

                    double a = L[j];

                    A[i, j] = a;
                    if(a == 0)
                    {
                        fl = false;
                    }

                }
                if (fl)
                {
                    kolDel++;
                    map[i] = true;
                }
            }
            double[,] B = new double[n - kolDel, m];
            int shi = 0;
            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(i)) continue;
                for (int j = 0; j < m; j++)
                {
                    B[shi, j] = A[i, j]; 
                }
                shi++;
            }

            string[] S;
            S = ArrayToString(B);
            Console.WriteLine("ans : ");

            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
        }

        static void Main(string[] args)
        {
            #region exercise 1_3
            exercise_1_3();
            #endregion

            #region exercise 1_6
            exercise_1_6();
            #endregion

            #region exercise 1_12
            exercise_1_12();
            #endregion

            #region exercise 1_13
            exercise_1_13();
            #endregion

            #region exercise 1_17
            exercise_1_17();
            #endregion

            #region exercise 1_29
            exercise_1_29();
            #endregion

            #region exercise 1_31
            exercise_1_31();
            #endregion

            #region exercise 2_7
            exercise_2_7();
            #endregion

            #region exercise 2_8
            exercise_2_8();
            #endregion

            #region exercise 2_9
            exercise_2_9();
            #endregion

            #region exercise 3_1
            exercise_3_1();
            #endregion

            #region exercise 3_2
            exercise_3_2();
            #endregion

            #region exercise 3_3
            exercise_3_3();
            #endregion

            #region exercise 3_4
            exercise_3_4();
            #endregion

            #region exercise 3_8
            exercise_3_8();
            #endregion

            #region exercise 3_10
            exercise_3_10();
            #endregion

            #region exercise 3_11
            exercise_3_11();
            #endregion

        }
    }

    static class Input
    {
        const string EndString = "";

        static public bool Read(out double x)
        {
            string s;
            s = Console.ReadLine();

            if (!double.TryParse(s, out x))
            {
                return false;
            }
            return true;
        }
        static public bool Read(out int x)
        {
            string s;
            s = Console.ReadLine();

            if (!int.TryParse(s, out x))
            {
                return false;
            }
            return true;
        }
        static public bool Read(out int x, out bool fl)
        {
            fl = false;
            string s;
            s = Console.ReadLine();
            if (s == EndString) fl = true;
            if (!int.TryParse(s, out x))
            {
                return fl;
            }
            return true;
        }
        static public bool Read(out double x, out bool fl)
        {
            fl = false;
            string s;
            s = Console.ReadLine();
            if (s == EndString) fl = true;
            if (!double.TryParse(s, out x))
            {
                return fl;
            }
            return true;
        }

        static public bool CheckRead(out double x, string Erorr = "ошибка", string? ans = null)
        {
            bool fl;
            if (!Read(out x, out fl))
            {
                Console.WriteLine(Erorr);
                return false;
            }

            if (fl)
            {
                if (ans != null)
                {
                    Console.WriteLine(ans);
                }
                return false;
            }
            return true;
        }
        static public bool CheckRead(out int x, string Erorr = "ошибка", string? ans = null)
        {
            bool fl;
            if (!Read(out x, out fl))
            {
                Console.WriteLine(Erorr);
                return false;
            }

            if (fl)
            {
                if (ans != null)
                {
                    Console.WriteLine(ans);
                }
                return false;
            }
            return true;
        }
        static public bool CheckSplitRead(out List<double> L, string Erorr = "ошибка", int? kol = null, string? ans = null)
        {
            List<double> l = new List<double>();
            L = l;
            string? s = Console.ReadLine();
            if (s == EndString)
            {
                if (ans != null)
                {
                    Console.WriteLine(ans);
                }
                return false;
            }
            if (s == null)
            {
                Console.WriteLine(Erorr);
                return false;
            }
            string[] S = s.Split(" ");
            foreach (string st in S)
            {
                double x;
                if (st == "") continue;
                if (!double.TryParse(st, out x))
                {
                    Console.WriteLine(Erorr);
                    return false;
                }
                L.Add(x);
            }
            if(kol != null && L.Count() != kol)
            {
                Console.WriteLine("не верное количество элементов в строке");
                return false;
            }
            return true;
        }
    }

}