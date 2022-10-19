using System;
using System.ComponentModel.Design;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace _4_Lab
{
    class Program
    {
        private static int n;
        private static int m;
        private static double s;
        private static double k;
        private static double NMin = Double.MaxValue;
        private static int IMin = 0;
        private static double NMax = Double.MinValue;
        private static int[] IMax = new int[2];
        private static int i1 = 0, j1 = 0;
        private static List<Tuple<double, int>> MinEl = new List<Tuple<double, int>>();
        private static List<double> OddEl = new List<double>();
        private static List<double> EvenEl = new List<double>();
        private static List<int> El = new List<int>();
        private static List<Tuple<int, int>> PosEl = new List<Tuple<int, int>>();

        static void Task3_1lvl()
        {
            Console.WriteLine("1 Level:");
            Console.WriteLine("Task 3:");
            double[,] A = new double[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        A[i, j] = s;
                        if (i == j)
                        {
                            k += A[i, j];
                        }
                    }
                }
            }
        

            Console.WriteLine("Matrix:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"The sum of the trace is equal to {k}");
        }
        static void Task6_1lvl()
        {
            Console.WriteLine("6 Task:");
            double[,] A = new double[4, 7];
            List<int> MinIndex = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                NMin = Double.MaxValue;
                IMin = 0;
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        A[i, j] = s;
                        if (s < NMin)
                        {
                            NMin = s;
                            IMin = j;
                        }
                    }
                }
                MinIndex.Add(IMin);
            }

            Console.WriteLine("Final array:");
            Console.WriteLine(String.Join(" ", MinIndex));
        }
        static void Task12_1lvl()
        {
            Console.WriteLine("12 Task:");
            double[,] A = new double[6, 7];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        A[i, j] = s;
                        if (s > NMax)
                        {
                            NMax = s;
                            IMax[0] = i;
                            IMax[1] = j;
                        }
                    }
                }
            }
            Console.WriteLine("Matrix:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                if (i >= IMax[0])
                {
                    i1 = i + 1;
                }
                else
                {
                    i1 = i;
                }
                for (int j = 0; j < 6; j++)
                {
                    if (j >= IMax[1])
                    {
                        j1 = j + 1;
                    }
                    else
                    {
                        j1 = j;
                    }

                    A[i, j] = A[i1, j1];
                }
            }
            Console.WriteLine("Final matrix:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
        }
        static void Task13_1lvl()
        {
            Console.WriteLine("13 Task:");
            double[,] A = new double[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        A[i, j] = s;
                        if (i == j)
                        {
                            if (s > NMax)
                            {
                                NMax = s;
                                IMax[0] = j;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Matrix:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                k = A[i, 4];
                A[i, 4] = A[i, IMax[0]];
                A[i, IMax[0]] = k;
            }
            Console.WriteLine("Final matrix:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
        }
        static void Task17_1lvl()
        {
            Console.WriteLine("17 Task:");
            Console.WriteLine("Enter the number of rows:");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter the number of columns:");
                if (int.TryParse(Console.ReadLine(), out m))
                {
                    double[,] B = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                            if (double.TryParse(Console.ReadLine(), out s))
                            {
                                B[i, j] = s;
                                if (s < NMin)
                                {
                                    NMin = s;
                                    IMin = j;
                                }
                            }
                        }

                        k = B[i, 0];
                        B[i, 0] = B[i, IMin];
                        B[i, IMin] = k;
                    }
                    Console.WriteLine("Matrix:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write($"{B[i, j], 5}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        static void Task29_1lvl()
        {
            Console.WriteLine("29 Task:");
            double[,] F = new double[5, 7];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        F[i, j] = s;
                        if (i != 1) continue;
                        if (Math.Abs(s) < Math.Abs(NMin))
                        {
                            NMin = s;
                            IMin = j;
                        }
                    }
                }
            }
            Console.WriteLine("Matrix:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write($"{F[i, j], 5}");
                }
                Console.WriteLine();
            }
            IMin++;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j >= IMin)
                    {
                        j1 = j + 1;
                    }
                    else
                    {
                        j1 = j;
                    }

                    F[i, j] = F[i, j1];
                }
            }
            Console.WriteLine("Final matrix:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{F[i, j], 5}");
                }
                Console.WriteLine();
            }
        }
        static void Task31_1lvl()
        {
            Console.WriteLine("31 Task:");
            double[,] A = new double[5, 8];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        A[i, j] = s;
                        if (i != 4) continue;
                        if (s < NMin)
                        {
                            NMin = s;
                            IMin = j;
                        }
                    }
                }
            }
            Console.WriteLine("Matrix:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
            double[] B = new double[5];
            for (int i = 0; i < 5; i++)
            {
                if (double.TryParse(Console.ReadLine(), out s))
                {
                    B[i] = s;
                }
            }

            IMin++;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 6; j > 0; j--)
                {
                    if (j >= IMin)
                    {
                        j1 = j + 1;
                    }
                    else
                    {
                        j1 = j;
                    }

                    A[i, j1] = A[i, j];
                    if (j == IMin)
                    {
                        A[i, j] = B[i];
                    }
                }
                
            }
            Console.WriteLine("Final matrix:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
        }

        static void Task7_2lvl()
        {
            Console.WriteLine("2 Level:");
            Console.WriteLine("7 Task:");
            double[,] A = new double[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        A[i, j] = s;
                        if (i == j)
                        {
                            if (s > NMax)
                            {
                                NMax = s;
                                IMax[0] = i;
                                IMax[1] = j;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Matrix:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = (i + 1); j < 6; j++)
                {
                    if (i < IMax[0])
                    {
                        A[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("Final matrix:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
        }
        static void Task8_2lvl()
        {
            Console.WriteLine("8 Task:");
            double[,] B = new double[6, 6];
            for (int i = 0; i < 6; i++)
            {
                i1 = (i % 2);
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        B[i, j] = s;
                        if (s > NMax)
                        {
                            NMax = s;
                            IMax[i1] = j;
                        }
                    }
                }
                if (i1 == 1)
                {
                    k = B[i - 1, IMax[0]];
                    B[i - 1, IMax[0]] = B[i, IMax[1]];
                    B[i, IMax[1]] = k;
                }
            }
            Console.WriteLine("Matrix:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{B[i, j], 5}");
                }
                Console.WriteLine();
            }
        }
        static void Task9_2lvl()
        {
            Console.WriteLine("9 Task;");
            double[,] A = new double[6, 7];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        A[i, j] = s;
                    }
                }
                
            }
            Console.WriteLine("Matrix:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < (7 / 2); j++)
                {
                    k = A[i, j];
                    A[i, j] = A[i, 6 - j];
                    A[i, 6 - j] = k;
                }
            }
            Console.WriteLine("Final matrix:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
        }

        static void Task1_3lvl()
        {
            Console.WriteLine("3 Level:");
            Console.WriteLine("1 Task:");
            double[,] A = new double[14, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {   
                        A[i, j] = s;
                        if (s < NMin)
                        {
                            NMin = s;
                        }
                    }
                }
                MinEl.Add(Tuple.Create(NMin, i));
                NMin = Double.MaxValue;
                IMin = 0;
            }

            MinEl.OrderBy(x => x.Item1);
            MinEl.Reverse();
            for (int i = 7; i < 14; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = A[MinEl[i1].Item2, j];
                }
                i1++;
            }
            Console.WriteLine("Matrix:");
            for (int i = 7; i < 14; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
        }
        static void Task2_3lvl()
        {
            Console.WriteLine("2 Task:");
            Console.WriteLine("Enter the number of rows and columns for matrix:");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                double[,] A = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                        if (double.TryParse(Console.ReadLine(), out s))
                        {
                            A[i, j] = s;
                        }
                    }
                }
                Console.WriteLine("Matrix:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{A[i, j], 5}");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < (n * n); i++)
                {
                    if (i / n == 0 || i / n == (n - 1) || i % n == 0 || i % n == (n - 1))
                    {
                        A[i / n, i % n] = 0;
                    }
                }
                Console.WriteLine("Final matrix:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{A[i, j], 5}");
                    }
                    Console.WriteLine();
                }

            }
        }
        static void Task3_3lvl()
        {
            Console.WriteLine("3 Task:");
            Console.WriteLine("Enter the number of rows and columns for matrix:");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                double[,] A = new double[n, n];
                double[] B = new double[2 * n - 1];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                        if (double.TryParse(Console.ReadLine(), out s))
                        {
                            A[i, j] = s;
                            i1 = (i - j);
                            if (i1 < 0)
                            {
                                i1 += (n + 3 * (j - i) / 2 + (j - i) / (n - 1));
                            }
                            B[i1] += s;
                        }
                    }
                }
                Console.WriteLine("Matrix:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{A[i, j], 5}");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine(String.Join(" ", B));
            }
        }
        static void Task4_3lvl()
        {
            Console.WriteLine("4 Task:");
            Console.WriteLine("Enter the number of rows and columns for matrix:");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                double[,] A = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                        if (double.TryParse(Console.ReadLine(), out s))
                        {
                            A[i, j] = s;
                            if (i < (n / 2)) continue;
                            if ((i - j) < 0) continue;
                            A[i, j] = 1;
                        }
                    }
                }
                Console.WriteLine("Matrix:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{A[i, j], 5}");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Task8_3lvl()
        {
            Console.WriteLine("8 Task:");
            double[,] A = new double[14, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                    if (double.TryParse(Console.ReadLine(), out s))
                    {
                        A[i, j] = s;
                        if (s > 0) j1++;
                        
                    }
                }
                PosEl.Add(Tuple.Create(j1, i));
                j1 = 0;
            }
            PosEl.OrderBy(x => x.Item1);
            PosEl.Reverse();
            for (int i = 7; i < 14; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = A[PosEl[i1].Item2, j];
                }
                i1++;
            }
            Console.WriteLine("Matrix:");
            for (int i = 7; i < 14; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{A[i, j], 5}");
                }
                Console.WriteLine();
            }
        } 
        static void Task10_3lvl()
        {
            Console.WriteLine("10 Task:");
            Console.WriteLine("Enter the number of rows for matrix:");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter the number of columns for matrix:");
                if (int.TryParse(Console.ReadLine(), out m))
                {
                    double[,] A = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                            if (double.TryParse(Console.ReadLine(), out s))
                            {
                                A[i, j] = s;
                                if ((j % 2) == 0) EvenEl.Add(s);
                                else OddEl.Add(s);
                            }
                        }
                        EvenEl.Sort();
                        EvenEl.Reverse();
                        OddEl.Sort();
                        for (int x = 0; x < EvenEl.Count; x++)
                        {
                            A[i, 2 * x] = EvenEl[x];
                        }
                        for (int z = 0; z < OddEl.Count; z++)
                        {
                            A[i, 2 * z + 1] = OddEl[z];
                        }

                        EvenEl = new List<double>();
                        OddEl = new List<double>();
                    }
                    Console.WriteLine("Matrix:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write($"{A[i, j], 5}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        static void Task11_3lvl()
        {
            Console.WriteLine("11 Task:");
            Console.WriteLine("Enter the number of rows:");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter the number of columns:");
                if (int.TryParse(Console.ReadLine(), out m))
                {
                    double[,] A = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine($"Enter the element for {i} row, {j} column for matrix");
                            if (double.TryParse(Console.ReadLine(), out s))
                            {
                                A[i, j] = s;
                                if (s != 0) continue;
                                El.Add(i);
                            }
                        }
                    }

                    Console.WriteLine(String.Join(" ", El));
                    for (int i = 1; i < n; i++)
                    {
                        if (El.Contains(i) == false)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                A[El[i1], j] = A[i, j];
                            }
                        }
                    }
                    Console.WriteLine("Matrix:");
                    for (int i = 0; i < (n - El.Count); i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write($"{A[i, j], 5}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Task3_1lvl();
            Task6_1lvl();
            Task12_1lvl();
            Task13_1lvl();
            Task17_1lvl();
            Task29_1lvl();
            Task31_1lvl();
            Task7_2lvl();
            Task8_2lvl();
            Task9_2lvl();
            Task1_3lvl();
            Task2_3lvl();
            Task3_3lvl();
            Task4_3lvl();
            Task8_3lvl();
            Task10_3lvl();
            Task11_3lvl();
        }
        
    }
}
